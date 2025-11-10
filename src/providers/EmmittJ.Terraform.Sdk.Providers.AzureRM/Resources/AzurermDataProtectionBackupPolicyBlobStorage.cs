using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for retention_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("backup_repeating_time_intervals");
        SetOutput("id");
        SetOutput("name");
        SetOutput("operational_default_retention_duration");
        SetOutput("time_zone");
        SetOutput("vault_default_retention_duration");
        SetOutput("vault_id");
    }

    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    public List<TerraformProperty<string>> BackupRepeatingTimeIntervals
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("backup_repeating_time_intervals");
        set => SetProperty("backup_repeating_time_intervals", value);
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
    /// The operational_default_retention_duration attribute.
    /// </summary>
    public TerraformProperty<string> OperationalDefaultRetentionDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("operational_default_retention_duration");
        set => SetProperty("operational_default_retention_duration", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// The vault_default_retention_duration attribute.
    /// </summary>
    public TerraformProperty<string> VaultDefaultRetentionDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vault_default_retention_duration");
        set => SetProperty("vault_default_retention_duration", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformProperty<string> VaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vault_id");
        set => SetProperty("vault_id", value);
    }

    /// <summary>
    /// Block for retention_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock>? RetentionRule
    {
        set => SetProperty("retention_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
