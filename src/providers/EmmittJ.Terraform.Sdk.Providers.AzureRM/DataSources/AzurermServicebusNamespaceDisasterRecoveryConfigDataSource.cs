using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_servicebus_namespace_disaster_recovery_config.
/// </summary>
public partial class AzurermServicebusNamespaceDisasterRecoveryConfigDataSource : TerraformDataSource
{
    public AzurermServicebusNamespaceDisasterRecoveryConfigDataSource(string name) : base("azurerm_servicebus_namespace_disaster_recovery_config", name)
    {
    }

    /// <summary>
    /// The alias_authorization_rule_id attribute.
    /// </summary>
    [TerraformProperty("alias_authorization_rule_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AliasAuthorizationRuleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [TerraformProperty("namespace_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamespaceId { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("namespace_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamespaceName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("resource_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermServicebusNamespaceDisasterRecoveryConfigDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformProperty("default_primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultPrimaryKey { get; }

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformProperty("default_secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultSecondaryKey { get; }

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    [TerraformProperty("partner_namespace_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PartnerNamespaceId { get; }

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("primary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryConnectionStringAlias { get; }

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformProperty("secondary_connection_string_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryConnectionStringAlias { get; }

}
