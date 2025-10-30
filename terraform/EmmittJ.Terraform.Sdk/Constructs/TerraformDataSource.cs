namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform data source block.
/// </summary>
public class TerraformDataSource(string type, string name) : TerraformProvisionableConstruct(type, name)
{

    /// <inheritdoc/>
    protected override string GetConstructTypeLabel() => "data source";

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"data.{Type}.{Name}");

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}data \"{Type}\" \"{Name}\" {{");

        using (context.PushIndent())
        {
            // Meta-arguments first
            WriteMetaArguments(sb, context);

            // Regular properties
            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}
