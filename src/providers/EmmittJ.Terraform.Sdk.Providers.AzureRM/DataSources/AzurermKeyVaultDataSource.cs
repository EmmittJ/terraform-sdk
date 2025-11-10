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
        set => SetProperty("read", value);
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
        SetOutput("access_policy");
        SetOutput("enable_rbac_authorization");
        SetOutput("enabled_for_deployment");
        SetOutput("enabled_for_disk_encryption");
        SetOutput("enabled_for_template_deployment");
        SetOutput("location");
        SetOutput("network_acls");
        SetOutput("public_network_access_enabled");
        SetOutput("purge_protection_enabled");
        SetOutput("rbac_authorization_enabled");
        SetOutput("sku_name");
        SetOutput("tags");
        SetOutput("tenant_id");
        SetOutput("vault_uri");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
