using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveAccountCustomerManagedKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformProperty("identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdentityClientId { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformProperty("key_vault_key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultKeyId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveAccountIdentityBlock : TerraformBlockBase
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
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveAccountNetworkAclsBlock : TerraformBlockBase
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [TerraformProperty("bypass")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Bypass { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformProperty("default_action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DefaultAction { get; set; }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformProperty("ip_rules")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IpRules { get; set; }

}

/// <summary>
/// Block type for network_injection in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveAccountNetworkInjectionBlock : TerraformBlockBase
{
    /// <summary>
    /// The scenario attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scenario is required")]
    [TerraformProperty("scenario")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Scenario { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCognitiveAccountStorageBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformProperty("identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdentityClientId { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCognitiveAccountTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_cognitive_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCognitiveAccount : TerraformResource
{
    public AzurermCognitiveAccount(string name) : base("azurerm_cognitive_account", name)
    {
    }

    /// <summary>
    /// The custom_question_answering_search_service_id attribute.
    /// </summary>
    [TerraformProperty("custom_question_answering_search_service_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomQuestionAnsweringSearchServiceId { get; set; }

    /// <summary>
    /// The custom_question_answering_search_service_key attribute.
    /// </summary>
    [TerraformProperty("custom_question_answering_search_service_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomQuestionAnsweringSearchServiceKey { get; set; }

    /// <summary>
    /// The custom_subdomain_name attribute.
    /// </summary>
    [TerraformProperty("custom_subdomain_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomSubdomainName { get; set; }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    [TerraformProperty("dynamic_throttling_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DynamicThrottlingEnabled { get; set; }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformProperty("fqdns")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Fqdns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformProperty("kind")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Kind { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The metrics_advisor_aad_client_id attribute.
    /// </summary>
    [TerraformProperty("metrics_advisor_aad_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricsAdvisorAadClientId { get; set; }

    /// <summary>
    /// The metrics_advisor_aad_tenant_id attribute.
    /// </summary>
    [TerraformProperty("metrics_advisor_aad_tenant_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricsAdvisorAadTenantId { get; set; }

    /// <summary>
    /// The metrics_advisor_super_user_name attribute.
    /// </summary>
    [TerraformProperty("metrics_advisor_super_user_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricsAdvisorSuperUserName { get; set; }

    /// <summary>
    /// The metrics_advisor_website_name attribute.
    /// </summary>
    [TerraformProperty("metrics_advisor_website_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricsAdvisorWebsiteName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    [TerraformProperty("outbound_network_access_restricted")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>
    /// The project_management_enabled attribute.
    /// </summary>
    [TerraformProperty("project_management_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ProjectManagementEnabled { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The qna_runtime_endpoint attribute.
    /// </summary>
    [TerraformProperty("qna_runtime_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? QnaRuntimeEndpoint { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformProperty("customer_managed_key")]
    public TerraformList<TerraformBlock<AzurermCognitiveAccountCustomerManagedKeyBlock>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermCognitiveAccountIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    [TerraformProperty("network_acls")]
    public TerraformList<TerraformBlock<AzurermCognitiveAccountNetworkAclsBlock>>? NetworkAcls { get; set; }

    /// <summary>
    /// Block for network_injection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInjection block(s) allowed")]
    [TerraformProperty("network_injection")]
    public TerraformList<TerraformBlock<AzurermCognitiveAccountNetworkInjectionBlock>>? NetworkInjection { get; set; }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("storage")]
    public TerraformList<TerraformBlock<AzurermCognitiveAccountStorageBlock>>? Storage { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermCognitiveAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformProperty("primary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryAccessKey { get; }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformProperty("secondary_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAccessKey { get; }

}
