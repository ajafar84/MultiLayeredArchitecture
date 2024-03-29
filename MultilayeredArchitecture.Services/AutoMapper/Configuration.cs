﻿using AutoMapper;

namespace MultilayeredArchitecture.Services.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Mapper;

        public static void Configure()
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<EmployeeProfile>();
                cfg.AddProfile<JobProfile>();            
            });

            Mapper = configuration.CreateMapper();
        }
    }
}
