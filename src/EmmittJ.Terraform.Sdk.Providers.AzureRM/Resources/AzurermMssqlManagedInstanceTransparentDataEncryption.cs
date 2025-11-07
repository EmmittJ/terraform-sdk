using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_managed_instance_transparent_data_encryption resource.
/// </summary>
public class AzurermMssqlManagedInstanceTransparentDataEncryption : TerraformResource
{
    public AzurermMssqlManagedInstanceTransparentDataEncryption(string name) : base("azurerm_mssql_managed_instance_transparent_data_encryption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_rotation_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoRotationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_rotation_enabled");
        set => this.WithProperty("auto_rotation_enabled", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_key_id");
        set => this.WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_instance_id");
        set => this.WithProperty("managed_instance_id", value);
    }

}
