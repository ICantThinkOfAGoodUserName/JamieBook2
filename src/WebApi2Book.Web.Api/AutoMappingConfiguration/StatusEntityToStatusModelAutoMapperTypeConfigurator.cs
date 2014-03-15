﻿// StatusEntityToStatusModelAutoMapperTypeConfigurator.cs
// Copyright Jamie Kurtz, Brian Wortman 2014.

using AutoMapper;
using WebApi2Book.Common.TypeMapping;
using WebApi2Book.Data.Entities;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class StatusEntityToStatusModelAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<Status, Models.Status>()
                .ForMember(opt => opt.Links, x => x.Ignore())
                .ForMember(opt => opt.Location, x => x.Ignore());
        }
    }
}