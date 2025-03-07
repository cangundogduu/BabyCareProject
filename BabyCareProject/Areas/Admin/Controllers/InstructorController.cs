using BabyCareProject.Dtos.InstractorDtos;
using BabyCareProject.Services.InstructorServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController(IInstructorService _ınstructorService) : Controller
    {
        public async  Task<IActionResult> Index()
        {
            var values = await _ınstructorService.GetAllInstructorAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateInstructor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateInstructor(CreateInstractorDto createInstractorDto)
        {
            await _ınstructorService.CreateInstructorAsync(createInstractorDto);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteInstructor(string id)
        {
            await _ınstructorService.DeleteInstructorAsync(id);
            return RedirectToAction("Index");
        }



        [HttpGet] 
        public async Task<IActionResult> UpdateInstructor(string id)
        {
            var value = await _ınstructorService.GetByInstructorIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInstructor(UpdateInstractorDto updateInstractorDto)
        {
            await _ınstructorService.UpdateInstructorAsync(updateInstractorDto);
            return RedirectToAction("Index");
        }
    }
}
