using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjetoTreinamento.Application.Commands.Tarefas.Add;
using ProjetoTreinamento.Application.Commands.Tarefas.Delete;
using ProjetoTreinamento.Application.Commands.Tarefas.Update;
using ProjetoTreinamento.Application.Queries.Tarefas.Select;
using ProjetoTreinamento.Server.Filters;
using System.Net;

namespace ProjetoTreinamento.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefaController : BaseController
{
    protected TarefaController(
        IMediator mediatorService
    ) : base(mediatorService) { }

    [HttpPost]
    public async Task<IActionResult> AddTarefaAsync([FromBody] AddTarefaCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTarefaAsync([FromBody] DeleteTarefaCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.OK
        );

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTarefaAsync([FromBody] UpdateTarefaCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpGet("{id}")]
    public async Task<IActionResult> SelectTarefaAsync([FromBody] SelectTarefaCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );
}
