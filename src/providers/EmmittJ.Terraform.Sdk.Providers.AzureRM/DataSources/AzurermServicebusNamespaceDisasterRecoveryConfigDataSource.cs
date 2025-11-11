using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("alias_authorization_rule_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AliasAuthorizationRuleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("namespace_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamespaceId { get; set; } = default!;

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("namespace_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamespaceName { get; set; } = default!;

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("resource_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ResourceGroupName { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultPrimaryKey => new TerraformReference(this, "default_primary_key");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultSecondaryKey => new TerraformReference(this, "default_secondary_key");

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    [TerraformPropertyName("partner_namespace_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PartnerNamespaceId => new TerraformReference(this, "partner_namespace_id");

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryConnectionStringAlias => new TerraformReference(this, "primary_connection_string_alias");

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryConnectionStringAlias => new TerraformReference(this, "secondary_connection_string_alias");

}
