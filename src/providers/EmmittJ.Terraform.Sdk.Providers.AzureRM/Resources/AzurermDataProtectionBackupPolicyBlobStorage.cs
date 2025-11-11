using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for retention_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_data_protection_backup_policy_blob_storage resource.
/// </summary>
public partial class AzurermDataProtectionBackupPolicyBlobStorage : TerraformResource
{
    public AzurermDataProtectionBackupPolicyBlobStorage(string name) : base("azurerm_data_protection_backup_policy_blob_storage", name)
    {
    }

    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    [TerraformProperty("backup_repeating_time_intervals")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The operational_default_retention_duration attribute.
    /// </summary>
    [TerraformProperty("operational_default_retention_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OperationalDefaultRetentionDuration { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TimeZone { get; set; }

    /// <summary>
    /// The vault_default_retention_duration attribute.
    /// </summary>
    [TerraformProperty("vault_default_retention_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VaultDefaultRetentionDuration { get; set; }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    [TerraformProperty("vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VaultId { get; set; }

    /// <summary>
    /// Block for retention_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("retention_rule")]
    public TerraformList<TerraformBlock<AzurermDataProtectionBackupPolicyBlobStorageRetentionRuleBlock>>? RetentionRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDataProtectionBackupPolicyBlobStorageTimeoutsBlock>? Timeouts { get; set; }

}
