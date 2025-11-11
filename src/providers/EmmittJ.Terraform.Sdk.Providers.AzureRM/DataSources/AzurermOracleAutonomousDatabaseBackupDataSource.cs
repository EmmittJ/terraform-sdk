using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_backup.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseBackupDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupDataSource(string name) : base("azurerm_oracle_autonomous_database_backup", name)
    {
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformProperty("autonomous_database_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    [TerraformProperty("automatic")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Automatic { get; }

    /// <summary>
    /// The autonomous_database_backup_ocid attribute.
    /// </summary>
    [TerraformProperty("autonomous_database_backup_ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AutonomousDatabaseBackupOcid { get; }

    /// <summary>
    /// The autonomous_database_ocid attribute.
    /// </summary>
    [TerraformProperty("autonomous_database_ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AutonomousDatabaseOcid { get; }

    /// <summary>
    /// The database_backup_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("database_backup_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DatabaseBackupSizeInTbs { get; }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [TerraformProperty("database_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DatabaseVersion { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformProperty("lifecycle_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LifecycleDetails { get; }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    [TerraformProperty("provisioning_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProvisioningState { get; }

    /// <summary>
    /// The restorable attribute.
    /// </summary>
    [TerraformProperty("restorable")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Restorable { get; }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_period_in_days")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RetentionPeriodInDays { get; }

    /// <summary>
    /// The time_available_til attribute.
    /// </summary>
    [TerraformProperty("time_available_til")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeAvailableTil { get; }

    /// <summary>
    /// The time_ended attribute.
    /// </summary>
    [TerraformProperty("time_ended")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeEnded { get; }

    /// <summary>
    /// The time_started attribute.
    /// </summary>
    [TerraformProperty("time_started")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeStarted { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
