using System.Net;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

using StreetWorkout.Api.Models.Exercises;
using StreetWorkout.Core.Interfaces;
using StreetWorkout.Core.Models.Exercises;

namespace StreetWorkout.Api.Controllers
{
    public class ExercisesController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IExercisesService exercisesService;

        public ExercisesController(IMapper mapper, IExercisesService exercisesService)
        {
            this.mapper = mapper;
            this.exercisesService = exercisesService;
        }

        [HttpGet("{id:int:min(1)}")]
        [SwaggerOperation(
            Summary = "Get exercise by id",
            Description = "Get exercise by id",
            OperationId = "GetExerciseAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.NotFound)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(ApiExercise))]
        public async Task<IActionResult> GetExerciseAsync(int id)
        {
            var coreExercise = await exercisesService.GetExerciseAsync(id);

            var result = mapper.Map<ApiExercise>(coreExercise);

            return ContentResult(result);
        }

        [HttpGet()]
        [SwaggerOperation(
            Summary = "Get all exercises",
            Description = "Get all exercises",
            OperationId = "GetExercisesAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.NotFound)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(ApiExercise))]
        public async Task<IActionResult> GetExercisesAsync()
        {
            var coreExercises = await exercisesService.GetExercisesAsync();

            var result = mapper.Map<List<ApiExercise>>(coreExercises);

            return ContentResult(result);
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Add exercise",
            Description = "Add exercise. Returns the id of the added exercise.",
            OperationId = "AddExerciseAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.BadRequest)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(int))]
        public async Task<IActionResult> AddExerciseAsync(ApiAddExerciseRequest request)
        {
            var coreRequest = mapper.Map<CoreAddExerciseRequest>(request);
            var result = await exercisesService.AddExerciseAsync(coreRequest);

            return ContentResult(result);
        }
    }
}
