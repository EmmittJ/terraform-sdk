using System.Reflection;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for all Terraform constructs (resources, data sources, providers, locals).
/// Provides common property management and HCL generation infrastructure.
/// Implements ITerraformSerializable for two-pass HCL generation support.
/// </summary>
public abstract class TerraformConstruct : ITerraformSerializable
{
    /// <summary>
    /// Gets the block type (e.g., "resource", "data", "provider", "output", "variable", "module").
    /// </summary>
    public abstract string BlockType { get; }

    /// <summary>
    /// Gets the primary label(s) for this construct in HCL.
    /// For resources/data sources: [type, name]
    /// For providers/modules/outputs/variables: [name]
    /// </summary>
    protected abstract string[] BlockLabels { get; }

    /// <summary>
    /// Writes all properties to HCL with proper formatting.
    /// Override this in derived classes to write properties using reflection and polymorphic resolution.
    /// </summary>
    /// <param name="sb">The StringBuilder to append to.</param>
    /// <param name="context">The context for indentation and resolution.</param>
    protected virtual void WriteProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Use reflection to get all public instance properties
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

        foreach (var prop in properties)
        {
            // Skip properties that are part of the base class infrastructure
            if (prop.DeclaringType == typeof(TerraformConstruct) ||
                prop.Name == "BlockType" ||
                prop.Name == "BlockLabels")
            {
                continue;
            }

            var value = prop.GetValue(this);
            if (value == null)
            {
                continue; // Skip null properties
            }

            // Get the Terraform property name from the attribute
            var nameAttr = prop.GetCustomAttribute<TerraformPropertyNameAttribute>();
            if (nameAttr == null)
            {
                continue; // Skip properties without the attribute
            }

            string terraformName = nameAttr.Name;

            // Handle TerraformValue<T> system
            if (IsTerraformValue(prop.PropertyType))
            {
                var expression = ResolveTerraformValue(value, context);
                if (expression != null)
                {
                    var hcl = expression.ToHcl(context);
                    sb.AppendLine($"{context.Indent}{terraformName} = {hcl}");
                }
            }
            // Handle other serializable types (blocks, nested objects, etc.)
            else if (value is ITerraformSerializable serializable)
            {
                var hcl = serializable.ToHcl(context);
                sb.AppendLine($"{context.Indent}{terraformName} = {hcl}");
            }
        }
    }

    /// <summary>
    /// Checks if a type is TerraformValue&lt;T&gt;.
    /// </summary>
    private static bool IsTerraformValue(Type type)
    {
        // Handle nullable TerraformValue<T>
        var underlyingType = Nullable.GetUnderlyingType(type) ?? type;

        return underlyingType.IsGenericType &&
               underlyingType.GetGenericTypeDefinition() == typeof(TerraformValue<>);
    }

    /// <summary>
    /// Resolves a TerraformValue&lt;T&gt; to a TerraformExpression using reflection.
    /// Returns null if the value has no content.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("Trimming", "IL2070",
        Justification = "TerraformValue<T> is a known struct with consistent HasValue and Resolve methods")]
    private static TerraformExpression? ResolveTerraformValue(object terraformValue, ITerraformContext context)
    {
        var valueType = terraformValue.GetType();

        // Check if it has a value using the HasValue property
        var hasValueProp = valueType.GetProperty("HasValue");
        var hasValue = (bool)(hasValueProp?.GetValue(terraformValue) ?? false);

        if (!hasValue)
        {
            return null;
        }

        // Resolve the value
        var resolveContext = new TerraformResolveContext(context);
        var resolveMethod = valueType.GetMethod("Resolve", BindingFlags.Public | BindingFlags.Instance);
        var expression = (TerraformExpression)resolveMethod!.Invoke(terraformValue, new object[] { resolveContext })!;

        return expression;
    }


    /// <inheritdoc/>
    public abstract TerraformExpression AsReference();

    /// <summary>
    /// Preparation phase - prepares all nested values and expressions.
    /// Uses reflection to discover properties and calls Prepare() on each ITerraformPreparable.
    /// </summary>
    public virtual void Prepare(ITerraformContext context)
    {
        // Use reflection to get all public instance properties
        var properties = GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

        foreach (var prop in properties)
        {
            // Skip properties that are part of the base class infrastructure
            if (prop.DeclaringType == typeof(TerraformConstruct))
            {
                continue;
            }

            var value = prop.GetValue(this);
            if (value == null)
            {
                continue;
            }

            if (value is ITerraformPreparable preparable)
            {
                // Call Prepare() on the property (polymorphic)
                preparable.Prepare(context);
            }
        }
    }

    /// <summary>
    /// Resolution phase - generates HCL string with optional context.
    /// When context is provided, uses it for dependency tracking.
    /// When context is null, creates a temporary context.
    /// </summary>
    public virtual string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();

        // Build block header: blockType "identifier1" "identifier2" {
        sb.Append($"{context.Indent}{BlockType}");
        foreach (var identifier in BlockLabels)
        {
            sb.Append($" \"{identifier}\"");
        }
        sb.AppendLine(" {");

        using (context.PushIndent())
        {
            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}

