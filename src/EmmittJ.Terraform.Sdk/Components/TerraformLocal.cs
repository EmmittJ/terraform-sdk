using System.Reflection;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform locals block containing local values.
/// </summary>
public class TerraformLocal : TerraformConstruct
{
    /// <inheritdoc/>
    public override string BlockType => "locals";

    /// <inheritdoc/>
    protected override string[] BlockLabels => Array.Empty<string>();

    /// <summary>
    /// Gets a reference to a local value.
    /// </summary>
    public TerraformReferenceExpression this[string name]
    {
        get
        {
            // Check if the property exists using reflection
            var properties = GetType().GetProperties(
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance);

            var propertyExists = properties.Any(p =>
            {
                var attr = p.GetCustomAttribute<TerraformPropertyNameAttribute>();
                return attr?.Name == name;
            });

            if (!propertyExists)
            {
                throw new TerraformStackException(
                    $"Local value '{name}' has not been defined. " +
                    $"Use Set(\"{name}\", value) to define it first.",
                    this,
                    name);
            }
            return new TerraformReferenceExpression(this, name);
        }
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier("local");

    /// <summary>
    /// Gets the reference expression for a specific local value.
    /// </summary>
    public TerraformExpression AsReference(string name)
        => TerraformExpression.Identifier($"local.{name}");
}
