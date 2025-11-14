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
public class AzurermServicebusNamespaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_servicebus_namespace.
/// </summary>
public class AzurermServicebusNamespaceDataSource : TerraformDataSource
{
    public AzurermServicebusNamespaceDataSource(string name) : base("azurerm_servicebus_namespace", name)
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
    public AzurermServicebusNamespaceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformArgument("capacity")]
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
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
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformArgument("default_secondary_key")]
    public TerraformValue<string> DefaultSecondaryKey
    {
        get => new TerraformReference<string>(this, "default_secondary_key");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
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
    /// The premium_messaging_partitions attribute.
    /// </summary>
    [TerraformArgument("premium_messaging_partitions")]
    public TerraformValue<double> PremiumMessagingPartitions
    {
        get => new TerraformReference<double>(this, "premium_messaging_partitions");
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
