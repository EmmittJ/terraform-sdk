using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault resource.
/// </summary>
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
    public List<object>? AccessPolicy
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("access_policy")?.Value;
        set => this.WithProperty("access_policy", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? EnableRbacAuthorization
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_rbac_authorization")?.Value;
        set => this.WithProperty("enable_rbac_authorization", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public bool? EnabledForDeployment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled_for_deployment")?.Value;
        set => this.WithProperty("enabled_for_deployment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public bool? EnabledForDiskEncryption
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled_for_disk_encryption")?.Value;
        set => this.WithProperty("enabled_for_disk_encryption", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public bool? EnabledForTemplateDeployment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled_for_template_deployment")?.Value;
        set => this.WithProperty("enabled_for_template_deployment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public bool? RbacAuthorizationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rbac_authorization_enabled")?.Value;
        set => this.WithProperty("rbac_authorization_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The vault_uri attribute.
    /// </summary>
    public TerraformExpression VaultUri => this["vault_uri"];

}
