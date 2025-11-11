using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for georeplications in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryGeoreplicationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The regional_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("regional_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RegionalEndpointEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_redundancy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneRedundancyEnabled { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerRegistryTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_container_registry resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermContainerRegistry : TerraformResource
{
    public AzurermContainerRegistry(string name) : base("azurerm_container_registry", name)
    {
    }

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformProperty("admin_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdminEnabled { get; set; }

    /// <summary>
    /// The anonymous_pull_enabled attribute.
    /// </summary>
    [TerraformProperty("anonymous_pull_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AnonymousPullEnabled { get; set; }

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("data_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DataEndpointEnabled { get; set; }

    /// <summary>
    /// The encryption attribute.
    /// </summary>
    [TerraformProperty("encryption")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> Encryption { get; set; }

    /// <summary>
    /// The export_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("export_policy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExportPolicyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_rule_bypass_option attribute.
    /// </summary>
    [TerraformProperty("network_rule_bypass_option")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkRuleBypassOption { get; set; }

    /// <summary>
    /// The network_rule_set attribute.
    /// </summary>
    [TerraformProperty("network_rule_set")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> NetworkRuleSet { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The quarantine_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("quarantine_policy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? QuarantinePolicyEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_policy_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_policy_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionPolicyInDays { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The trust_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("trust_policy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TrustPolicyEnabled { get; set; }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_redundancy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneRedundancyEnabled { get; set; }

    /// <summary>
    /// Block for georeplications.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("georeplications")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryGeoreplicationsBlock>>? Georeplications { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermContainerRegistryIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerRegistryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdminPassword { get; }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformProperty("admin_username")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdminUsername { get; }

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    [TerraformProperty("data_endpoint_host_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> DataEndpointHostNames { get; }

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [TerraformProperty("login_server")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoginServer { get; }

}
