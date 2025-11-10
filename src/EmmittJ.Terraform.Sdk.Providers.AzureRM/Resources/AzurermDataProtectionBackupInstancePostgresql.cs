using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstancePostgresqlTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformProperty<string> BackupPolicyId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    public required TerraformProperty<string> DatabaseId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformProperty<string> VaultId
    {
        get => GetProperty<TerraformProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataProtectionBackupInstancePostgresqlTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataProtectionBackupInstancePostgresqlTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
