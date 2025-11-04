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
    public bool? AutoRotationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_rotation_enabled")?.Value;
        set => this.WithProperty("auto_rotation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public string? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id")?.Value;
        set => this.WithProperty("key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public string? ManagedHsmKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_hsm_key_id")?.Value;
        set => this.WithProperty("managed_hsm_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    public string? ServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_id")?.Value;
        set => this.WithProperty("server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
