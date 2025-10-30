namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the result of validating a Terraform configuration.
/// </summary>
public sealed class ValidationResult
{
    /// <summary>
    /// Gets the collection of validation errors.
    /// </summary>
    public IReadOnlyList<ValidationError> Errors { get; }

    /// <summary>
    /// Gets a value indicating whether the validation was successful (no errors).
    /// </summary>
    public bool IsValid => !Errors.Any(e => e.Severity == ValidationSeverity.Error);

    /// <summary>
    /// Gets a value indicating whether there are any warnings.
    /// </summary>
    public bool HasWarnings => Errors.Any(e => e.Severity == ValidationSeverity.Warning);

    /// <summary>
    /// Gets the number of errors (not including warnings or info).
    /// </summary>
    public int ErrorCount => Errors.Count(e => e.Severity == ValidationSeverity.Error);

    /// <summary>
    /// Gets the number of warnings.
    /// </summary>
    public int WarningCount => Errors.Count(e => e.Severity == ValidationSeverity.Warning);

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationResult"/> class.
    /// </summary>
    /// <param name="errors">The collection of validation errors.</param>
    public ValidationResult(IEnumerable<ValidationError> errors)
    {
        Errors = (errors ?? throw new ArgumentNullException(nameof(errors))).ToList();
    }

    /// <summary>
    /// Creates a successful validation result with no errors.
    /// </summary>
    public static ValidationResult Success() => new(Array.Empty<ValidationError>());

    /// <summary>
    /// Creates a validation result with a single error.
    /// </summary>
    public static ValidationResult Error(string message, ITerraformConstruct? construct = null, string? propertyName = null)
        => new(new[] { new ValidationError(message, ValidationSeverity.Error, construct, propertyName) });

    /// <summary>
    /// Gets a formatted summary of all validation errors.
    /// </summary>
    public string GetSummary()
    {
        if (IsValid && !HasWarnings)
        {
            return "Validation succeeded with no errors or warnings.";
        }

        var summary = new List<string>();

        if (ErrorCount > 0)
        {
            summary.Add($"{ErrorCount} error(s)");
        }

        if (WarningCount > 0)
        {
            summary.Add($"{WarningCount} warning(s)");
        }

        var lines = new List<string>
        {
            $"Validation completed with {string.Join(", ", summary)}:",
            ""
        };

        foreach (var error in Errors)
        {
            lines.Add(error.GetFormattedMessage());
        }

        return string.Join(Environment.NewLine, lines);
    }

    /// <summary>
    /// Throws a <see cref="TerraformValidationException"/> if validation failed.
    /// </summary>
    /// <exception cref="TerraformValidationException">Thrown when validation has errors.</exception>
    public void ThrowIfInvalid()
    {
        if (!IsValid)
        {
            throw new TerraformValidationException(this);
        }
    }

    /// <summary>
    /// Returns a string representation of this validation result.
    /// </summary>
    public override string ToString() => GetSummary();
}
