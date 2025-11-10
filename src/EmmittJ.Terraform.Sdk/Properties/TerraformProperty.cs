namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base class for all Terraform properties. Represents a reference to a Terraform value.
/// Can be subclassed to add specific behaviors (literal values, expressions, etc.).
/// </summary>
/// <typeparam name="TValue">The type of the property value.</typeparam>
/// <remarks>
/// This is the foundation of the property type system. All properties resolve to TerraformExpression
/// for HCL serialization. Subclasses determine how the property behaves:
/// <list type="bullet">
/// <item><description><see cref="TerraformLiteralProperty{TValue}"/> - Stores literal values for arguments</description></item>
/// <item><description><see cref="TerraformExpressionProperty{TValue}"/> - Stores expression values</description></item>
/// <item><description><see cref="TerraformReferenceProperty{TValue, TSource, TIndex}"/> - Pure references (computed attributes, indexers)</description></item>
/// </list>
///
/// Usage patterns:
/// <code>
/// // Setting literal value (implicit conversion)
/// instance.Ami = "ami-12345";
///
/// // Referencing another resource (implicit conversion to expression)
/// otherInstance.Ami = instance.Ami;
///
/// // Using in expressions
/// var expr = instance.Ami.Resolve();
/// </code>
/// </remarks>
public class TerraformProperty<TValue> : ITerraformProperty
{
    protected readonly string _resourceAddress;
    protected readonly string _attributeName;

    /// <summary>
    /// Initializes a new Terraform property with resource address and attribute name.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource (e.g., "aws_instance.web").</param>
    /// <param name="attributeName">The name of the attribute (e.g., "ami").</param>
    internal TerraformProperty(string resourceAddress, string attributeName)
    {
        _resourceAddress = resourceAddress;
        _attributeName = attributeName;
    }

    /// <summary>
    /// Preparation phase - prepares nested values if applicable.
    /// Base implementation does nothing. Override in subclasses that contain nested preparable values.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public virtual void Prepare(ITerraformContext context)
    {
        // Nothing to prepare for a pure reference
    }

    /// <summary>
    /// Resolution phase - resolves to a Terraform expression.
    /// Base implementation returns an identifier reference expression.
    /// Override in subclasses to provide custom resolution logic.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform expression representing this property.</returns>
    public virtual TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // By default, resolves to an identifier reference
        return TerraformExpression.Identifier($"{_resourceAddress}.{_attributeName}");
    }

    /// <summary>
    /// Implicit conversion to TerraformExpression.
    /// Enables using properties directly in expressions and assignments.
    /// </summary>
    /// <param name="prop">The property to convert.</param>
    public static implicit operator TerraformExpression(TerraformProperty<TValue> prop)
        => prop.Resolve();
}
