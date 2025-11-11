using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSearchServiceIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSearchServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_search_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSearchService : TerraformResource
{
    public AzurermSearchService(string name) : base("azurerm_search_service", name)
    {
    }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformProperty("allowed_ips")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowedIps { get; set; }

    /// <summary>
    /// The authentication_failure_mode attribute.
    /// </summary>
    [TerraformProperty("authentication_failure_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthenticationFailureMode { get; set; }

    /// <summary>
    /// The customer_managed_key_enforcement_enabled attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_enforcement_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CustomerManagedKeyEnforcementEnabled { get; set; }

    /// <summary>
    /// The hosting_mode attribute.
    /// </summary>
    [TerraformProperty("hosting_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostingMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_rule_bypass_option attribute.
    /// </summary>
    [TerraformProperty("network_rule_bypass_option")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkRuleBypassOption { get; set; }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    [TerraformProperty("partition_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PartitionCount { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The replica_count attribute.
    /// </summary>
    [TerraformProperty("replica_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ReplicaCount { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The semantic_search_sku attribute.
    /// </summary>
    [TerraformProperty("semantic_search_sku")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SemanticSearchSku { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermSearchServiceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSearchServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The customer_managed_key_encryption_compliance_status attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_encryption_compliance_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerManagedKeyEncryptionComplianceStatus { get; }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    [TerraformProperty("primary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryKey { get; }

    /// <summary>
    /// The query_keys attribute.
    /// </summary>
    [TerraformProperty("query_keys")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> QueryKeys { get; }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    [TerraformProperty("secondary_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryKey { get; }

}
