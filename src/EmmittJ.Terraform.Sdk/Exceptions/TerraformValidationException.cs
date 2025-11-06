namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Exception thrown when Terraform configuration validation fails.
/// </summary>
public sealed class TerraformValidationException : TerraformException
{
    /// <summary>
    /// Gets the validation result that triggered this exception.
    /// </summary>
    public ValidationResult ValidationResult { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformValidationException"/> class.
    /// </summary>
    /// <param name="validationResult">The validation result containing the errors.</param>
    public TerraformValidationException(ValidationResult validationResult)
        : base(BuildMessage(validationResult))
    {
        ValidationResult = validationResult ?? throw new ArgumentNullException(nameof(validationResult));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformValidationException"/> class with a custom message.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="validationResult">The validation result containing the errors.</param>
    public TerraformValidationException(string message, ValidationResult validationResult)
        : base(message)
    {
        ValidationResult = validationResult ?? throw new ArgumentNullException(nameof(validationResult));
    }

    private static string BuildMessage(ValidationResult result)
    {
        if (result == null)
            return "Terraform configuration validation failed.";

        return $"Terraform configuration validation failed with {result.ErrorCount} error(s):\n{result.GetSummary()}";
    }
}
