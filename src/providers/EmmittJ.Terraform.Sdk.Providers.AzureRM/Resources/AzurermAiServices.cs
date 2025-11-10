using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermAiServicesCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("identity_client_id");
        set => WithProperty("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_key_id");
        set => WithProperty("managed_hsm_key_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermAiServicesIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public class AzurermAiServicesNetworkAclsBlock : TerraformBlock
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    public TerraformProperty<string>? Bypass
    {
        get => GetProperty<TerraformProperty<string>>("bypass");
        set => WithProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_action");
        set => WithProperty("default_action", value);
    }

    /// <summary>
    /// The ip_rules attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IpRules
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ip_rules");
        set => WithProperty("ip_rules", value);
    }

}

/// <summary>
/// Block type for storage in .
/// Nesting mode: list
/// </summary>
public class AzurermAiServicesStorageBlock : TerraformBlock
{
    /// <summary>
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("identity_client_id");
        set => WithProperty("identity_client_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => WithProperty("storage_account_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAiServicesTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_ai_services resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAiServices : TerraformResource
{
    public AzurermAiServices(string name) : base("azurerm_ai_services", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("endpoint");
        this.WithOutput("primary_access_key");
        this.WithOutput("secondary_access_key");
    }

    /// <summary>
    /// The custom_subdomain_name attribute.
    /// </summary>
    public TerraformProperty<string>? CustomSubdomainName
    {
        get => GetProperty<TerraformProperty<string>>("custom_subdomain_name");
        set => this.WithProperty("custom_subdomain_name", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Fqdns
    {
        get => GetProperty<List<TerraformProperty<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_enabled");
        set => this.WithProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformProperty<bool>? OutboundNetworkAccessRestricted
    {
        get => GetProperty<TerraformProperty<bool>>("outbound_network_access_restricted");
        set => this.WithProperty("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermAiServicesCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetProperty<List<AzurermAiServicesCustomerManagedKeyBlock>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermAiServicesIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermAiServicesIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public List<AzurermAiServicesNetworkAclsBlock>? NetworkAcls
    {
        get => GetProperty<List<AzurermAiServicesNetworkAclsBlock>>("network_acls");
        set => this.WithProperty("network_acls", value);
    }

    /// <summary>
    /// Block for storage.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermAiServicesStorageBlock>? Storage
    {
        get => GetProperty<List<AzurermAiServicesStorageBlock>>("storage");
        set => this.WithProperty("storage", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAiServicesTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAiServicesTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
