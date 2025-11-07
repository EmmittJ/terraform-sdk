using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_server_transparent_data_encryption resource.
/// </summary>
public class AzurermMssqlServerTransparentDataEncryption : TerraformResource
{
    public AzurermMssqlServerTransparentDataEncryption(string name) : base("azurerm_mssql_server_transparent_data_encryption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_rotation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoRotationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_rotation_enabled");
        set => this.WithProperty("auto_rotation_enabled", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_key_id");
        set => this.WithProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServerId
    {
        get => GetProperty<TerraformProperty<string>>("server_id");
        set => this.WithProperty("server_id", value);
    }

}
