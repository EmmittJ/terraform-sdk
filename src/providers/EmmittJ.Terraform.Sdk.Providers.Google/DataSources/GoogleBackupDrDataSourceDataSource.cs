using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_data_source.
/// </summary>
public partial class GoogleBackupDrDataSourceDataSource : TerraformDataSource
{
    public GoogleBackupDrDataSourceDataSource(string name) : base("google_backup_dr_data_source", name)
    {
    }

    /// <summary>
    /// The backup_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    [TerraformProperty("backup_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupVaultId { get; set; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformProperty("data_source_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataSourceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Details of how the resource is configured for backup.
    /// </summary>
    [TerraformProperty("backup_config_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BackupConfigInfo { get; }

    /// <summary>
    /// Number of backups in the data source.
    /// </summary>
    [TerraformProperty("backup_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupCount { get; }

    /// <summary>
    /// The backup configuration state.
    /// </summary>
    [TerraformProperty("config_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigState { get; }

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The backed up resource is a backup appliance application.
    /// </summary>
    [TerraformProperty("data_source_backup_appliance_application")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataSourceBackupApplianceApplication { get; }

    /// <summary>
    /// The backed up resource is a Google Cloud resource.
    /// 			The word &#39;DataSource&#39; was included in the names to indicate that this is
    /// 			the representation of the Google Cloud resource used within the
    /// 			DataSource object.
    /// </summary>
    [TerraformProperty("data_source_gcp_resource")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataSourceGcpResource { get; }

    /// <summary>
    /// Server specified ETag for the ManagementServer resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// Name of the datasource to create.
    /// 			It must have the format &amp;quot;projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}&amp;quot;.
    /// 			&#39;{datasource}&#39; cannot be changed after creation. It must be between 3-63 characters long and must be unique within the backup vault.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The DataSource resource instance state.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The number of bytes (metadata and data) stored in this datasource.
    /// </summary>
    [TerraformProperty("total_stored_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TotalStoredBytes { get; }

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
