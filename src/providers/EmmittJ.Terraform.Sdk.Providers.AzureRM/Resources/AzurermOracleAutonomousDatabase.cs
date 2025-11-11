using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for long_term_backup_schedule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOracleAutonomousDatabaseLongTermBackupScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The repeat_cadence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepeatCadence is required")]
    [TerraformProperty("repeat_cadence")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RepeatCadence { get; set; }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodInDays is required")]
    [TerraformProperty("retention_period_in_days")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RetentionPeriodInDays { get; set; }

    /// <summary>
    /// The time_of_backup attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfBackup is required")]
    [TerraformProperty("time_of_backup")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TimeOfBackup { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleAutonomousDatabaseTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_oracle_autonomous_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermOracleAutonomousDatabase : TerraformResource
{
    public AzurermOracleAutonomousDatabase(string name) : base("azurerm_oracle_autonomous_database", name)
    {
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminPassword is required")]
    [TerraformProperty("admin_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AdminPassword { get; set; }

    /// <summary>
    /// The allowed_ips attribute.
    /// </summary>
    [TerraformProperty("allowed_ips")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowedIps { get; set; }

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingEnabled is required")]
    [TerraformProperty("auto_scaling_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> AutoScalingEnabled { get; set; }

    /// <summary>
    /// The auto_scaling_for_storage_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingForStorageEnabled is required")]
    [TerraformProperty("auto_scaling_for_storage_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> AutoScalingForStorageEnabled { get; set; }

    /// <summary>
    /// The backup_retention_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRetentionPeriodInDays is required")]
    [TerraformProperty("backup_retention_period_in_days")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> BackupRetentionPeriodInDays { get; set; }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CharacterSet is required")]
    [TerraformProperty("character_set")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CharacterSet { get; set; }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    [TerraformProperty("compute_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ComputeCount { get; set; }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeModel is required")]
    [TerraformProperty("compute_model")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComputeModel { get; set; }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    [TerraformProperty("customer_contacts")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> CustomerContacts { get; set; }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTbs is required")]
    [TerraformProperty("data_storage_size_in_tbs")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> DataStorageSizeInTbs { get; set; }

    /// <summary>
    /// The db_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbVersion is required")]
    [TerraformProperty("db_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DbVersion { get; set; }

    /// <summary>
    /// The db_workload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbWorkload is required")]
    [TerraformProperty("db_workload")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DbWorkload { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformProperty("license_model")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseModel { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mtls_connection_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MtlsConnectionRequired is required")]
    [TerraformProperty("mtls_connection_required")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> MtlsConnectionRequired { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The national_character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NationalCharacterSet is required")]
    [TerraformProperty("national_character_set")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NationalCharacterSet { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualNetworkId { get; set; }

    /// <summary>
    /// Block for long_term_backup_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LongTermBackupSchedule block(s) allowed")]
    [TerraformProperty("long_term_backup_schedule")]
    public TerraformList<TerraformBlock<AzurermOracleAutonomousDatabaseLongTermBackupScheduleBlock>>? LongTermBackupSchedule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseTimeoutsBlock>? Timeouts { get; set; }

}
