﻿// IAllUsersDataRequestFactory.cs
// Copyright Jamie Kurtz, Brian Wortman 2014.

using System;
using WebApi2Book.Data.SqlServer.DataTransferObjects;

namespace WebApi2Book.Web.Api.InquiryProcessing
{
    public interface IAllUsersDataRequestFactory
    {
        AllUsersDataRequest Create(Uri requestUri);
    }
}