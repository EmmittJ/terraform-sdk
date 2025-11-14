using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleDbNodesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_db_nodes.
/// </summary>
public class AzurermOracleDbNodesDataSource : TerraformDataSource
{
    public AzurermOracleDbNodesDataSource(string name) : base("azurerm_oracle_db_nodes", name)
    {
    }

    /// <summary>
    /// The cloud_vm_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    [TerraformArgument("cloud_vm_cluster_id")]
    public required TerraformValue<string> CloudVmClusterId
    {
        get => new TerraformReference<string>(this, "cloud_vm_cluster_id");
        set => SetArgument("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleDbNodesDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The db_nodes attribute.
    /// </summary>
    [TerraformArgument("db_nodes")]
    public TerraformList<object> DbNodes
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "db_nodes").ResolveNodes(ctx));
    }

}
