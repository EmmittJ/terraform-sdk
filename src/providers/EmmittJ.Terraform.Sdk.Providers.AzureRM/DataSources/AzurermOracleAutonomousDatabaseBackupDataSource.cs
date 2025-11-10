using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseBackupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The automatic attribute.
    /// </summary>
    [TerraformPropertyName("automatic")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Automatic => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "automatic");

    /// <summary>
    /// The autonomous_database_backup_ocid attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_database_backup_ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutonomousDatabaseBackupOcid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "autonomous_database_backup_ocid");

    /// <summary>
    /// The autonomous_database_ocid attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_database_ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutonomousDatabaseOcid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "autonomous_database_ocid");

    /// <summary>
    /// The database_backup_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("database_backup_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DatabaseBackupSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "database_backup_size_in_tbs");

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_version");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The provisioning_state attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProvisioningState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provisioning_state");

    /// <summary>
    /// The restorable attribute.
    /// </summary>
    [TerraformPropertyName("restorable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Restorable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "restorable");

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_period_in_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RetentionPeriodInDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "retention_period_in_days");

    /// <summary>
    /// The time_available_til attribute.
    /// </summary>
    [TerraformPropertyName("time_available_til")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeAvailableTil => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_available_til");

    /// <summary>
    /// The time_ended attribute.
    /// </summary>
    [TerraformPropertyName("time_ended")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeEnded => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_ended");

    /// <summary>
    /// The time_started attribute.
    /// </summary>
    [TerraformPropertyName("time_started")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeStarted => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_started");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
