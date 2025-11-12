using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for retention_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataProtectionBackupPolicyPostgresqlRetentionRuleBlock() : TerraformBlock("retention_rule")
{
    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Duration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataProtectionBackupPolicyPostgresqlTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_data_protection_backup_policy_postgresql resource.
/// </summary>
public partial class AzurermDataProtectionBackupPolicyPostgresql : TerraformResource
{
    public AzurermDataProtectionBackupPolicyPostgresql(string name) : base("azurerm_data_protection_backup_policy_postgresql", name)
    {
    }

    /// <summary>
    /// The backup_repeating_time_intervals attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRepeatingTimeIntervals is required")]
    [TerraformProperty("backup_repeating_time_intervals")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>
    /// The default_retention_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultRetentionDuration is required")]
    [TerraformProperty("default_retention_duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultRetentionDuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeZone { get; set; }

    /// <summary>
    /// The vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    [TerraformProperty("vault_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VaultName { get; set; }

    /// <summary>
    /// Block for retention_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("retention_rule")]
    public TerraformList<AzurermDataProtectionBackupPolicyPostgresqlRetentionRuleBlock> RetentionRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataProtectionBackupPolicyPostgresqlTimeoutsBlock Timeouts { get; set; } = new();

}
