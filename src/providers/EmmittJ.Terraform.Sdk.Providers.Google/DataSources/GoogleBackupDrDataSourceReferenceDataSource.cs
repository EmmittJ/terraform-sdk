using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_data_source_reference.
/// </summary>
public partial class GoogleBackupDrDataSourceReferenceDataSource : TerraformDataSource
{
    public GoogleBackupDrDataSourceReferenceDataSource(string name) : base("google_backup_dr_data_source_reference", name)
    {
    }

    /// <summary>
    /// The `id` of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceReferenceId is required")]
    [TerraformProperty("data_source_reference_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataSourceReferenceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The state of the backup config for the data source.
    /// </summary>
    [TerraformProperty("backup_config_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupConfigState { get; }

    /// <summary>
    /// The number of backups for the data source.
    /// </summary>
    [TerraformProperty("backup_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> BackupCount { get; }

    /// <summary>
    /// The underlying data source resource.
    /// </summary>
    [TerraformProperty("data_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataSource { get; }

    /// <summary>
    /// The GCP resource name for the data source.
    /// </summary>
    [TerraformProperty("gcp_resource_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GcpResourceName { get; }

    /// <summary>
    /// The state of the last backup.
    /// </summary>
    [TerraformProperty("last_backup_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastBackupState { get; }

    /// <summary>
    /// The last time a successful backup was made.
    /// </summary>
    [TerraformProperty("last_successful_backup_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastSuccessfulBackupTime { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceType { get; }

}
