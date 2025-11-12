namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform moved block for refactoring resources without destroying them.
/// The moved block allows you to rename or move resources, modules, or module calls while preserving
/// the existing infrastructure state.
/// </summary>
/// <remarks>
/// Reference: https://developer.hashicorp.com/terraform/language/modules/develop/refactoring
/// Requires: Terraform 1.1+
/// </remarks>
public class TerraformMovedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the previous address of the resource or module.
    /// </summary>
    public string From { get; }

    /// <summary>
    /// Gets the new address of the resource or module.
    /// </summary>
    public string To { get; }

    /// <summary>
    /// Creates a new moved block with the specified from and to addresses.
    /// </summary>
    /// <param name="from">The previous address (e.g., "aws_instance.example", "module.old_name")</param>
    /// <param name="to">The new address (e.g., "aws_instance.renamed", "module.new_name")</param>
    public TerraformMovedBlock(string from, string to)
    {
        if (string.IsNullOrWhiteSpace(from))
            throw new ArgumentException("From address cannot be null or empty", nameof(from));
        if (string.IsNullOrWhiteSpace(to))
            throw new ArgumentException("To address cannot be null or empty", nameof(to));

        From = from;
        To = to;

        // Initialize properties
        FromProperty = new MovedAddressProperty(from);
        ToProperty = new MovedAddressProperty(to);
    }

    [TerraformProperty("from")]
    public MovedAddressProperty FromProperty { get; set; }

    [TerraformProperty("to")]
    public MovedAddressProperty ToProperty { get; set; }

    /// <summary>
    /// Resolves to a TerraformConstructExpression representing the moved block.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformConstructExpression with block type "moved" and no labels.</returns>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in construct expression with block type "moved" and no labels
        return new TerraformConstructExpression("moved", [], bodyMap);
    }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
    {
        throw new NotSupportedException("Moved blocks cannot be referenced.");
    }
}

/// <summary>
/// Represents an address property for moved blocks.
/// This renders without quotes since addresses are references, not strings.
/// </summary>
public class MovedAddressProperty : ITerraformResolvable
{
    private readonly string _address;

    public MovedAddressProperty(string address)
    {
        _address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public TerraformExpression Resolve(ITerraformContext context)
    {
        // Return a literal expression that renders without quotes
        return new MovedAddressExpression(_address);
    }
}

/// <summary>
/// Expression that renders a moved block address without quotes.
/// </summary>
internal class MovedAddressExpression : TerraformExpression
{
    private readonly string _address;

    public MovedAddressExpression(string address)
    {
        _address = address;
    }

    public override string ToHcl(ITerraformContext? context = null)
    {
        // Render the address as-is without quotes
        return _address;
    }
}
