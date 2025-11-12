using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_servicebus_namespace_disaster_recovery_config resource.
/// </summary>
public partial class AzurermServicebusNamespaceDisasterRecoveryConfig : TerraformResource
{
    public AzurermServicebusNamespaceDisasterRecoveryConfig(string name) : base("azurerm_servicebus_namespace_disaster_recovery_config", name)
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
    /// The partner_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerNamespaceId is required")]
    [TerraformProperty("partner_namespace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PartnerNamespaceId { get; set; }

    /// <summary>
    /// The primary_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryNamespaceId is required")]
    [TerraformProperty("primary_namespace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrimaryNamespaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock Timeouts { get; set; } = new();

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
