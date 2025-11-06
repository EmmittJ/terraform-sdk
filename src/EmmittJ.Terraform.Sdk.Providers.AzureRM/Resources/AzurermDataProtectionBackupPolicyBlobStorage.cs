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
    public List<string>? BackupRepeatingTimeIntervals
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("backup_repeating_time_intervals")?.Value;
        set => this.WithProperty("backup_repeating_time_intervals", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The operational_default_retention_duration attribute.
    /// </summary>
    public string? OperationalDefaultRetentionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operational_default_retention_duration")?.Value;
        set => this.WithProperty("operational_default_retention_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vault_default_retention_duration attribute.
    /// </summary>
    public string? VaultDefaultRetentionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_default_retention_duration")?.Value;
        set => this.WithProperty("vault_default_retention_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    public string? VaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_id")?.Value;
        set => this.WithProperty("vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
