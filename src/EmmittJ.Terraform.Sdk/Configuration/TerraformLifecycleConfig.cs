namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents lifecycle meta-argument configuration for resources.
/// Controls resource creation, destruction, and change detection behavior.
/// This is a data class that can be converted to a block expression.
/// </summary>
public class TerraformLifecycleConfig
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
    /// Gets or sets a value that triggers resource replacement.
    /// When the referenced value changes, the resource will be replaced.
    /// </summary>
    public ITerraformValue? ReplaceTriggeredBy { get; set; }

    /// <summary>
    /// Gets the list of preconditions to validate before applying changes.
    /// Preconditions are checked before Terraform applies the resource configuration.
    /// </summary>
    public List<TerraformCondition> Preconditions { get; init; } = new();

    /// <summary>
    /// Gets the list of postconditions to validate after applying changes.
    /// Postconditions are checked after Terraform applies the resource configuration.
    /// </summary>
    public List<TerraformCondition> Postconditions { get; init; } = new();

    /// <summary>
    /// Returns true if any lifecycle configuration is set.
    /// </summary>
    internal bool HasConfiguration()
    {
        return CreateBeforeDestroy.HasValue ||
               PreventDestroy.HasValue ||
               IgnoreChanges.Count > 0 ||
               ReplaceTriggeredBy != null ||
               Preconditions.Count > 0 ||
               Postconditions.Count > 0;
    }

    /// <summary>
    /// Converts this lifecycle configuration to a block expression.
    /// </summary>
    public TerraformNestedBlockExpression ToBlockExpression()
    {
        return new LifecycleBlockExpression(this);
    }
}

/// <summary>
/// Internal block expression for lifecycle configuration.
/// </summary>
internal class LifecycleBlockExpression : TerraformNestedBlockExpression
{
    private readonly TerraformLifecycleConfig _config;

    public LifecycleBlockExpression(TerraformLifecycleConfig config)
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
                sb.AppendLine($"{context.Indent}replace_triggered_by = [{_config.ReplaceTriggeredBy.Resolve(context).ToHcl(context)}]");
            }

            // Write preconditions
            foreach (var precondition in _config.Preconditions)
            {
                sb.AppendLine();
                sb.AppendLine($"{context.Indent}precondition {{");
                using (context.PushIndent())
                {
                    sb.AppendLine($"{context.Indent}condition     = {precondition.Condition}");
                    sb.AppendLine($"{context.Indent}error_message = \"{precondition.ErrorMessage}\"");
                }
                sb.AppendLine($"{context.Indent}}}");
            }

            // Write postconditions
            foreach (var postcondition in _config.Postconditions)
            {
                sb.AppendLine();
                sb.AppendLine($"{context.Indent}postcondition {{");
                using (context.PushIndent())
                {
                    sb.AppendLine($"{context.Indent}condition     = {postcondition.Condition}");
                    sb.AppendLine($"{context.Indent}error_message = \"{postcondition.ErrorMessage}\"");
                }
                sb.AppendLine($"{context.Indent}}}");
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

/// <summary>
/// Represents a condition (precondition or postcondition) for lifecycle validation.
/// Conditions allow you to validate assumptions about resources during Terraform operations.
/// </summary>
public class TerraformCondition
{
    /// <summary>
    /// Gets the condition expression that must evaluate to true.
    /// </summary>
    public string Condition { get; }

    /// <summary>
    /// Gets the error message to display when the condition is false.
    /// </summary>
    public string ErrorMessage { get; }

    /// <summary>
    /// Creates a new condition.
    /// </summary>
    /// <param name="condition">The condition expression that must be true.</param>
    /// <param name="errorMessage">The error message to display on failure.</param>
    /// <exception cref="ArgumentException">Thrown when condition or errorMessage is null or empty.</exception>
    public TerraformCondition(string condition, string errorMessage)
    {
        if (string.IsNullOrWhiteSpace(condition))
            throw new ArgumentException("Condition cannot be null or empty.", nameof(condition));

        if (string.IsNullOrWhiteSpace(errorMessage))
            throw new ArgumentException("Error message cannot be null or empty.", nameof(errorMessage));

        Condition = condition;
        ErrorMessage = errorMessage;
    }
}
