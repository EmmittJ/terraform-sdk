using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for contact in .
/// Nesting mode: set
/// </summary>
public class AzurermKeyVaultContactBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The phone attribute.
    /// </summary>
    public TerraformProperty<string>? Phone
    {
        get => GetProperty<TerraformProperty<string>>("phone");
        set => WithProperty("phone", value);
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
        get => GetProperty<TerraformProperty<string>>("bypass");
        set => WithProperty("bypass", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    public required TerraformProperty<string> DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
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

    /// <summary>
    /// The virtual_network_subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VirtualNetworkSubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("virtual_network_subnet_ids");
        set => WithProperty("virtual_network_subnet_ids", value);
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
        this.DeclareOutput("vault_uri");
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public List<TerraformProperty<object>>? AccessPolicy
    {
        get => GetProperty<List<TerraformProperty<object>>>("access_policy");
        set => this.WithProperty("access_policy", value);
    }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableRbacAuthorization
    {
        get => GetProperty<TerraformProperty<bool>>("enable_rbac_authorization");
        set => this.WithProperty("enable_rbac_authorization", value);
    }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public TerraformProperty<bool>? EnabledForDeployment
    {
        get => GetProperty<TerraformProperty<bool>>("enabled_for_deployment");
        set => this.WithProperty("enabled_for_deployment", value);
    }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public TerraformProperty<bool>? EnabledForDiskEncryption
    {
        get => GetProperty<TerraformProperty<bool>>("enabled_for_disk_encryption");
        set => this.WithProperty("enabled_for_disk_encryption", value);
    }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public TerraformProperty<bool>? EnabledForTemplateDeployment
    {
        get => GetProperty<TerraformProperty<bool>>("enabled_for_template_deployment");
        set => this.WithProperty("enabled_for_template_deployment", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PurgeProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("purge_protection_enabled");
        set => this.WithProperty("purge_protection_enabled", value);
    }

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RbacAuthorizationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rbac_authorization_enabled");
        set => this.WithProperty("rbac_authorization_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? SoftDeleteRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("soft_delete_retention_days");
        set => this.WithProperty("soft_delete_retention_days", value);
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
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// Block for contact.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermKeyVaultContactBlock>? Contact
    {
        get => GetProperty<HashSet<AzurermKeyVaultContactBlock>>("contact");
        set => this.WithProperty("contact", value);
    }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public List<AzurermKeyVaultNetworkAclsBlock>? NetworkAcls
    {
        get => GetProperty<List<AzurermKeyVaultNetworkAclsBlock>>("network_acls");
        set => this.WithProperty("network_acls", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    public TerraformExpression VaultUri => this["vault_uri"];

}
