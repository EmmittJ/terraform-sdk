using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermServicebusNamespaceDisasterRecoveryConfigDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_servicebus_namespace_disaster_recovery_config Terraform data source.
/// Retrieves information about a azurerm_servicebus_namespace_disaster_recovery_config.
/// </summary>
public partial class AzurermServicebusNamespaceDisasterRecoveryConfigDataSource(string name) : TerraformDataSource("azurerm_servicebus_namespace_disaster_recovery_config", name)
{
    /// <summary>
    /// The alias_authorization_rule_id attribute.
    /// </summary>
    public TerraformValue<string>? AliasAuthorizationRuleId
    {
        get => GetArgument<TerraformValue<string>>("alias_authorization_rule_id");
        set => SetArgument("alias_authorization_rule_id", value);
    }

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
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
    {
        get => GetArgument<TerraformValue<string>>("namespace_id") ?? AsReference("namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NamespaceName
    {
        get => GetArgument<TerraformValue<string>>("namespace_name") ?? AsReference("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name") ?? AsReference("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryKey
        => AsReference("default_primary_key");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryKey
        => AsReference("default_secondary_key");

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    public TerraformValue<string> PartnerNamespaceId
        => AsReference("partner_namespace_id");

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionStringAlias
        => AsReference("primary_connection_string_alias");

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionStringAlias
        => AsReference("secondary_connection_string_alias");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
