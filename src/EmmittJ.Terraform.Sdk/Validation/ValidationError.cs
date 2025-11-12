namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a validation error found during Terraform configuration validation.
/// </summary>
public sealed class ValidationError
{
    /// <summary>
    /// Gets the error message describing the validation issue.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Gets the construct where the error occurred, if applicable.
    /// </summary>
    public TerraformBlock? Construct { get; }

    /// <summary>
    /// Gets the property name where the error occurred, if applicable.
    /// </summary>
    public string? PropertyName { get; }

    /// <summary>
    /// Gets the severity level of this validation error.
    /// </summary>
    public ValidationSeverity Severity { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationError"/> class.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="severity">The severity level.</param>
    /// <param name="construct">The construct where the error occurred.</param>
    /// <param name="propertyName">The property name where the error occurred.</param>
    public ValidationError(
        string message,
        ValidationSeverity severity = ValidationSeverity.Error,
        TerraformBlock? construct = null,
        string? propertyName = null)
    {
        Message = message ?? throw new ArgumentNullException(nameof(message));
        Severity = severity;
        Construct = construct;
        PropertyName = propertyName;
    }

    /// <summary>
    /// Gets a formatted error message including context information.
    /// </summary>
    public string GetFormattedMessage()
    {
        var parts = new List<string> { $"[{Severity}] {Message}" };

        if (Construct != null)
        {
            // Try to get BlockType property
            var blockTypeProperty = Construct.GetType().GetProperty("BlockType");
            var blockType = blockTypeProperty?.GetValue(Construct) as string ?? Construct.GetType().Name;
            parts.Add($"Construct: {blockType}");

            // Add the name if it has a ConstructName property
            var nameProperty = Construct.GetType().GetProperty("ConstructName");
            if (nameProperty != null)
            {
                var name = nameProperty.GetValue(Construct);
                if (name != null)
                {
                    parts.Add($"Name: {name}");
                }
            }
        }

        if (!string.IsNullOrEmpty(PropertyName))
        {
            parts.Add($"Property: {PropertyName}");
        }

        return string.Join(" | ", parts);
    }

    /// <summary>
    /// Returns a string representation of this validation error.
    /// </summary>
    public override string ToString() => GetFormattedMessage();
}

/// <summary>
/// Defines the severity levels for validation errors.
/// </summary>
public enum ValidationSeverity
{
    /// <summary>
    /// Informational message, not an error.
    /// </summary>
    Info,

    /// <summary>
    /// Warning that should be addressed but doesn't prevent generation.
    /// </summary>
    Warning,

    /// <summary>
    /// Error that prevents successful Terraform configuration generation.
    /// </summary>
    Error
}
