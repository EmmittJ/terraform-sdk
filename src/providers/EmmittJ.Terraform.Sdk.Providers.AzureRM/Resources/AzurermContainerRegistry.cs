using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for georeplications in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryGeoreplicationsBlock : ITerraformBlock
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The regional_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("regional_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RegionalEndpointEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundancy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ZoneRedundancyEnabled { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryIdentityBlock : ITerraformBlock
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
public class AzurermContainerRegistryTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_container_registry resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerRegistry : TerraformResource
{
    public AzurermContainerRegistry(string name) : base("azurerm_container_registry", name)
    {
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformPropertyName("admin_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AdminEnabled { get; set; }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    [TerraformPropertyName("anonymous_pull_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AnonymousPullEnabled { get; set; }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DataEndpointEnabled { get; set; }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformPropertyName("encryption")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> Encryption { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption");

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("export_policy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ExportPolicyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_rule_bypass_option attribute.
    /// </summary>
    [TerraformPropertyName("network_rule_bypass_option")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkRuleBypassOption { get; set; }

    /// <summary>
    /// The network_rule_set attribute.
    /// </summary>
    [TerraformPropertyName("network_rule_set")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> NetworkRuleSet { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_rule_set");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("quarantine_policy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? QuarantinePolicyEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_policy_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_policy_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionPolicyInDays { get; set; }

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
    /// The trust_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("trust_policy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TrustPolicyEnabled { get; set; }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundancy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ZoneRedundancyEnabled { get; set; }

    /// <summary>
    /// Block for georeplications.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("georeplications")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryGeoreplicationsBlock>>? Georeplications { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerRegistryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdminPassword => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_password");

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdminUsername => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_username");

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    [TerraformPropertyName("data_endpoint_host_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DataEndpointHostNames => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "data_endpoint_host_names");

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [TerraformPropertyName("login_server")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoginServer => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "login_server");

}
