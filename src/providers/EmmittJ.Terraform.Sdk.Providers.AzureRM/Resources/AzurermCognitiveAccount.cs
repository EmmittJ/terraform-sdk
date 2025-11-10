using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityClientId
    {
        set => SetProperty("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        set => SetProperty("key_vault_key_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountNetworkAclsBlock : TerraformBlock
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    public TerraformProperty<string>? Bypass
    {
        set => SetProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        set => SetProperty("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpRules
    {
        set => SetProperty("ip_rules", value);
    }

}

/// <summary>
/// Block type for network_injection in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountNetworkInjectionBlock : TerraformBlock
{
    /// <summary>
    /// The scenario attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scenario is required")]
    public required TerraformProperty<string> Scenario
    {
        set => SetProperty("scenario", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountStorageBlock : TerraformBlock
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityClientId
    {
        set => SetProperty("identity_client_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        set => SetProperty("storage_account_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCognitiveAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cognitive_account resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCognitiveAccount : TerraformResource
{
    public AzurermCognitiveAccount(string name) : base("azurerm_cognitive_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("endpoint");
        SetOutput("primary_access_key");
        SetOutput("secondary_access_key");
        SetOutput("custom_question_answering_search_service_id");
        SetOutput("custom_question_answering_search_service_key");
        SetOutput("custom_subdomain_name");
        SetOutput("dynamic_throttling_enabled");
        SetOutput("fqdns");
        SetOutput("id");
        SetOutput("kind");
        SetOutput("local_auth_enabled");
        SetOutput("location");
        SetOutput("metrics_advisor_aad_client_id");
        SetOutput("metrics_advisor_aad_tenant_id");
        SetOutput("metrics_advisor_super_user_name");
        SetOutput("metrics_advisor_website_name");
        SetOutput("name");
        SetOutput("outbound_network_access_restricted");
        SetOutput("project_management_enabled");
        SetOutput("public_network_access_enabled");
        SetOutput("qna_runtime_endpoint");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The custom_question_answering_search_service_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomQuestionAnsweringSearchServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_question_answering_search_service_id");
        set => SetProperty("custom_question_answering_search_service_id", value);
    }

    /// <summary>
    /// The custom_question_answering_search_service_key attribute.
    /// </summary>
    public TerraformProperty<string> CustomQuestionAnsweringSearchServiceKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_question_answering_search_service_key");
        set => SetProperty("custom_question_answering_search_service_key", value);
    }

    /// <summary>
    /// The custom_subdomain_name attribute.
    /// </summary>
    public TerraformProperty<string> CustomSubdomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_subdomain_name");
        set => SetProperty("custom_subdomain_name", value);
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DynamicThrottlingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dynamic_throttling_enabled");
        set => SetProperty("dynamic_throttling_enabled", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public List<TerraformProperty<string>> Fqdns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("fqdns");
        set => SetProperty("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformProperty<string> Kind
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kind");
        set => SetProperty("kind", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAuthEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_auth_enabled");
        set => SetProperty("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The metrics_advisor_aad_client_id attribute.
    /// </summary>
    public TerraformProperty<string> MetricsAdvisorAadClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metrics_advisor_aad_client_id");
        set => SetProperty("metrics_advisor_aad_client_id", value);
    }

    /// <summary>
    /// The metrics_advisor_aad_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string> MetricsAdvisorAadTenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metrics_advisor_aad_tenant_id");
        set => SetProperty("metrics_advisor_aad_tenant_id", value);
    }

    /// <summary>
    /// The metrics_advisor_super_user_name attribute.
    /// </summary>
    public TerraformProperty<string> MetricsAdvisorSuperUserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metrics_advisor_super_user_name");
        set => SetProperty("metrics_advisor_super_user_name", value);
    }

    /// <summary>
    /// The metrics_advisor_website_name attribute.
    /// </summary>
    public TerraformProperty<string> MetricsAdvisorWebsiteName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metrics_advisor_website_name");
        set => SetProperty("metrics_advisor_website_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformProperty<bool> OutboundNetworkAccessRestricted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("outbound_network_access_restricted");
        set => SetProperty("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The project_management_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ProjectManagementEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("project_management_enabled");
        set => SetProperty("project_management_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The qna_runtime_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> QnaRuntimeEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qna_runtime_endpoint");
        set => SetProperty("qna_runtime_endpoint", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermCognitiveAccountCustomerManagedKeyBlock>? CustomerManagedKey
    {
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermCognitiveAccountIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public List<AzurermCognitiveAccountNetworkAclsBlock>? NetworkAcls
    {
        set => SetProperty("network_acls", value);
    }

    /// <summary>
    /// Block for network_injection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInjection block(s) allowed")]
    public List<AzurermCognitiveAccountNetworkInjectionBlock>? NetworkInjection
    {
        set => SetProperty("network_injection", value);
    }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermCognitiveAccountStorageBlock>? Storage
    {
        set => SetProperty("storage", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCognitiveAccountTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

}
