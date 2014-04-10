﻿// ITaskUsersInquiryProcessor.cs
// Copyright Jamie Kurtz, Brian Wortman 2014.

using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.InquiryProcessing
{
    public interface ITaskUsersInquiryProcessor
    {
        TaskUsersInquiryResponse GetTaskUsers(long taskId);
    }
}