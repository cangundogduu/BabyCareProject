using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.InstractorDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.InstructorServices
{
    public class InstructorService : IInstructorService
    {

        private readonly IMongoCollection<Instructor> _instructorCollection;
        private readonly IMapper _mapper;


        public InstructorService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            _mapper = mapper;
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _instructorCollection = database.GetCollection<Instructor>(databaseSettings.InstractorCollectionName);
        }



        public async Task CreateInstructorAsync(CreateInstractorDto createInstructorDto)
        {
            var instructor = _mapper.Map<Instructor>(createInstructorDto);
            await _instructorCollection.InsertOneAsync(instructor);
        }

        public async Task DeleteInstructorAsync(string id)
        {
            await _instructorCollection.DeleteOneAsync(x => x.InstructorId == id);
        }

        public async Task<List<ResultInstractorDto>> GetAllInstructorAsync()
        {
            var values = await _instructorCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultInstractorDto>>(values);
        }

        public async Task<UpdateInstractorDto> GetByInstructorIdAsync(string id)
        {
            var instructor = await _instructorCollection.Find(x => x.InstructorId == id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateInstractorDto>(instructor);
        }

        public async Task UpdateInstructorAsync(UpdateInstractorDto updateInstructorDto)
        {
            var Instructor = _mapper.Map<Instructor>(updateInstructorDto);
            await _instructorCollection.FindOneAndReplaceAsync(x => x.InstructorId == Instructor.InstructorId, Instructor);
        }
    }
}
