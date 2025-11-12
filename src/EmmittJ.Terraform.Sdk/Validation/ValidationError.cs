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
    /// Gets the block where the error occurred, if applicable.
    /// </summary>
    public TerraformBlock? Block { get; }

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
    /// <param name="block">The block where the error occurred.</param>
    /// <param name="propertyName">The property name where the error occurred.</param>
    public ValidationError(
        string message,
        ValidationSeverity severity = ValidationSeverity.Error,
        TerraformBlock? block = null,
        string? propertyName = null)
    {
        Message = message ?? throw new ArgumentNullException(nameof(message));
        Severity = severity;
        Block = block;
        PropertyName = propertyName;
    }

    /// <summary>
    /// Gets a formatted error message including context information.
    /// </summary>
    public string GetFormattedMessage()
    {
        var parts = new List<string> { $"[{Severity}] {Message}" };

        if (Block != null)
        {
            if (Block is ITerraformTopLevelBlock topLevelBlock)
            {
                // Use BlockType and BlockLabels from interface
                var blockIdentifier = topLevelBlock.BlockLabels.Length > 0
                    ? $"{topLevelBlock.BlockType} \"{string.Join("\" \"", topLevelBlock.BlockLabels)}\""
                    : topLevelBlock.BlockType;
                parts.Add($"Block: {blockIdentifier}");
            }
            else
            {
                // Fallback for nested blocks
                parts.Add($"Block: {Block.GetType().Name}");
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
