using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_key";

    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformArgument("identity_client_id")]
    public TerraformValue<string>? IdentityClientId
    {
        get => new TerraformReference<string>(this, "identity_client_id");
        set => SetArgument("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformArgument("key_vault_key_id")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountNetworkAclsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_acls";

    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [TerraformArgument("bypass")]
    public TerraformValue<string>? Bypass
    {
        get => new TerraformReference<string>(this, "bypass");
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [TerraformArgument("default_action")]
    public required TerraformValue<string> DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    [TerraformArgument("ip_rules")]
    public TerraformSet<string>? IpRules
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ip_rules").ResolveNodes(ctx));
        set => SetArgument("ip_rules", value);
    }

}

/// <summary>
/// Block type for network_injection in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountNetworkInjectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_injection";

    /// <summary>
    /// The scenario attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scenario is required")]
    [TerraformArgument("scenario")]
    public required TerraformValue<string> Scenario
    {
        get => new TerraformReference<string>(this, "scenario");
        set => SetArgument("scenario", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveAccountStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage";

    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    [TerraformArgument("identity_client_id")]
    public TerraformValue<string>? IdentityClientId
    {
        get => new TerraformReference<string>(this, "identity_client_id");
        set => SetArgument("identity_client_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformArgument("storage_account_id")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCognitiveAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The custom_question_answering_search_service_id attribute.
    /// </summary>
    [TerraformArgument("custom_question_answering_search_service_id")]
    public TerraformValue<string>? CustomQuestionAnsweringSearchServiceId
    {
        get => new TerraformReference<string>(this, "custom_question_answering_search_service_id");
        set => SetArgument("custom_question_answering_search_service_id", value);
    }

    /// <summary>
    /// The custom_question_answering_search_service_key attribute.
    /// </summary>
    [TerraformArgument("custom_question_answering_search_service_key")]
    public TerraformValue<string>? CustomQuestionAnsweringSearchServiceKey
    {
        get => new TerraformReference<string>(this, "custom_question_answering_search_service_key");
        set => SetArgument("custom_question_answering_search_service_key", value);
    }

    /// <summary>
    /// The custom_subdomain_name attribute.
    /// </summary>
    [TerraformArgument("custom_subdomain_name")]
    public TerraformValue<string>? CustomSubdomainName
    {
        get => new TerraformReference<string>(this, "custom_subdomain_name");
        set => SetArgument("custom_subdomain_name", value);
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    [TerraformArgument("dynamic_throttling_enabled")]
    public TerraformValue<bool>? DynamicThrottlingEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_throttling_enabled");
        set => SetArgument("dynamic_throttling_enabled", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    [TerraformArgument("fqdns")]
    public TerraformList<string>? Fqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "fqdns").ResolveNodes(ctx));
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    [TerraformArgument("kind")]
    public required TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformArgument("local_auth_enabled")]
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => new TerraformReference<bool>(this, "local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The metrics_advisor_aad_client_id attribute.
    /// </summary>
    [TerraformArgument("metrics_advisor_aad_client_id")]
    public TerraformValue<string>? MetricsAdvisorAadClientId
    {
        get => new TerraformReference<string>(this, "metrics_advisor_aad_client_id");
        set => SetArgument("metrics_advisor_aad_client_id", value);
    }

    /// <summary>
    /// The metrics_advisor_aad_tenant_id attribute.
    /// </summary>
    [TerraformArgument("metrics_advisor_aad_tenant_id")]
    public TerraformValue<string>? MetricsAdvisorAadTenantId
    {
        get => new TerraformReference<string>(this, "metrics_advisor_aad_tenant_id");
        set => SetArgument("metrics_advisor_aad_tenant_id", value);
    }

    /// <summary>
    /// The metrics_advisor_super_user_name attribute.
    /// </summary>
    [TerraformArgument("metrics_advisor_super_user_name")]
    public TerraformValue<string>? MetricsAdvisorSuperUserName
    {
        get => new TerraformReference<string>(this, "metrics_advisor_super_user_name");
        set => SetArgument("metrics_advisor_super_user_name", value);
    }

    /// <summary>
    /// The metrics_advisor_website_name attribute.
    /// </summary>
    [TerraformArgument("metrics_advisor_website_name")]
    public TerraformValue<string>? MetricsAdvisorWebsiteName
    {
        get => new TerraformReference<string>(this, "metrics_advisor_website_name");
        set => SetArgument("metrics_advisor_website_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    [TerraformArgument("outbound_network_access_restricted")]
    public TerraformValue<bool>? OutboundNetworkAccessRestricted
    {
        get => new TerraformReference<bool>(this, "outbound_network_access_restricted");
        set => SetArgument("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The project_management_enabled attribute.
    /// </summary>
    [TerraformArgument("project_management_enabled")]
    public TerraformValue<bool>? ProjectManagementEnabled
    {
        get => new TerraformReference<bool>(this, "project_management_enabled");
        set => SetArgument("project_management_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The qna_runtime_endpoint attribute.
    /// </summary>
    [TerraformArgument("qna_runtime_endpoint")]
    public TerraformValue<string>? QnaRuntimeEndpoint
    {
        get => new TerraformReference<string>(this, "qna_runtime_endpoint");
        set => SetArgument("qna_runtime_endpoint", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformArgument("customer_managed_key")]
    public TerraformList<AzurermCognitiveAccountCustomerManagedKeyBlock> CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermCognitiveAccountIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    [TerraformArgument("network_acls")]
    public TerraformList<AzurermCognitiveAccountNetworkAclsBlock> NetworkAcls { get; set; } = new();

    /// <summary>
    /// Block for network_injection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInjection block(s) allowed")]
    [TerraformArgument("network_injection")]
    public TerraformList<AzurermCognitiveAccountNetworkInjectionBlock> NetworkInjection { get; set; } = new();

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("storage")]
    public TerraformList<AzurermCognitiveAccountStorageBlock> Storage { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCognitiveAccountTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformArgument("primary_access_key")]
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformArgument("secondary_access_key")]
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

}
