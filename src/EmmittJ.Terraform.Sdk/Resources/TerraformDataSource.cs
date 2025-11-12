namespace EmmittJ.Terraform.Sdk;

using EmmittJ.Terraform.Sdk.Constructs.MetaArguments;

/// <summary>
/// Represents a Terraform data source - a top-level construct for reading existing infrastructure.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Data sources allow Terraform to use information defined outside of Terraform, defined by another
/// separate Terraform configuration, or modified by functions.
/// Data sources support a subset of meta-arguments: depends_on and provider.
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
    /// Initializes a new instance of TerraformDataSource.
    /// </summary>
    /// <param name="type">The data source type (e.g., "aws_ami").</param>
    /// <param name="name">The data source name.</param>
    public TerraformDataSource(string type, string name) : base("")
    {
        DataSourceType = type ?? throw new ArgumentNullException(nameof(type));
        DataSourceName = name ?? throw new ArgumentNullException(nameof(name));
    }

    /// <summary>
    /// Resolves to a TerraformConstructExpression representing the data source block.
    /// Overrides the base Resolve() to return a construct expression instead of a map expression.
    /// </summary>
    /// <param name="ctx">The resolution context.</param>
    /// <returns>A TerraformConstructExpression with block type "data" and labels [type, name].</returns>
    public override TerraformExpression Resolve(ITerraformContext ctx)
    {
        // Get map expression from properties (via base.Resolve())
        var bodyMap = base.Resolve(ctx);

        // Wrap in construct expression with data source type and name
        return new TerraformConstructExpression("data",
            [DataSourceType, DataSourceName], bodyMap);
    }

    /// <summary>
    /// Generates a reference to this data source (e.g., "data.aws_ami.ubuntu").
    /// Used when referencing this data source's attributes in other parts of the configuration.
    /// </summary>
    /// <returns>An identifier expression for this data source.</returns>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"data.{DataSourceType}.{DataSourceName}");
}
