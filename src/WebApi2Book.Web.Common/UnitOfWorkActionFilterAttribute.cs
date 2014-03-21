﻿// UnitOfWorkActionFilterAttribute.cs
// Copyright Jamie Kurtz, Brian Wortman 2014.

using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApi2Book.Web.Common
{
    public class UnitOfWorkActionFilterAttribute : ActionFilterAttribute
    {
        private readonly IActionTransactionHelper _actionTransactionHelper;

        public UnitOfWorkActionFilterAttribute()
            : this(WebContainerManager.Get<IActionTransactionHelper>())
        {
        }

        /// <summary>
        /// To prevent filter from executing twice on same call. Problem solved by:
        /// http://stackoverflow.com/questions/18485479/webapi-filter-is-calling-twice?rq=1
        /// </summary>
        public override bool AllowMultiple
        {
            get { return false; }
        }

        public UnitOfWorkActionFilterAttribute(IActionTransactionHelper actionTransactionHelper)
        {
            _actionTransactionHelper = actionTransactionHelper;
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            _actionTransactionHelper.BeginTransaction();
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            _actionTransactionHelper.EndTransaction(actionExecutedContext);
            _actionTransactionHelper.CloseSession();
        }
    }
}