using System.Collections.Generic;
using Core.Extensions;
using FluentValidation.Results;

public class ValidationErrorDetails : ErrorDetails
{
    public IEnumerable<ValidationFailure> Errors { get; set; }
}