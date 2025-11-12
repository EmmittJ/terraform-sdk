namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform backend configuration for remote state storage.
/// Backends determine where Terraform stores its state data.
/// This is a block expression for backend configuration.
/// </summary>
public class TerraformBackend : TerraformBlockExpression
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformBackend"/> class.
    /// </summary>
    /// <param name="type">The backend type (e.g., "s3", "azurerm", "remote", "local", "gcs").</param>
    public TerraformBackend(string type)
    {
        Type = type ?? throw new ArgumentNullException(nameof(type));
    }

    /// <summary>
    /// Gets the backend type (e.g., "s3", "azurerm", "remote", "local", "gcs").
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// Renders the backend as a labeled block: "type" { properties }
    /// The parent block provides the "backend" keyword.
    /// </summary>
    public override string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        if (_properties.Count == 0)
        {
            return $"\"{Type}\" {{}}";
        }

        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"\"{Type}\" {{");

        using (context.PushIndent())
        {
            WriteProperties(sb, context);
        }
        sb.Append($"{context.Indent}}}");

        return sb.ToString();
    }
}

