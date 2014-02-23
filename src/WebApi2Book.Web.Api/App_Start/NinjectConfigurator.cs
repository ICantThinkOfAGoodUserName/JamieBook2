﻿// NinjectConfigurator.cs
// Copyright fiserv 2014.

using log4net.Config;
using Ninject;
using WebApi2Book.Common.Logging;
using WebApi2Book.Web.Legacy;

namespace WebApi2Book.Web.Api
{
    /// <summary>
    ///     Class used to set up the Ninject DI container.
    /// </summary>
    public class NinjectConfigurator
    {
        /// <summary>
        ///     Entry method used by caller to configure the given
        ///     container with all of this application's
        ///     dependencies.
        /// </summary>
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }

        private void AddBindings(IKernel container)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            // IMPORTANT NOTE! *Never* configure a type as singleton if it depends upon IUnitOfWork!!! This is because
            // IUnitOfWork is disposed of at the end of every request. For the same reason, make sure that types
            // dependent upon such types aren't configured as singleton.
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            ConfigureLog4net(container);
            ConfigureDependenciesOnlyUsedForLegacyProcessing(container);

            container.Bind<ILegacyMessageTypeFormatter>().To<LegacyMessageTypeFormatter>();
        }

        private void ConfigureDependenciesOnlyUsedForLegacyProcessing(IKernel container)
        {
            container.Bind<ILegacyMessageParser>().To<LegacyMessageParser>().InSingletonScope();
        }

        private void ConfigureLog4net(IKernel container)
        {
            XmlConfigurator.Configure();

            var logManager = new LogManagerAdapter();
            container.Bind<ILogManager>().ToConstant(logManager);
        }
    }
}