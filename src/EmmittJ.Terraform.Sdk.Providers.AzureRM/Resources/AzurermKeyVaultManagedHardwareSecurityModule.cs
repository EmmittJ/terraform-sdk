using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_managed_hardware_security_module resource.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModule : TerraformResource
{
    public AzurermKeyVaultManagedHardwareSecurityModule(string name) : base("azurerm_key_vault_managed_hardware_security_module", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hsm_uri");
        this.DeclareOutput("security_domain_encrypted_data");
    }

    /// <summary>
    /// The admin_object_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AdminObjectIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("admin_object_ids");
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The security_domain_key_vault_certificate_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SecurityDomainKeyVaultCertificateIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("security_domain_key_vault_certificate_ids");
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
    public TerraformProperty<string>? SkuName
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
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
