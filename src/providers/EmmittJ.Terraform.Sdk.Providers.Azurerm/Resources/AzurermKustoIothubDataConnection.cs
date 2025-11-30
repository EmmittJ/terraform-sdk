using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKustoIothubDataConnection.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_kusto_iothub_data_connection Terraform resource.
/// Manages a azurerm_kusto_iothub_data_connection resource.
/// </summary>
public partial class AzurermKustoIothubDataConnection(string name) : TerraformResource("azurerm_kusto_iothub_data_connection", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroup is required")]
    public required TerraformValue<string> ConsumerGroup
    {
        get => new TerraformReference<string>(this, "consumer_group");
        set => SetArgument("consumer_group", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformValue<string>? DataFormat
    {
        get => new TerraformReference<string>(this, "data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseRoutingType
    {
        get => new TerraformReference<string>(this, "database_routing_type");
        set => SetArgument("database_routing_type", value);
    }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    public TerraformSet<string>? EventSystemProperties
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "event_system_properties").ResolveNodes(ctx));
        set => SetArgument("event_system_properties", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformValue<string> IothubId
    {
        get => new TerraformReference<string>(this, "iothub_id");
        set => SetArgument("iothub_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformValue<string>? MappingRuleName
    {
        get => new TerraformReference<string>(this, "mapping_rule_name");
        set => SetArgument("mapping_rule_name", value);
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
    /// The shared_access_policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyName is required")]
    public required TerraformValue<string> SharedAccessPolicyName
    {
        get => new TerraformReference<string>(this, "shared_access_policy_name");
        set => SetArgument("shared_access_policy_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string>? TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoIothubDataConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoIothubDataConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
