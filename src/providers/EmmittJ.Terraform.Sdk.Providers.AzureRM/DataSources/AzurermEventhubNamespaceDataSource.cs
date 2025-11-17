using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventhubNamespaceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_eventhub_namespace Terraform data source.
/// Retrieves information about a azurerm_eventhub_namespace.
/// </summary>
public partial class AzurermEventhubNamespaceDataSource(string name) : TerraformDataSource("azurerm_eventhub_namespace", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoInflateEnabled
    {
        get => new TerraformReference<bool>(this, "auto_inflate_enabled");
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
    }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    public TerraformValue<string> DedicatedClusterId
    {
        get => new TerraformReference<string>(this, "dedicated_cluster_id");
    }

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "default_primary_connection_string");
    }

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "default_primary_connection_string_alias");
    }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryKey
    {
        get => new TerraformReference<string>(this, "default_primary_key");
    }

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "default_secondary_connection_string");
    }

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "default_secondary_connection_string_alias");
    }

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryKey
    {
        get => new TerraformReference<string>(this, "default_secondary_key");
    }

    /// <summary>
    /// The kafka_enabled attribute.
    /// </summary>
    public TerraformValue<bool> KafkaEnabled
    {
        get => new TerraformReference<bool>(this, "kafka_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    public TerraformValue<double> MaximumThroughputUnits
    {
        get => new TerraformReference<double>(this, "maximum_throughput_units");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubNamespaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubNamespaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
