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
public class AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_servicebus_namespace_disaster_recovery_config.
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfigDataSource : TerraformDataSource
{
    public AzurermServicebusNamespaceDisasterRecoveryConfigDataSource(string name) : base("azurerm_servicebus_namespace_disaster_recovery_config", name)
    {
    }

    /// <summary>
    /// The alias_authorization_rule_id attribute.
    /// </summary>
    [TerraformArgument("alias_authorization_rule_id")]
    public TerraformValue<string>? AliasAuthorizationRuleId
    {
        get => new TerraformReference<string>(this, "alias_authorization_rule_id");
        set => SetArgument("alias_authorization_rule_id", value);
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
    /// The namespace_id attribute.
    /// </summary>
    [TerraformArgument("namespace_id")]
    public TerraformValue<string> NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("namespace_name")]
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("resource_group_name")]
    public TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformArgument("default_primary_key")]
    public TerraformValue<string> DefaultPrimaryKey
    {
        get => new TerraformReference<string>(this, "default_primary_key");
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
    /// The partner_namespace_id attribute.
    /// </summary>
    [TerraformArgument("partner_namespace_id")]
    public TerraformValue<string> PartnerNamespaceId
    {
        get => new TerraformReference<string>(this, "partner_namespace_id");
    }

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformArgument("primary_connection_string_alias")]
    public TerraformValue<string> PrimaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "primary_connection_string_alias");
    }

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformArgument("secondary_connection_string_alias")]
    public TerraformValue<string> SecondaryConnectionStringAlias
    {
        get => new TerraformReference<string>(this, "secondary_connection_string_alias");
    }

}
