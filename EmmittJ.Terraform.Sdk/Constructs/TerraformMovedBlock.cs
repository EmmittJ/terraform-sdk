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
public class TerraformMovedBlock : TerraformConstruct
{
    /// <summary>
    /// Gets the previous address of the resource or module.
    /// </summary>
    public string From { get; }

    /// <summary>
    /// Gets the new address of the resource or module.
    /// </summary>
    public string To { get; }

    /// <inheritdoc/>
    protected override string BlockType => "moved";

    /// <inheritdoc/>
    protected override string[] Labels => Array.Empty<string>();

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

        // Set the from and to as properties so they render in HCL
        // Use a custom property that renders addresses without quotes
        WithPropertyInternal("from", new MovedAddressProperty(from), priority: 0);
        WithPropertyInternal("to", new MovedAddressProperty(to), priority: 1);
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
internal class MovedAddressProperty : TerraformProperty
{
    private readonly string _address;

    public MovedAddressProperty(string address)
    {
        _address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public override void Prepare(ITerraformContext context)
    {
        // No preparation needed for moved addresses
    }

    public override TerraformExpression Resolve(ITerraformContext? context = null)
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

    public override string Resolve(ITerraformContext? context = null)
    {
        // Render the address as-is without quotes
        return _address;
    }
}
