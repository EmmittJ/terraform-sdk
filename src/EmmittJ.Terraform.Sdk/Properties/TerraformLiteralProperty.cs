namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform property that can store a literal value.
/// Used for arguments that can be set by the user.
/// </summary>
/// <typeparam name="TValue">The type of the value stored in this property.</typeparam>
/// <remarks>
/// This is the primary property type for user-settable arguments. It stores literal values
/// and supports implicit conversion from the value type for ergonomic usage.
///
/// Usage patterns:
/// <code>
/// // Setting literal value (implicit conversion)
/// instance.Ami = "ami-12345";
///
/// // Accessing the stored value (for serialization)
/// var value = ((ITerraformLiteral&lt;string&gt;)instance.Ami).Value;
///
/// // Using as reference in expressions
/// otherInstance.Ami = instance.Ami; // Resolves to aws_instance.web.ami
/// </code>
/// </remarks>
public class TerraformLiteralProperty<TValue> : TerraformProperty<TValue>, ITerraformLiteral<TValue>, ITerraformLiteral
{
    private TValue? _value;

    /// <summary>
    /// Initializes a new literal property.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the attribute.</param>
    internal TerraformLiteralProperty(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    /// <summary>
    /// Gets or sets the literal value stored in this property.
    /// Public getter for read access, internal setter for value assignment.
    /// </summary>
    public TValue? Value
    {
        get => _value;
        internal set => _value = value;
    }

    /// <summary>
    /// Implements ITerraformLiteral&lt;TValue&gt; - provides type-safe read-only access to the value.
    /// </summary>
    TValue? ITerraformLiteral<TValue>.Value => _value;

    /// <summary>
    /// Preparation phase - prepares nested preparable values if TValue contains them.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        // Prepare nested preparable values if TValue contains them
        if (_value is ITerraformPreparable preparable)
        {
            preparable.Prepare(context);
        }
    }

    /// <summary>
    /// Resolution phase - resolves to either a literal expression (if value set) or reference expression (if not set).
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform expression representing this property's value or reference.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // If value is set, resolve to literal expression
        if (_value is not null)
        {
            // If value is already resolvable, resolve it
            if (_value is ITerraformProperty resolvable)
            {
                return resolvable.Resolve(context);
            }

            // Otherwise, create literal expression
            return TerraformExpression.Literal(_value);
        }

        // If no value set, fall back to reference (for Optional+Computed scenarios)
        return base.Resolve(context);
    }

    /// <summary>
    /// Implicit conversion from literal value.
    /// Enables ergonomic property assignment: instance.Ami = "ami-12345"
    /// </summary>
    /// <param name="value">The literal value to wrap.</param>
    public static implicit operator TerraformLiteralProperty<TValue>(TValue? value)
    {
        var prop = new TerraformLiteralProperty<TValue>("", "");
        prop._value = value;
        return prop;
    }
}
