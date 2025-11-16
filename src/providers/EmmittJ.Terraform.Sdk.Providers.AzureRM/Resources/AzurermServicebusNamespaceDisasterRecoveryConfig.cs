using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_servicebus_namespace_disaster_recovery_config Terraform resource.
/// Manages a azurerm_servicebus_namespace_disaster_recovery_config resource.
/// </summary>
public partial class AzurermServicebusNamespaceDisasterRecoveryConfig(string name) : TerraformResource("azurerm_servicebus_namespace_disaster_recovery_config", name)
{
    /// <summary>
    /// The alias_authorization_rule_id attribute.
    /// </summary>
    public TerraformValue<string>? AliasAuthorizationRuleId
    {
        get => new TerraformReference<string>(this, "alias_authorization_rule_id");
        set => SetArgument("alias_authorization_rule_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerNamespaceId is required")]
    public required TerraformValue<string> PartnerNamespaceId
    {
        get => new TerraformReference<string>(this, "partner_namespace_id");
        set => SetArgument("partner_namespace_id", value);
    }

    /// <summary>
    /// The primary_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryNamespaceId is required")]
    public required TerraformValue<string> PrimaryNamespaceId
    {
        get => new TerraformReference<string>(this, "primary_namespace_id");
        set => SetArgument("primary_namespace_id", value);
    }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultPrimaryKey
    {
        get => new TerraformReference<string>(this, "default_primary_key");
    }

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecondaryKey
    {
        get => new TerraformReference<string>(this, "default_secondary_key");
    }

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "primary_connection_string_alias");
    }

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "secondary_connection_string_alias");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
