using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for network_acls in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock : TerraformBlock
{
    /// <summary>
    /// The bypass attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bypass is required")]
    public required TerraformProperty<string> Bypass
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bypass");
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

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_key_vault_managed_hardware_security_module resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKeyVaultManagedHardwareSecurityModule : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModule(string name) : base("azurerm_key_vault_managed_hardware_security_module", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("hsm_uri");
        this.WithOutput("security_domain_encrypted_data");
    }

    /// <summary>
    /// The admin_object_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminObjectIds is required")]
    public HashSet<TerraformProperty<string>>? AdminObjectIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("admin_object_ids");
        set => this.WithProperty("admin_object_ids", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The security_domain_key_vault_certificate_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SecurityDomainKeyVaultCertificateIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("security_domain_key_vault_certificate_ids");
        set => this.WithProperty("security_domain_key_vault_certificate_ids", value);
    }

    /// <summary>
    /// The security_domain_quorum attribute.
    /// </summary>
    public TerraformProperty<double>? SecurityDomainQuorum
    {
        get => GetProperty<TerraformProperty<double>>("security_domain_quorum");
        set => this.WithProperty("security_domain_quorum", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// Block for network_acls.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAcls block(s) allowed")]
    public List<AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock>? NetworkAcls
    {
        get => GetProperty<List<AzurermKeyVaultManagedHardwareSecurityModuleNetworkAclsBlock>>("network_acls");
        set => this.WithProperty("network_acls", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultManagedHardwareSecurityModuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The hsm_uri attribute.
    /// </summary>
    public TerraformExpression HsmUri => this["hsm_uri"];

    /// <summary>
    /// The security_domain_encrypted_data attribute.
    /// </summary>
    public TerraformExpression SecurityDomainEncryptedData => this["security_domain_encrypted_data"];

}
