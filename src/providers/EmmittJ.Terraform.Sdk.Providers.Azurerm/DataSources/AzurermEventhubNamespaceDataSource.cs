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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoInflateEnabled
        => AsReference("auto_inflate_enabled");

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double> Capacity
        => AsReference("capacity");

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    public TerraformValue<string> DedicatedClusterId
        => AsReference("dedicated_cluster_id");

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionString
        => AsReference("default_primary_connection_string");

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryConnectionStringAlias
        => AsReference("default_primary_connection_string_alias");

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryKey
        => AsReference("default_primary_key");

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionString
        => AsReference("default_secondary_connection_string");

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryConnectionStringAlias
        => AsReference("default_secondary_connection_string_alias");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryKey
        => AsReference("default_secondary_key");

    /// <summary>
    /// The kafka_enabled attribute.
    /// </summary>
    public TerraformValue<bool> KafkaEnabled
        => AsReference("kafka_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    public TerraformValue<double> MaximumThroughputUnits
        => AsReference("maximum_throughput_units");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubNamespaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubNamespaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
