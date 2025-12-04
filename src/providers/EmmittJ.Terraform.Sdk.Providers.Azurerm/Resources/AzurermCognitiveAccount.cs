using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for customer_managed_key in AzurermCognitiveAccount.
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
    public TerraformValue<string>? IdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("identity_client_id");
        set => SetArgument("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermCognitiveAccount.
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
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for network_acls in AzurermCognitiveAccount.
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
    public TerraformValue<string>? Bypass
    {
        get => GetArgument<TerraformValue<string>>("bypass");
        set => SetArgument("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformValue<string> DefaultAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public TerraformSet<string>? IpRules
    {
        get => GetArgument<TerraformSet<string>>("ip_rules");
        set => SetArgument("ip_rules", value);
    }

    /// <summary>
    /// VirtualNetworkRules block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermCognitiveAccountNetworkAclsBlockVirtualNetworkRulesBlock>? VirtualNetworkRules
    {
        get => GetArgument<TerraformSet<AzurermCognitiveAccountNetworkAclsBlockVirtualNetworkRulesBlock>>("virtual_network_rules");
        set => SetArgument("virtual_network_rules", value);
    }

}

/// <summary>
/// Block type for virtual_network_rules in AzurermCognitiveAccountNetworkAclsBlock.
/// Nesting mode: set
/// </summary>
public class AzurermCognitiveAccountNetworkAclsBlockVirtualNetworkRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_network_rules";

    /// <summary>
    /// The ignore_missing_vnet_service_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreMissingVnetServiceEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("ignore_missing_vnet_service_endpoint");
        set => SetArgument("ignore_missing_vnet_service_endpoint", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for network_injection in AzurermCognitiveAccount.
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
    public required TerraformValue<string> Scenario
    {
        get => GetRequiredArgument<TerraformValue<string>>("scenario");
        set => SetArgument("scenario", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for storage in AzurermCognitiveAccount.
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
    public TerraformValue<string>? IdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("identity_client_id");
        set => SetArgument("identity_client_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCognitiveAccount.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_cognitive_account Terraform resource.
/// Manages a azurerm_cognitive_account resource.
/// </summary>
public partial class AzurermCognitiveAccount(string name) : TerraformResource("azurerm_cognitive_account", name)
{
    /// <summary>
    /// The custom_question_answering_search_service_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomQuestionAnsweringSearchServiceId
    {
        get => GetArgument<TerraformValue<string>>("custom_question_answering_search_service_id");
        set => SetArgument("custom_question_answering_search_service_id", value);
    }

    /// <summary>
    /// The custom_question_answering_search_service_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomQuestionAnsweringSearchServiceKey
    {
        get => GetArgument<TerraformValue<string>>("custom_question_answering_search_service_key");
        set => SetArgument("custom_question_answering_search_service_key", value);
    }

    /// <summary>
    /// The custom_subdomain_name attribute.
    /// </summary>
    public TerraformValue<string>? CustomSubdomainName
    {
        get => GetArgument<TerraformValue<string>>("custom_subdomain_name");
        set => SetArgument("custom_subdomain_name", value);
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicThrottlingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dynamic_throttling_enabled");
        set => SetArgument("dynamic_throttling_enabled", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public TerraformList<string>? Fqdns
    {
        get => GetArgument<TerraformList<string>>("fqdns");
        set => SetArgument("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kind is required")]
    public required TerraformValue<string> Kind
    {
        get => GetRequiredArgument<TerraformValue<string>>("kind");
        set => SetArgument("kind", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_auth_enabled");
        set => SetArgument("local_auth_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The metrics_advisor_aad_client_id attribute.
    /// </summary>
    public TerraformValue<string>? MetricsAdvisorAadClientId
    {
        get => GetArgument<TerraformValue<string>>("metrics_advisor_aad_client_id");
        set => SetArgument("metrics_advisor_aad_client_id", value);
    }

    /// <summary>
    /// The metrics_advisor_aad_tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? MetricsAdvisorAadTenantId
    {
        get => GetArgument<TerraformValue<string>>("metrics_advisor_aad_tenant_id");
        set => SetArgument("metrics_advisor_aad_tenant_id", value);
    }

    /// <summary>
    /// The metrics_advisor_super_user_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricsAdvisorSuperUserName
    {
        get => GetArgument<TerraformValue<string>>("metrics_advisor_super_user_name");
        set => SetArgument("metrics_advisor_super_user_name", value);
    }

    /// <summary>
    /// The metrics_advisor_website_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricsAdvisorWebsiteName
    {
        get => GetArgument<TerraformValue<string>>("metrics_advisor_website_name");
        set => SetArgument("metrics_advisor_website_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformValue<bool>? OutboundNetworkAccessRestricted
    {
        get => GetArgument<TerraformValue<bool>>("outbound_network_access_restricted");
        set => SetArgument("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The project_management_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ProjectManagementEnabled
    {
        get => GetArgument<TerraformValue<bool>>("project_management_enabled");
        set => SetArgument("project_management_enabled", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The qna_runtime_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? QnaRuntimeEndpoint
    {
        get => GetArgument<TerraformValue<string>>("qna_runtime_endpoint");
        set => SetArgument("qna_runtime_endpoint", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public TerraformList<AzurermCognitiveAccountCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetArgument<TerraformList<AzurermCognitiveAccountCustomerManagedKeyBlock>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermCognitiveAccountIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermCognitiveAccountIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NetworkAcls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public TerraformList<AzurermCognitiveAccountNetworkAclsBlock>? NetworkAcls
    {
        get => GetArgument<TerraformList<AzurermCognitiveAccountNetworkAclsBlock>>("network_acls");
        set => SetArgument("network_acls", value);
    }

    /// <summary>
    /// NetworkInjection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInjection block(s) allowed")]
    public TerraformList<AzurermCognitiveAccountNetworkInjectionBlock>? NetworkInjection
    {
        get => GetArgument<TerraformList<AzurermCognitiveAccountNetworkInjectionBlock>>("network_injection");
        set => SetArgument("network_injection", value);
    }

    /// <summary>
    /// Storage block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCognitiveAccountStorageBlock>? Storage
    {
        get => GetArgument<TerraformList<AzurermCognitiveAccountStorageBlock>>("storage");
        set => SetArgument("storage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCognitiveAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCognitiveAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
