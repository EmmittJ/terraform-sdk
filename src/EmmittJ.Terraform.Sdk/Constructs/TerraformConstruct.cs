using System.Reflection;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for all Terraform constructs (resources, data sources, providers, locals).
/// Provides common property management and HCL generation infrastructure.
/// Implements ITerraformResolvable for two-pass resolution support.
/// </summary>
public abstract class TerraformConstruct : ITerraformResolvable<string>
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

            // Handle different property types
            if (value is ITerraformBlock block)
            {
                // Blocks don't use = operator, they're nested directly
                SerializeBlock(sb, context, terraformName, block);
            }
            else if (value is ITerraformCollection collection)
            {
                // Collections serialize their elements
                SerializeCollection(sb, context, terraformName, collection);
            }
            else if (value is ITerraformResolvable<TerraformExpression> resolvable)
            {
                // Regular properties (literal, reference, expression)
                SerializeProperty(sb, context, terraformName, resolvable);
            }
        }
    }

    /// <summary>
    /// Serializes a regular property (literal, reference, or expression).
    /// </summary>
    private void SerializeProperty(System.Text.StringBuilder sb, ITerraformContext context, string name, ITerraformResolvable<TerraformExpression> property)
    {
        var expression = property.Resolve(context);
        var hcl = expression.Resolve(context);
        sb.AppendLine($"{context.Indent}{name} = {hcl}");
    }

    /// <summary>
    /// Serializes a block property.
    /// </summary>
    private void SerializeBlock(System.Text.StringBuilder sb, ITerraformContext context, string name, ITerraformBlock block)
    {
        // Blocks are nested structures without = operator
        if (block is ITerraformResolvable<TerraformExpression> resolvable)
        {
            var expression = resolvable.Resolve(context);
            var hcl = expression.Resolve(context);

            // Block syntax: name { ... }
            sb.AppendLine($"{context.Indent}{name} {{");
            using (context.PushIndent())
            {
                sb.Append(hcl);
            }
            sb.AppendLine($"{context.Indent}}}");
        }
    }

    /// <summary>
    /// Serializes a collection property (list, map, set).
    /// </summary>
    private void SerializeCollection(System.Text.StringBuilder sb, ITerraformContext context, string name, ITerraformCollection collection)
    {
        // Collections resolve to their HCL representation
        if (collection is ITerraformResolvable<TerraformExpression> resolvable)
        {
            var expression = resolvable.Resolve(context);
            var hcl = expression.Resolve(context);
            sb.AppendLine($"{context.Indent}{name} = {hcl}");
        }
    }

    /// <inheritdoc/>
    public abstract TerraformExpression AsReference();

    /// <summary>
    /// Preparation phase - prepares all nested values and expressions.
    /// Uses reflection to discover properties and calls Prepare() on each ITerraformResolvable.
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
    public virtual string Resolve(ITerraformContext? context = null)
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


