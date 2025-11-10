using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_servicebus_namespace_disaster_recovery_config resource.
/// </summary>
public class AzurermServicebusNamespaceDisasterRecoveryConfig : TerraformResource
{
    public AzurermServicebusNamespaceDisasterRecoveryConfig(string name) : base("azurerm_servicebus_namespace_disaster_recovery_config", name)
    {
    }

    /// <summary>
    /// The alias_authorization_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("alias_authorization_rule_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AliasAuthorizationRuleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerNamespaceId is required")]
    [TerraformPropertyName("partner_namespace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PartnerNamespaceId { get; set; }

    /// <summary>
    /// The primary_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryNamespaceId is required")]
    [TerraformPropertyName("primary_namespace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrimaryNamespaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusNamespaceDisasterRecoveryConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPrimaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_primary_key");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecondaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_secondary_key");

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string_alias");

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string_alias");

}
