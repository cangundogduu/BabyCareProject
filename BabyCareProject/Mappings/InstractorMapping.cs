using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.InstractorDtos;

namespace BabyCareProject.Mappings
{
    public class InstractorMapping : Profile
    {
        public InstractorMapping()
        {
            CreateMap<ResultInstractorDto,Instructor>().ReverseMap();
            CreateMap<CreateInstractorDto,Instructor>().ReverseMap();
            CreateMap<UpdateInstractorDto,Instructor>().ReverseMap();
        }
    }
}
