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
public class AzurermEventhubNamespaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_eventhub_namespace.
/// </summary>
public class AzurermEventhubNamespaceDataSource : TerraformDataSource
{
    public AzurermEventhubNamespaceDataSource(string name) : base("azurerm_eventhub_namespace", name)
    {
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEventhubNamespaceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_inflate_enabled")]
    public TerraformValue<bool> AutoInflateEnabled
    {
        get => new TerraformReference<bool>(this, "auto_inflate_enabled");
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformArgument("capacity")]
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
    }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    [TerraformArgument("dedicated_cluster_id")]
    public TerraformValue<string> DedicatedClusterId
    {
        get => new TerraformReference<string>(this, "dedicated_cluster_id");
    }

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformArgument("default_primary_connection_string")]
    public TerraformValue<string> DefaultPrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "default_primary_connection_string");
    }

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    [TerraformArgument("default_primary_connection_string_alias")]
    public TerraformValue<string> DefaultPrimaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "default_primary_connection_string_alias");
    }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformArgument("default_primary_key")]
    public TerraformValue<string> DefaultPrimaryKey
    {
        get => new TerraformReference<string>(this, "default_primary_key");
    }

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    [TerraformArgument("default_secondary_connection_string")]
    public TerraformValue<string> DefaultSecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "default_secondary_connection_string");
    }

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformArgument("default_secondary_connection_string_alias")]
    public TerraformValue<string> DefaultSecondaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "default_secondary_connection_string_alias");
    }

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformArgument("default_secondary_key")]
    public TerraformValue<string> DefaultSecondaryKey
    {
        get => new TerraformReference<string>(this, "default_secondary_key");
    }

    /// <summary>
    /// The kafka_enabled attribute.
    /// </summary>
    [TerraformArgument("kafka_enabled")]
    public TerraformValue<bool> KafkaEnabled
    {
        get => new TerraformReference<bool>(this, "kafka_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    [TerraformArgument("maximum_throughput_units")]
    public TerraformValue<double> MaximumThroughputUnits
    {
        get => new TerraformReference<double>(this, "maximum_throughput_units");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
