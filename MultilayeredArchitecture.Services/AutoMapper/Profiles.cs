
using AutoMapper;

namespace MultilayeredArchitecture.Services.AutoMapper
{
    class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            #region Entity To View Model Mapping
           
            #endregion

            #region View Model To Entity Mapping
            //CreateMap<EmployeePostVM, Data.Models.Employee>()
            //    .ForMember(dest => dest.Job, opt => opt.Ignore());
            #endregion
        }
    }

    class JobProfile : Profile
    {
        public JobProfile()
        {
            #region Entity To View Model Mapping
            //CreateMap<Job, JobVM>()
            //    .ForMember(dest => dest.Name,
            //        opt => opt.MapFrom(LanguageHelper.GetSourceExpression<Job>()));
            #endregion
        }
    }
}