using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleAutonomousDatabaseCloneFromBackupTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_oracle_autonomous_database_clone_from_backup resource.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseCloneFromBackup : TerraformResource
{
    public AzurermOracleAutonomousDatabaseCloneFromBackup(string name) : base("azurerm_oracle_autonomous_database_clone_from_backup", name)
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
    /// The allowed_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("allowed_ip_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowedIpAddresses { get; set; }

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
    /// The backup_timestamp attribute.
    /// </summary>
    [TerraformProperty("backup_timestamp")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BackupTimestamp { get; set; }

    /// <summary>
    /// The character_set attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CharacterSet is required")]
    [TerraformProperty("character_set")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CharacterSet { get; set; }

    /// <summary>
    /// The clone_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloneType is required")]
    [TerraformProperty("clone_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CloneType { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? CustomerContacts { get; set; }

    /// <summary>
    /// The data_storage_size_in_tb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTb is required")]
    [TerraformProperty("data_storage_size_in_tb")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> DataStorageSizeInTb { get; set; }

    /// <summary>
    /// The database_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseVersion is required")]
    [TerraformProperty("database_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseVersion { get; set; }

    /// <summary>
    /// The database_workload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseWorkload is required")]
    [TerraformProperty("database_workload")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseWorkload { get; set; }

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
    /// The source_autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAutonomousDatabaseId is required")]
    [TerraformProperty("source_autonomous_database_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceAutonomousDatabaseId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseCloneFromBackupTimeoutsBlock>? Timeouts { get; set; }

}
