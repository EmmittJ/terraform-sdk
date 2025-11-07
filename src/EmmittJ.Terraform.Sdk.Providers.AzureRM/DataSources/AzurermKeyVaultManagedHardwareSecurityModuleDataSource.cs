using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_key_vault_managed_hardware_security_module.
/// </summary>
public class AzurermKeyVaultManagedHardwareSecurityModuleDataSource : TerraformDataSource
{
    public AzurermKeyVaultManagedHardwareSecurityModuleDataSource(string name) : base("azurerm_key_vault_managed_hardware_security_module", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("admin_object_ids");
        this.DeclareOutput("hsm_uri");
        this.DeclareOutput("location");
        this.DeclareOutput("purge_protection_enabled");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("soft_delete_retention_days");
        this.DeclareOutput("tags");
        this.DeclareOutput("tenant_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The admin_object_ids attribute.
    /// </summary>
    public TerraformExpression AdminObjectIds => this["admin_object_ids"];

    /// <summary>
    /// The hsm_uri attribute.
    /// </summary>
    public TerraformExpression HsmUri => this["hsm_uri"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The purge_protection_enabled attribute.
    /// </summary>
    public TerraformExpression PurgeProtectionEnabled => this["purge_protection_enabled"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The soft_delete_retention_days attribute.
    /// </summary>
    public TerraformExpression SoftDeleteRetentionDays => this["soft_delete_retention_days"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
