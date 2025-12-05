using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform data source - a top-level block for reading existing infrastructure.
/// Inherits from TerraformBlock to reuse property storage and expression infrastructure.
/// </summary>
/// <remarks>
/// Data sources allow Terraform to use information defined outside of Terraform, defined by another
/// separate Terraform configuration, or modified by functions.
/// Data sources support a subset of meta-arguments: depends_on, provider, count, and for_each.
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/block/data"/></para>
/// </remarks>
public class TerraformDataSource :
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
    /// Gets the Terraform reference identifier for this data source (e.g., "data.aws_ami.ubuntu").
    /// </summary>
    public override string ReferenceIdentifier => $"data.{DataSourceType}.{DataSourceName}";

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

    // Meta-argument properties

    /// <summary>
    /// Gets or sets the list of resources this depends on.
    /// Use this meta-argument when a data source relies on some other resource's behavior
    /// but doesn't access any of that resource's data in its arguments.
    /// </summary>
    public TerraformList<string>? DependsOn
    {
        get => GetArgument<TerraformList<string>?>("depends_on");
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// Gets or sets the provider meta-argument.
    /// Specifies which provider configuration to use, overriding Terraform's default behavior.
    /// </summary>
    public TerraformValue<string>? Provider
    {
        get => GetArgument<TerraformValue<string>?>("provider");
        set => SetArgument("provider", value);
    }

    /// <summary>
    /// Gets or sets the count meta-argument.
    /// Accepts a whole number, and creates that many instances of the data source.
    /// </summary>
    public TerraformValue<int>? Count
    {
        get => GetArgument<TerraformValue<int>?>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// Gets or sets the for_each meta-argument.
    /// Accepts a map or a set of strings, and creates an instance for each item.
    /// </summary>
    public TerraformValue<object>? ForEach
    {
        get => GetArgument<TerraformValue<object>?>("for_each");
        set => SetArgument("for_each", value);
    }
}
