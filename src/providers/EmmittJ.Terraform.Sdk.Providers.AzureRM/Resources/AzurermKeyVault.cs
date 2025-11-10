using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for contact in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKeyVaultContactBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    public TerraformProperty<string>? Phone
    {
        set => SetProperty("phone", value);
    }

}

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultNetworkAclsBlock : TerraformBlock
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bypass is required")]
    public required TerraformProperty<string> Bypass
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

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VirtualNetworkSubnetIds
    {
        set => SetProperty("virtual_network_subnet_ids", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_key_vault resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKeyVault : TerraformResource
{
    public AzurermKeyVault(string name) : base("azurerm_key_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("vault_uri");
        SetOutput("access_policy");
        SetOutput("enable_rbac_authorization");
        SetOutput("enabled_for_deployment");
        SetOutput("enabled_for_disk_encryption");
        SetOutput("enabled_for_template_deployment");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("purge_protection_enabled");
        SetOutput("rbac_authorization_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("soft_delete_retention_days");
        SetOutput("tags");
        SetOutput("tenant_id");
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public List<TerraformProperty<object>> AccessPolicy
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("access_policy");
        set => SetProperty("access_policy", value);
    }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> EnableRbacAuthorization
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_rbac_authorization");
        set => SetProperty("enable_rbac_authorization", value);
    }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public TerraformProperty<bool> EnabledForDeployment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled_for_deployment");
        set => SetProperty("enabled_for_deployment", value);
    }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public TerraformProperty<bool> EnabledForDiskEncryption
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled_for_disk_encryption");
        set => SetProperty("enabled_for_disk_encryption", value);
    }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public TerraformProperty<bool> EnabledForTemplateDeployment
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled_for_template_deployment");
        set => SetProperty("enabled_for_template_deployment", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PurgeProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("purge_protection_enabled");
        set => SetProperty("purge_protection_enabled", value);
    }

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RbacAuthorizationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("rbac_authorization_enabled");
        set => SetProperty("rbac_authorization_enabled", value);
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
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> SoftDeleteRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("soft_delete_retention_days");
        set => SetProperty("soft_delete_retention_days", value);
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
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// Block for contact.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AzurermKeyVaultContactBlock>? Contact
    {
        set => SetProperty("contact", value);
    }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public List<AzurermKeyVaultNetworkAclsBlock>? NetworkAcls
    {
        set => SetProperty("network_acls", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    public TerraformExpression VaultUri => this["vault_uri"];

}
