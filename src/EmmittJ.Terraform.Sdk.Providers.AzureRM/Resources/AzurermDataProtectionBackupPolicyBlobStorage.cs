using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_policy_blob_storage resource.
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorage : TerraformResource
{
    public AzurermDataProtectionBackupPolicyBlobStorage(string name) : base("azurerm_data_protection_backup_policy_blob_storage", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? BackupRepeatingTimeIntervals
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("backup_repeating_time_intervals");
        set => this.WithProperty("backup_repeating_time_intervals", value);
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
    /// The operational_default_retention_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OperationalDefaultRetentionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operational_default_retention_duration");
        set => this.WithProperty("operational_default_retention_duration", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// The vault_default_retention_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VaultDefaultRetentionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_default_retention_duration");
        set => this.WithProperty("vault_default_retention_duration", value);
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
