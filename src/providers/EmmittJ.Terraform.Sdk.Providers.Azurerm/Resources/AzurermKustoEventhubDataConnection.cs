using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKustoEventhubDataConnection.
/// Nesting mode: single
/// </summary>
public class AzurermKustoEventhubDataConnectionTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_kusto_eventhub_data_connection Terraform resource.
/// Manages a azurerm_kusto_eventhub_data_connection resource.
/// </summary>
public partial class AzurermKustoEventhubDataConnection(string name) : TerraformResource("azurerm_kusto_eventhub_data_connection", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformValue<string>? Compression
    {
        get => GetArgument<TerraformValue<string>>("compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroup is required")]
    public required TerraformValue<string> ConsumerGroup
    {
        get => GetArgument<TerraformValue<string>>("consumer_group");
        set => SetArgument("consumer_group", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformValue<string>? DataFormat
    {
        get => GetArgument<TerraformValue<string>>("data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseRoutingType
    {
        get => GetArgument<TerraformValue<string>>("database_routing_type");
        set => SetArgument("database_routing_type", value);
    }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    public TerraformList<string>? EventSystemProperties
    {
        get => GetArgument<TerraformList<string>>("event_system_properties");
        set => SetArgument("event_system_properties", value);
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    public required TerraformValue<string> EventhubId
    {
        get => GetArgument<TerraformValue<string>>("eventhub_id");
        set => SetArgument("eventhub_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityId
    {
        get => GetArgument<TerraformValue<string>>("identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformValue<string>? MappingRuleName
    {
        get => GetArgument<TerraformValue<string>>("mapping_rule_name");
        set => SetArgument("mapping_rule_name", value);
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
    /// The table_name attribute.
    /// </summary>
    public TerraformValue<string>? TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoEventhubDataConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoEventhubDataConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
