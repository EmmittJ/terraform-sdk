using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_backup.
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupDataSource(string name) : base("azurerm_oracle_autonomous_database_backup", name)
    {
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformPropertyName("autonomous_database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    [TerraformPropertyName("automatic")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Automatic => new TerraformReference(this, "automatic");

    /// <summary>
    /// The autonomous_database_backup_ocid attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_database_backup_ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutonomousDatabaseBackupOcid => new TerraformReference(this, "autonomous_database_backup_ocid");

    /// <summary>
    /// The autonomous_database_ocid attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_database_ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutonomousDatabaseOcid => new TerraformReference(this, "autonomous_database_ocid");

    /// <summary>
    /// The database_backup_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("database_backup_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DatabaseBackupSizeInTbs => new TerraformReference(this, "database_backup_size_in_tbs");

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseVersion => new TerraformReference(this, "database_version");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleDetails => new TerraformReference(this, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleState => new TerraformReference(this, "lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProvisioningState => new TerraformReference(this, "provisioning_state");

    /// <summary>
    /// The restorable attribute.
    /// </summary>
    [TerraformPropertyName("restorable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Restorable => new TerraformReference(this, "restorable");

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_period_in_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RetentionPeriodInDays => new TerraformReference(this, "retention_period_in_days");

    /// <summary>
    /// The time_available_til attribute.
    /// </summary>
    [TerraformPropertyName("time_available_til")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeAvailableTil => new TerraformReference(this, "time_available_til");

    /// <summary>
    /// The time_ended attribute.
    /// </summary>
    [TerraformPropertyName("time_ended")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeEnded => new TerraformReference(this, "time_ended");

    /// <summary>
    /// The time_started attribute.
    /// </summary>
    [TerraformPropertyName("time_started")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeStarted => new TerraformReference(this, "time_started");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
