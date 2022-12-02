using System.Net;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

using StreetWorkout.Api.Models.Programs;
using StreetWorkout.Core.Interfaces;
using StreetWorkout.Core.Models.Programs;

namespace StreetWorkout.Api.Controllers
{
    public class ProgramsController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IProgramsService programsService;

        public ProgramsController(IMapper mapper, IProgramsService programsService)
        {
            this.mapper = mapper;
            this.programsService = programsService;
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Add program",
            Description = "Add program",
            OperationId = "AddProgramAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.BadRequest)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(int))]
        public async Task<IActionResult> AddProgramAsync(ApiAddProgramRequest request)
        {
            var coreRequest = mapper.Map<CoreAddProgramRequest>(request);

            var result = await programsService.AddProgramAsync(coreRequest);

            return ContentResult(result);
        }

        [HttpDelete]
        [SwaggerOperation(
            Summary = "Delete program",
            Description = "Delete program",
            OperationId = "DeleteProgramAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.BadRequest)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(bool))]
        public async Task<IActionResult> DeleteProgramAsync(int id)
        {
            var result = await programsService.DeleteProgramAsync(id);

            return ContentResult(result);
        }

        [HttpGet("{id:int:min(1)}")]
        [SwaggerOperation(
            Summary = "Get program",
            Description = "Get program",
            OperationId = "GetProgramAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.NotFound)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(ApiProgram))]
        public async Task<IActionResult> GetProgramAsync(int id)
        {
            var coreProgram = await programsService.GetProgramAsync(id);

            var result = mapper.Map<ApiProgram>(coreProgram);

            return ContentResult(result);
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Get all programs",
            Description = "Get all programs",
            OperationId = "GetProgramsAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.NotFound)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(List<ApiProgram>))]
        public async Task<IActionResult> GetProgramsAsync()
        {
            var corePrograms = await programsService.GetProgramsAsync();

            var result = mapper.Map<List<ApiProgram>>(corePrograms);

            return ContentResult(result);
        }

        [HttpPut("{id:int:min(1)}")]
        [SwaggerOperation(
            Summary = "Update program",
            Description = "Update program",
            OperationId = "UpdateProgramAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.NotFound)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(bool))]
        public async Task<IActionResult> UpdateProgramAsync(int id, ApiUpdateProgramRequest request)
        {
            var coreRequest = mapper.Map<CoreUpdateProgramRequest>(request);

            var result = await programsService.UpdateProgramAsync(id, coreRequest);

            return ContentResult(result);
        }
    }
}
