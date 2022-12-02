using System.Net;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

using StreetWorkout.Api.Models.Equipment;
using StreetWorkout.Core.Interfaces;
using StreetWorkout.Core.Models.Equipment;

namespace StreetWorkout.Api.Controllers
{
    public class EquipmentController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IEquipmentService equipmentService;

        public EquipmentController(IMapper mapper, IEquipmentService equipmentService)
        {
            this.mapper = mapper;
            this.equipmentService = equipmentService;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Gets equipment",
            Description = "Gets equipment. ",
            OperationId = "GetEquipmentAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.BadRequest)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(List<ApiEquipment>))]
        public async Task<IActionResult> GetEquipmentAsync()
        {
            var equipment = await equipmentService.GetEquipmentAsync();
            var result = mapper.Map<List<ApiEquipment>>(equipment);

            return ContentResult(result);
        }


        [HttpPost]
        [SwaggerOperation(
            Summary = "Add equipment",
            Description = "Add equipment. Returns the id of the added equipment.",
            OperationId = "AddEquipmentAsync")]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.BadRequest)]
        [SwaggerResponse(statusCode: (int)HttpStatusCode.OK, type: typeof(int))]
        public async Task<IActionResult> AddEquipmentAsync(ApiAddEquipmentRequest request)
        {
            var coreRequest = mapper.Map<CoreAddEquipmentRequest>(request);
            var result = await equipmentService.AddEquipmentAsync(coreRequest);

            return ContentResult(result);
        }
    }
}
