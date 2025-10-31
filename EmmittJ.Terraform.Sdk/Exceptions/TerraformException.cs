namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base exception class for all Terraform SDK exceptions.
/// </summary>
public class TerraformException : Exception
{
    /// <summary>
    /// Gets the construct associated with this exception, if any.
    /// </summary>
    public TerraformConstruct? Construct { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformException"/> class.
    /// </summary>
    public TerraformException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public TerraformException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformException"/> class with a specified error message and a reference to the inner exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public TerraformException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformException"/> class with a specified error message and construct.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="construct">The construct associated with this exception.</param>
    public TerraformException(string message, TerraformConstruct construct)
        : base(message)
    {
        Construct = construct;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformException"/> class with a specified error message, construct, and inner exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="construct">The construct associated with this exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public TerraformException(string message, TerraformConstruct construct, Exception innerException)
        : base(message, innerException)
    {
        Construct = construct;
    }
}
