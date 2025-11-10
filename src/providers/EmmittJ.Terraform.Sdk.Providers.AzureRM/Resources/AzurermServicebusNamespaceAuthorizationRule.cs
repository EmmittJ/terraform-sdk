using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceAuthorizationRuleTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_servicebus_namespace_authorization_rule resource.
/// </summary>
public class AzurermServicebusNamespaceAuthorizationRule : TerraformResource
{
    public AzurermServicebusNamespaceAuthorizationRule(string name) : base("azurerm_servicebus_namespace_authorization_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The listen attribute.
    /// </summary>
    [TerraformPropertyName("listen")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Listen { get; set; }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    [TerraformPropertyName("manage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Manage { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformPropertyName("namespace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NamespaceId { get; set; }

    /// <summary>
    /// The send attribute.
    /// </summary>
    [TerraformPropertyName("send")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Send { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermServicebusNamespaceAuthorizationRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string");

    /// <summary>
    /// The primary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("primary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_connection_string_alias");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string");

    /// <summary>
    /// The secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("secondary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_connection_string_alias");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_key");

}
