using BabyCareProject.Dtos.InstractorDtos;

namespace BabyCareProject.Services.InstructorServices
{
    public interface IInstructorService
    {
        Task<List<ResultInstractorDto>> GetAllInstructorAsync();
        Task<UpdateInstractorDto> GetByInstructorIdAsync(string id);
        Task CreateInstructorAsync(CreateInstractorDto createInstructorDto);
        Task UpdateInstructorAsync(UpdateInstractorDto updateInstructorDto);
        Task DeleteInstructorAsync(string id);
    }
}
