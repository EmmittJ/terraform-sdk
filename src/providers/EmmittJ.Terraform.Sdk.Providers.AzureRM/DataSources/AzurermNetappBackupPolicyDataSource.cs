using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappBackupPolicyDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_backup_policy.
/// </summary>
public class AzurermNetappBackupPolicyDataSource : TerraformDataSource
{
    public AzurermNetappBackupPolicyDataSource(string name) : base("azurerm_netapp_backup_policy", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappBackupPolicyDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The daily_backups_to_keep attribute.
    /// </summary>
    [TerraformPropertyName("daily_backups_to_keep")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DailyBackupsToKeep => new TerraformReference(this, "daily_backups_to_keep");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The monthly_backups_to_keep attribute.
    /// </summary>
    [TerraformPropertyName("monthly_backups_to_keep")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MonthlyBackupsToKeep => new TerraformReference(this, "monthly_backups_to_keep");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The weekly_backups_to_keep attribute.
    /// </summary>
    [TerraformPropertyName("weekly_backups_to_keep")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> WeeklyBackupsToKeep => new TerraformReference(this, "weekly_backups_to_keep");

}
