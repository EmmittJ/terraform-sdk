namespace EmmittJ.Terraform.Sdk.Constructs;

/// <summary>
/// Represents a Terraform import block for declarative resource import (Terraform 1.5+).
/// Import blocks allow you to declare which existing infrastructure objects should be
/// imported into Terraform's state without requiring separate terraform import commands.
/// </summary>
/// <example>
/// <code>
/// // Basic import
/// var import = new TerraformImportBlock(
///     to: "aws_instance.example",
///     id: "i-1234567890abcdef0"
/// );
///
/// // With explicit provider
/// var import = new TerraformImportBlock(
///     to: "aws_instance.example",
///     id: "i-1234567890abcdef0",
///     provider: "aws.west"
/// );
///
/// // With count index
/// var import = new TerraformImportBlock(
///     to: "aws_instance.example[0]",
///     id: "i-1234567890abcdef0"
/// );
///
/// // With for_each key
/// var import = new TerraformImportBlock(
///     to: "aws_instance.web[\"primary\"]",
///     id: "i-1234567890abcdef0"
/// );
/// </code>
/// </example>
public class TerraformImportBlock : TerraformBlock
{
    /// <summary>
    /// The resource address where the imported object should be placed in the state.
    /// Supports count/for_each indexing (e.g., "aws_instance.example[0]").
    /// </summary>
    public string To { get; }

    /// <summary>
    /// The provider-specific identifier for the object to import.
    /// The format depends on the resource type (e.g., AWS instance ID, Azure resource ID).
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Optional explicit provider configuration to use for the import.
    /// Useful when you have multiple provider configurations (e.g., "aws.west").
    /// </summary>
    public string? Provider { get; }

    /// <summary>
    /// Creates a new Terraform import block.
    /// </summary>
    /// <param name="to">The resource address where the imported object should be placed.</param>
    /// <param name="id">The provider-specific identifier for the object to import.</param>
    /// <param name="provider">Optional explicit provider configuration to use.</param>
    /// <exception cref="ArgumentException">Thrown when to or id is null or empty.</exception>
    public TerraformImportBlock(string to, string id, string? provider = null)
    {
        if (string.IsNullOrWhiteSpace(to))
            throw new ArgumentException("Import 'to' address cannot be null or empty.", nameof(to));

        if (string.IsNullOrWhiteSpace(id))
            throw new ArgumentException("Import 'id' cannot be null or empty.", nameof(id));

        To = to;
        Id = id;
        Provider = provider;

        // Initialize properties using implicit conversions
        ToProperty = new ImportAddressProperty(to);
        IdProperty = id;

        if (!string.IsNullOrWhiteSpace(provider))
        {
            ProviderProperty = new ImportAddressProperty(provider);
        }
    }

    [TerraformProperty("to")]
    public ImportAddressProperty ToProperty { get; set; }

    [TerraformProperty("id")]
    public TerraformValue<string> IdProperty { get; set; }

    [TerraformProperty("provider")]
    public ImportAddressProperty? ProviderProperty { get; set; }

    /// <summary>
    /// Resolves to a TerraformConstructExpression representing the import block.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformConstructExpression with block type "import" and no labels.</returns>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in construct expression with block type "import" and no labels
        return new TerraformConstructExpression("import", [], bodyMap);
    }

    /// <inheritdoc/>
    public override TerraformReferenceExpression AsReference()
    {
        throw new NotSupportedException("Import blocks cannot be referenced in expressions.");
    }
}

/// <summary>
/// Internal property type for import block addresses that renders without quotes.
/// </summary>
public class ImportAddressProperty : ITerraformResolvable
{
    private readonly string _address;

    public ImportAddressProperty(string address)
    {
        _address = address;
    }

    public TerraformExpression Resolve(ITerraformContext context)
    {
        return new ImportAddressExpression(_address);
    }
}

/// <summary>
/// Internal expression type that renders addresses without quotes.
/// </summary>
internal class ImportAddressExpression : TerraformExpression
{
    private readonly string _address;

    public ImportAddressExpression(string address)
    {
        _address = address;
    }

    public override string ToHcl(ITerraformContext? context = null)
    {
        // Return the address as-is, without quotes
        return _address;
    }
}
