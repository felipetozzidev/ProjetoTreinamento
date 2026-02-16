using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjetoTreinamento.Application.Models.DTOs.Bases;
using ProjetoTreinamento.CrossCutting.Exceptions.Bases;
using System.Net;

namespace ProjetoTreinamento.Server.Filters;

public class BaseController : Controller
{
    protected IMediator MediatorService { get; }

    protected BaseController(IMediator mediatorService)
    {
        MediatorService = mediatorService;
    }

    protected virtual async Task<IActionResult> GenerateResponseAsync<TDataObject>(Func<Task<TDataObject>> func, HttpStatusCode responseCode, string successMessage = "")
    {
        try
        {
            return StatusCode(
                (int)responseCode,
                new APIResponse<TDataObject>(
                    await func(),
                    true,
                    successMessage
                )
            );
        }
        catch (ApiHttpCustomException ex)
        {
            return HandleExceptionResult(ex);
        }
        catch (Exception ex2)
        {
            return HandleValidationExceptionResult(ex2);
        }
    }

    protected virtual async Task<IActionResult> GenerateResponseAsync(Func<Task> func, HttpStatusCode responseCode, string successMessage = "")
    {
        try
        {
            await func();
            return StatusCode(
                (int)responseCode,
                new APIResponse(true, successMessage)
            );
        }
        catch (ApiHttpCustomException ex)
        {
            return HandleExceptionResult(ex);
        }
        catch (Exception ex2)
        {
            return HandleValidationExceptionResult(ex2);
        }
    }

    private IActionResult HandleExceptionResult(ApiHttpCustomException ex)
    {
        if (string.Empty.Equals(ex.Message))
            return StatusCode((int)ex.ResponseCode);

        return StatusCode(
            (int)ex.ResponseCode,
            new APIResponse(false, ex.Message)
        );
    }

    private IActionResult HandleValidationExceptionResult(Exception ex)
    {
        return StatusCode(
            500,
            new APIResponse(false, ex.Message)
        );
    }
}

