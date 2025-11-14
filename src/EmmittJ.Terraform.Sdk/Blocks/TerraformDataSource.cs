using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform data source - a top-level block for reading existing infrastructure.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Data sources allow Terraform to use information defined outside of Terraform, defined by another
/// separate Terraform configuration, or modified by functions.
/// Data sources support a subset of meta-arguments: depends_on and provider.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/data-sources"/></para>
/// </remarks>
public partial class TerraformDataSource :
    TerraformBlock,
    ITerraformHasDependsOn,
    ITerraformHasProvider,
    ITerraformHasCount,
    ITerraformHasForEach
{
    /// <summary>
    /// Gets the data source type (e.g., "aws_ami", "azurerm_client_config").
    /// </summary>
    public string DataSourceType { get; }

    /// <summary>
    /// Gets the data source name (unique within the configuration).
    /// </summary>
    public string DataSourceName { get; }

    /// <summary>
    /// Gets the block type keyword for data sources.
    /// </summary>
    public override string BlockType => "data";

    /// <summary>
    /// Gets the block labels for this data source.
    /// </summary>
    public override string[] BlockLabels => [DataSourceType, DataSourceName];

    /// <summary>
    /// Initializes a new instance of TerraformDataSource.
    /// </summary>
    /// <param name="type">The data source type (e.g., "aws_ami").</param>
    /// <param name="name">The data source name.</param>
    public TerraformDataSource(string type, string name)
    {
        DataSourceType = type ?? throw new ArgumentNullException(nameof(type));
        DataSourceName = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Generates a reference to this data source (e.g., "data.aws_ami.ubuntu").
    /// This reference can be used to access the data source's attributes (output values like id, arn, etc.)
    /// in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this data source.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"data.{DataSourceType}.{DataSourceName}");

    /// <summary>
    /// Resolves this data source to a top-level block node.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        var children = base.ResolveNodes(context).ToList();
        yield return new TerraformBlockNode(BlockType, BlockLabels, children);
    }
}
