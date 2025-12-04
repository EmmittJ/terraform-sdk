using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermServicebusQueueAuthorizationRuleDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermServicebusQueueAuthorizationRuleDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_servicebus_queue_authorization_rule Terraform data source.
/// Retrieves information about a azurerm_servicebus_queue_authorization_rule.
/// </summary>
public partial class AzurermServicebusQueueAuthorizationRuleDataSource(string name) : TerraformDataSource("azurerm_servicebus_queue_authorization_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceName
    {
        get => GetArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    public TerraformValue<string>? QueueId
    {
        get => GetArgument<TerraformValue<string>>("queue_id");
        set => SetArgument("queue_id", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformValue<string>? QueueName
    {
        get => GetArgument<TerraformValue<string>>("queue_name");
        set => SetArgument("queue_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The listen attribute.
    /// </summary>
    public TerraformValue<bool> Listen
        => AsReference("listen");

    /// <summary>
    /// The manage attribute.
    /// </summary>
    public TerraformValue<bool> Manage
        => AsReference("manage");

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionStringAlias
        => AsReference("primary_connection_string_alias");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionStringAlias
        => AsReference("secondary_connection_string_alias");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => AsReference("secondary_key");

    /// <summary>
    /// The send attribute.
    /// </summary>
    public TerraformValue<bool> Send
        => AsReference("send");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusQueueAuthorizationRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusQueueAuthorizationRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
