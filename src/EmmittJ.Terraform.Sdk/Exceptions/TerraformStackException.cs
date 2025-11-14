namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Exception thrown when there's an error in Terraform stack configuration.
/// </summary>
public sealed class TerraformStackException : TerraformException
{
    /// <summary>
    /// Gets the property name associated with this exception, if any.
    /// </summary>
    public string? PropertyName { get; }

    /// <summary>
    /// Gets the property path for nested errors.
    /// </summary>
    public string? PropertyPath { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class.
    /// </summary>
    /// <param name="message">The error message.</param>
    public TerraformStackException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with block context.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="block">The block associated with this exception.</param>
    public TerraformStackException(string message, TerraformBlock block)
        : base(message, block)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with block and property context.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="block">The block associated with this exception.</param>
    /// <param name="propertyName">The property name where the error occurred.</param>
    public TerraformStackException(string message, TerraformBlock block, string propertyName)
        : base(message, block)
    {
        PropertyName = propertyName;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with full context.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="block">The block associated with this exception.</param>
    /// <param name="propertyName">The property name where the error occurred.</param>
    /// <param name="propertyPath">The full property path for nested errors.</param>
    public TerraformStackException(
        string message,
        TerraformBlock block,
        string propertyName,
        string propertyPath)
        : base(message, block)
    {
        PropertyName = propertyName;
        PropertyPath = propertyPath;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with an inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="innerException">The inner exception.</param>
    public TerraformStackException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with block and inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="block">The block associated with this exception.</param>
    /// <param name="innerException">The inner exception.</param>
    public TerraformStackException(string message, TerraformBlock block, Exception innerException)
        : base(message, block, innerException)
    {
    }
}
