using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault.
/// </summary>
public class AzurermKeyVaultDataSource : TerraformDataSource
{
    public AzurermKeyVaultDataSource(string name) : base("azurerm_key_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_policy");
        this.WithOutput("enable_rbac_authorization");
        this.WithOutput("enabled_for_deployment");
        this.WithOutput("enabled_for_disk_encryption");
        this.WithOutput("enabled_for_template_deployment");
        this.WithOutput("location");
        this.WithOutput("network_acls");
        this.WithOutput("public_network_access_enabled");
        this.WithOutput("purge_protection_enabled");
        this.WithOutput("rbac_authorization_enabled");
        this.WithOutput("sku_name");
        this.WithOutput("tags");
        this.WithOutput("tenant_id");
        this.WithOutput("vault_uri");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKeyVaultDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public TerraformExpression AccessPolicy => this["access_policy"];

    /// <summary>
    /// The enable_rbac_authorization attribute.
    /// </summary>
    public TerraformExpression EnableRbacAuthorization => this["enable_rbac_authorization"];

    /// <summary>
    /// The enabled_for_deployment attribute.
    /// </summary>
    public TerraformExpression EnabledForDeployment => this["enabled_for_deployment"];

    /// <summary>
    /// The enabled_for_disk_encryption attribute.
    /// </summary>
    public TerraformExpression EnabledForDiskEncryption => this["enabled_for_disk_encryption"];

    /// <summary>
    /// The enabled_for_template_deployment attribute.
    /// </summary>
    public TerraformExpression EnabledForTemplateDeployment => this["enabled_for_template_deployment"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The network_acls attribute.
    /// </summary>
    public TerraformExpression NetworkAcls => this["network_acls"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformExpression PurgeProtectionEnabled => this["purge_protection_enabled"];

    /// <summary>
    /// The rbac_authorization_enabled attribute.
    /// </summary>
    public TerraformExpression RbacAuthorizationEnabled => this["rbac_authorization_enabled"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

    /// <summary>
    /// The vault_uri attribute.
    /// </summary>
    public TerraformExpression VaultUri => this["vault_uri"];

}
