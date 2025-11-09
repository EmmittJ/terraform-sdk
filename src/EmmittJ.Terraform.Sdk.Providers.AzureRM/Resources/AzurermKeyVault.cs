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
    public TerraformProperty<List<object>>? AccessPolicy
    {
        get => GetProperty<TerraformProperty<List<object>>>("access_policy");
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
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
    /// The vault_uri attribute.
    /// </summary>
    public TerraformExpression VaultUri => this["vault_uri"];

}
