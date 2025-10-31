namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents lifecycle meta-argument configuration for resources.
/// Controls resource creation, destruction, and change detection behavior.
/// This is a data class that can be converted to a block expression.
/// </summary>
public class LifecycleConfig
{
    /// <summary>
    /// Gets or sets whether to create the replacement resource before destroying the original.
    /// Useful for zero-downtime replacements.
    /// </summary>
    public bool? CreateBeforeDestroy { get; set; }

    /// <summary>
    /// Gets or sets whether to prevent Terraform from destroying this resource.
    /// Useful for protecting critical resources.
    /// </summary>
    public bool? PreventDestroy { get; set; }

    /// <summary>
    /// Gets the list of attribute names to ignore changes for.
    /// Terraform will not detect changes to these attributes.
    /// Use "all" to ignore all changes.
    /// </summary>
    public List<string> IgnoreChanges { get; } = new();

    /// <summary>
    /// Gets or sets an expression that triggers resource replacement.
    /// When the referenced value changes, the resource will be replaced.
    /// </summary>
    public TerraformExpression? ReplaceTriggeredBy { get; set; }

    /// <summary>
    /// Returns true if any lifecycle configuration is set.
    /// </summary>
    internal bool HasConfiguration()
    {
        return CreateBeforeDestroy.HasValue ||
               PreventDestroy.HasValue ||
               IgnoreChanges.Count > 0 ||
               ReplaceTriggeredBy != null;
    }

    /// <summary>
    /// Converts this lifecycle configuration to a block expression.
    /// </summary>
    public TerraformBlockExpression ToBlockExpression()
    {
        return new LifecycleBlockExpression(this);
    }
}

/// <summary>
/// Internal block expression for lifecycle configuration.
/// </summary>
internal class LifecycleBlockExpression : TerraformBlockExpression
{
    private readonly LifecycleConfig _config;

    public LifecycleBlockExpression(LifecycleConfig config)
    {
        _config = config;
    }

    public override string ToHcl(ITerraformContext? context)
    {
        context ??= TerraformContext.Temporary(this);

        if (!_config.HasConfiguration())
        {
            return string.Empty;
        }

        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"{context.Indent}lifecycle {{");

        using (context.PushIndent())
        {
            if (_config.CreateBeforeDestroy.HasValue)
            {
                sb.AppendLine($"{context.Indent}create_before_destroy = {_config.CreateBeforeDestroy.Value.ToString().ToLowerInvariant()}");
            }

            if (_config.PreventDestroy.HasValue)
            {
                sb.AppendLine($"{context.Indent}prevent_destroy = {_config.PreventDestroy.Value.ToString().ToLowerInvariant()}");
            }

            if (_config.IgnoreChanges.Count > 0)
            {
                var changes = _config.IgnoreChanges.Count == 1 && _config.IgnoreChanges[0] == "all"
                    ? "all"
                    : $"[{string.Join(", ", _config.IgnoreChanges)}]";
                sb.AppendLine($"{context.Indent}ignore_changes = {changes}");
            }

            if (_config.ReplaceTriggeredBy != null)
            {
                sb.AppendLine($"{context.Indent}replace_triggered_by = [{_config.ReplaceTriggeredBy.ToHcl(context)}]");
            }

            // Write any additional properties from the block expression
            foreach (var (key, value) in _properties.OrderBy(p => p.Key))
            {
                sb.AppendLine($"{context.Indent}{key} = {value.ToHcl(context)}");
            }
        }

        sb.AppendLine($"{context.Indent}}}");
        return sb.ToString();
    }
}
