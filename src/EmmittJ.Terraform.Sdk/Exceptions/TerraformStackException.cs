namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Exception thrown when there's an error in Terraform stack construction.
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
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with construct context.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="construct">The construct associated with this exception.</param>
    public TerraformStackException(string message, TerraformConstruct construct)
        : base(message, construct)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with construct and property context.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="construct">The construct associated with this exception.</param>
    /// <param name="propertyName">The property name where the error occurred.</param>
    public TerraformStackException(string message, TerraformConstruct construct, string propertyName)
        : base(message, construct)
    {
        PropertyName = propertyName;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with full context.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="construct">The construct associated with this exception.</param>
    /// <param name="propertyName">The property name where the error occurred.</param>
    /// <param name="propertyPath">The full property path for nested errors.</param>
    public TerraformStackException(
        string message,
        TerraformConstruct construct,
        string propertyName,
        string propertyPath)
        : base(message, construct)
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
    /// Initializes a new instance of the <see cref="TerraformStackException"/> class with construct and inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="construct">The construct associated with this exception.</param>
    /// <param name="innerException">The inner exception.</param>
    public TerraformStackException(string message, TerraformConstruct construct, Exception innerException)
        : base(message, construct, innerException)
    {
    }
}
