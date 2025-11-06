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
    public HashSet<string>? AdminObjectIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("admin_object_ids")?.Value;
        set => this.WithProperty("admin_object_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public bool? PurgeProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("purge_protection_enabled")?.Value;
        set => this.WithProperty("purge_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_domain_key_vault_certificate_ids attribute.
    /// </summary>
    public List<string>? SecurityDomainKeyVaultCertificateIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("security_domain_key_vault_certificate_ids")?.Value;
        set => this.WithProperty("security_domain_key_vault_certificate_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The security_domain_quorum attribute.
    /// </summary>
    public double? SecurityDomainQuorum
    {
        get => GetProperty<TerraformLiteralProperty<double>>("security_domain_quorum")?.Value;
        set => this.WithProperty("security_domain_quorum", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public double? SoftDeleteRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("soft_delete_retention_days")?.Value;
        set => this.WithProperty("soft_delete_retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public string? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id")?.Value;
        set => this.WithProperty("tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
