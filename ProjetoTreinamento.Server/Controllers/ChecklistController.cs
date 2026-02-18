using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjetoTreinamento.Application.Commands.Checklists.Add;
using ProjetoTreinamento.Application.Commands.Checklists.Delete;
using ProjetoTreinamento.Application.Commands.Checklists.Update;
using ProjetoTreinamento.Application.Queries.Checklists.Select;
using ProjetoTreinamento.Server.Filters;
using System.Net;

namespace ProjetoTreinamento.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChecklistController : BaseController
{
    public ChecklistController(
        IMediator mediatorService
    ) : base(mediatorService) { }

    [HttpPost]
    public async Task<IActionResult> AddChecklistAsync([FromBody] AddChecklistCommand request) => 
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteChecklistAsync([FromBody] int id) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(new DeleteChecklistCommand(id)),
            HttpStatusCode.OK
        );

    [HttpPut]
    public async Task<IActionResult> UpdateChecklistAsync([FromBody] UpdateChecklistCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpGet("{id}")]
    public async Task<IActionResult> SelectChecklistAsync([FromRoute] int id) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(new SelectChecklistQuery(id)),
            HttpStatusCode.OK
        );
}
