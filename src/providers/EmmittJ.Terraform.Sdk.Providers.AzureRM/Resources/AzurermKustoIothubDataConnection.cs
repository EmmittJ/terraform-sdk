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
public class AzurermKustoIothubDataConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
/// Manages a azurerm_kusto_iothub_data_connection resource.
/// </summary>
public class AzurermKustoIothubDataConnection : TerraformResource
{
    public AzurermKustoIothubDataConnection(string name) : base("azurerm_kusto_iothub_data_connection", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformArgument("cluster_name")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroup is required")]
    [TerraformArgument("consumer_group")]
    public required TerraformValue<string> ConsumerGroup
    {
        get => new TerraformReference<string>(this, "consumer_group");
        set => SetArgument("consumer_group", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [TerraformArgument("data_format")]
    public TerraformValue<string>? DataFormat
    {
        get => new TerraformReference<string>(this, "data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformArgument("database_name")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    [TerraformArgument("database_routing_type")]
    public TerraformValue<string>? DatabaseRoutingType
    {
        get => new TerraformReference<string>(this, "database_routing_type");
        set => SetArgument("database_routing_type", value);
    }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    [TerraformArgument("event_system_properties")]
    public TerraformSet<string>? EventSystemProperties
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "event_system_properties").ResolveNodes(ctx));
        set => SetArgument("event_system_properties", value);
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
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformArgument("iothub_id")]
    public required TerraformValue<string> IothubId
    {
        get => new TerraformReference<string>(this, "iothub_id");
        set => SetArgument("iothub_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    [TerraformArgument("mapping_rule_name")]
    public TerraformValue<string>? MappingRuleName
    {
        get => new TerraformReference<string>(this, "mapping_rule_name");
        set => SetArgument("mapping_rule_name", value);
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
    /// The shared_access_policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyName is required")]
    [TerraformArgument("shared_access_policy_name")]
    public required TerraformValue<string> SharedAccessPolicyName
    {
        get => new TerraformReference<string>(this, "shared_access_policy_name");
        set => SetArgument("shared_access_policy_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [TerraformArgument("table_name")]
    public TerraformValue<string>? TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKustoIothubDataConnectionTimeoutsBlock Timeouts { get; set; } = new();

}
