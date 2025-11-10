using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventhubNamespaceIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_eventhub_namespace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventhubNamespace : TerraformResource
{
    public AzurermEventhubNamespace(string name) : base("azurerm_eventhub_namespace", name)
    {
    }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_inflate_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoInflateEnabled { get; set; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Capacity { get; set; }

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_cluster_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DedicatedClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    [TerraformPropertyName("maximum_throughput_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumThroughputUnits { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_rulesets attribute.
    /// </summary>
    [TerraformPropertyName("network_rulesets")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> NetworkRulesets { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_rulesets");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermEventhubNamespaceIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermEventhubNamespaceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPrimaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_primary_connection_string");

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPrimaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_primary_connection_string_alias");

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_primary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultPrimaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_primary_key");

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecondaryConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_secondary_connection_string");

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_connection_string_alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecondaryConnectionStringAlias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_secondary_connection_string_alias");

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    [TerraformPropertyName("default_secondary_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSecondaryKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_secondary_key");

}
