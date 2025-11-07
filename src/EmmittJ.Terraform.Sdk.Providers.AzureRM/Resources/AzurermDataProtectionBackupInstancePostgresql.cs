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
    public TerraformProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The database_credential_key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseCredentialKeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("database_credential_key_vault_secret_id");
        set => this.WithProperty("database_credential_key_vault_secret_id", value);
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("database_id");
        set => this.WithProperty("database_id", value);
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
    /// The vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? VaultId
    {
        get => GetProperty<TerraformProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

}
