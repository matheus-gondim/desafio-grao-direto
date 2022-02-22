using GrainRestaurants.Core.DTOs.Shared;
using GrainRestaurants.Core.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Text.RegularExpressions;

namespace GrainRestaurants.API.Middleware
{
    public class ErrorHandler
    {
        private readonly static string INTERNAL_SERVER_ERROR = "Ocorreu um erro no servidor. Tente novamente mais tarde ou entre em contato com o time de TI.";
        private readonly static string NOT_FOUND_MESSAGE = "Parametro não encontrado.";
        private readonly static string FORBIDDEN_MESSAGE = "Sem autorização.";
        private readonly static string BAD_REQUEST_MESSAGE = "Requisição ruim.";
        private readonly static string UNAUTHORIZED_MESSAGE = "Não autenticado.";



        public static ErrorResponse Create(Exception error)
        {
            var errorType = error.GetType();

            if (errorType.Equals(typeof(ForbiddenException))) return Forbidden(error);
            if (errorType.Equals(typeof(NotFoundException))) return NotFound(error);
            if (errorType.Equals(typeof(DbUpdateConcurrencyException))) return DbUpdateConcurrency(error);
            if (errorType.Equals(typeof(DbUpdateException))) return DbUpdate(error);
            if (errorType.Equals(typeof(BadRequestException))) return BadRequest(error);
            if (errorType.Equals(typeof(UnauthorizedException))) return Unauthorized(error);
            return DefaultException(error);
        }

        private static ErrorResponse Unauthorized(Exception error)
        {
            return new()
            {
                Timestamp = DateTime.Now.ToLocalTime(),
                Messages = new()
                {
                    error?.Message ?? UNAUTHORIZED_MESSAGE
                },
                Status = (int)HttpStatusCode.Unauthorized,
                Error = "Unauthorized Exception"
            };

        }

        private static ErrorResponse BadRequest(Exception error)
        {
            return new()
            {
                Timestamp = DateTime.Now.ToLocalTime(),
                Messages = new()
                {
                    error?.Message ?? BAD_REQUEST_MESSAGE
                },
                Status = (int)HttpStatusCode.BadRequest,
                Error = "Bad Request Exception"
            };
        }

        private static ErrorResponse Forbidden(Exception error)
        {
            return new()
            {
                Timestamp = DateTime.Now.ToLocalTime(),
                Messages = new()
                {
                    error?.Message ?? FORBIDDEN_MESSAGE
                },
                Status = (int)HttpStatusCode.Forbidden,
                Error = "Forbidden Exception"
            };
        }

        private static ErrorResponse NotFound(Exception error)
        {
            return new()
            {
                Timestamp = DateTime.Now.ToLocalTime(),
                Messages = new()
                {
                    error?.Message ?? NOT_FOUND_MESSAGE
                },
                Status = (int)HttpStatusCode.NotFound,
                Error = "Not Found Exception"
            };
        }

        public static ErrorResponse DbUpdateConcurrency(Exception error)
        {
            return new()
            {
                Timestamp = DateTime.Now.ToLocalTime(),
                Messages = new()
                {
                    "Relação não encontrada"
                },
                Status = (int)HttpStatusCode.BadRequest,
                Error = "Bad Request Exception"
            };
        }

        public static ErrorResponse DbUpdate(Exception error)
        {
            ErrorResponse errorResponse = new()
            {
                Timestamp = DateTime.Now.ToLocalTime(),
                Messages = new(),
                Status = (int)HttpStatusCode.NotFound,
                Error = "Not Found Exception"
            };
            var message = error.InnerException?.Message ?? "";


            if (message.Contains("23503:"))
            {
                errorResponse.Messages.Add("Erro na relação das entidades");
            }
            else if (message.Contains("23505:"))
            {
                Regex rx = new(@"(?<=\w*_\w*_)[a-zA-Z]*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                var match = rx.Match(message);

                if (match is null)
                {
                    errorResponse.Messages.Add("Entidade ja cadastrada.");
                }
                else
                {
                    errorResponse.Messages.Add($"O parametro {match.Value} já foi cadastrado.");
                }
            }
            else
            {
                errorResponse = DefaultException(error);
                errorResponse.Messages.Add("Erro relacionado ao Banco de dados");
            }

            return errorResponse;
        }

        private static ErrorResponse DefaultException(Exception error)
        {
            return new()
            {
                Timestamp = DateTime.Now.ToLocalTime(),
                Messages = new()
                {
                    error?.Message ?? INTERNAL_SERVER_ERROR,
                },
                Status = (int)HttpStatusCode.InternalServerError,
                Error = "Internal Server Error"
            };
        }
    }
}
