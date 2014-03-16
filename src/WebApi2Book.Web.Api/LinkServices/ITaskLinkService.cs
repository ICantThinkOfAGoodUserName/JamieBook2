﻿// ITaskLinkService.cs
// Copyright Jamie Kurtz, Brian Wortman 2014.

using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.LinkServices
{
    public interface ITaskLinkService
    {
        void AddLinks(Task modelTask);
    }
}