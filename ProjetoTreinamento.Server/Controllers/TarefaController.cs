using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjetoTreinamento.Application.Commands.Tarefas.Add;
using ProjetoTreinamento.Application.Commands.Tarefas.Delete;
using ProjetoTreinamento.Application.Commands.Tarefas.Update;
using ProjetoTreinamento.Application.Queries.Tarefas.GetAll;
using ProjetoTreinamento.Application.Queries.Tarefas.Select;
using ProjetoTreinamento.Server.Filters;
using System.Net;

namespace ProjetoTreinamento.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : BaseController
{
    public TarefaController(
        IMediator mediatorService
    ) : base(mediatorService) { }

    [HttpPost("CreateTarefa")]
    public async Task<IActionResult> AddTarefaAsync([FromBody] AddTarefaCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> DeleteTarefaAsync([FromBody] int id) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(new DeleteTarefaCommand(id)),
            HttpStatusCode.OK
        );

    [HttpPut("UpdateTarefa/{id}")]
    public async Task<IActionResult> UpdateTarefaAsync([FromBody] UpdateTarefaCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> SelectTarefaAsync([FromRoute] int id) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(new SelectTarefaQuery(id)),
            HttpStatusCode.OK
        );
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllTarefaAsync([FromRoute] GetAllTarefaQuery request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.OK
        );
}
