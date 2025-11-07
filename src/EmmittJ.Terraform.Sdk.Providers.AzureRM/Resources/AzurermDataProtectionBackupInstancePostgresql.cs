using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_instance_postgresql resource.
/// </summary>
public class AzurermDataProtectionBackupInstancePostgresql : TerraformResource
{
    public AzurermDataProtectionBackupInstancePostgresql(string name) : base("azurerm_data_protection_backup_instance_postgresql", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The database_credential_key_vault_secret_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseCredentialKeyVaultSecretId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_credential_key_vault_secret_id");
        set => this.WithProperty("database_credential_key_vault_secret_id", value);
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_id");
        set => this.WithProperty("database_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

}
