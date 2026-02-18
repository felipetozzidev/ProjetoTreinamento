using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjetoTreinamento.Application.Commands.Itens.Add;
using ProjetoTreinamento.Application.Commands.Itens.Delete;
using ProjetoTreinamento.Application.Commands.Itens.Update;
using ProjetoTreinamento.Application.Commands.Tarefas.Delete;
using ProjetoTreinamento.Application.Queries.Checklists.Select;
using ProjetoTreinamento.Application.Queries.Tarefas.Select;
using ProjetoTreinamento.Server.Filters;
using System.Net;

namespace ProjetoTreinamento.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : BaseController
{
    public ItemController(
        IMediator mediatorService
    ) : base(mediatorService) { }

    [HttpPost]
    public async Task<IActionResult> AddTarefaAsync([FromBody] AddItemCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTarefaAsync([FromBody] int id) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(new DeleteTarefaCommand(id)),
            HttpStatusCode.OK
        );

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTarefaAsync([FromBody] UpdateItemCommand request) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(request),
            HttpStatusCode.Created
        );

    [HttpGet("{id}")]
    public async Task<IActionResult> SelectTarefaAsync([FromRoute] int id) =>
        await GenerateResponseAsync(
            async () => await MediatorService.Send(new SelectTarefaQuery(id)),
            HttpStatusCode.Created
        );
}
