using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_data_source.
/// </summary>
public class GoogleBackupDrDataSourceDataSource : TerraformDataSource
{
    public GoogleBackupDrDataSourceDataSource(string name) : base("google_backup_dr_data_source", name)
    {
    }

    /// <summary>
    /// The backup_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    [TerraformPropertyName("backup_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BackupVaultId { get; set; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformPropertyName("data_source_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataSourceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Details of how the resource is configured for backup.
    /// </summary>
    [TerraformPropertyName("backup_config_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BackupConfigInfo => new TerraformReference(this, "backup_config_info");

    /// <summary>
    /// Number of backups in the data source.
    /// </summary>
    [TerraformPropertyName("backup_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupCount => new TerraformReference(this, "backup_count");

    /// <summary>
    /// The backup configuration state.
    /// </summary>
    [TerraformPropertyName("config_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigState => new TerraformReference(this, "config_state");

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The backed up resource is a backup appliance application.
    /// </summary>
    [TerraformPropertyName("data_source_backup_appliance_application")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataSourceBackupApplianceApplication => new TerraformReference(this, "data_source_backup_appliance_application");

    /// <summary>
    /// The backed up resource is a Google Cloud resource.
    /// 			The word &#39;DataSource&#39; was included in the names to indicate that this is
    /// 			the representation of the Google Cloud resource used within the
    /// 			DataSource object.
    /// </summary>
    [TerraformPropertyName("data_source_gcp_resource")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataSourceGcpResource => new TerraformReference(this, "data_source_gcp_resource");

    /// <summary>
    /// Server specified ETag for the ManagementServer resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// Name of the datasource to create.
    /// 			It must have the format &amp;quot;projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}&amp;quot;.
    /// 			&#39;{datasource}&#39; cannot be changed after creation. It must be between 3-63 characters long and must be unique within the backup vault.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The DataSource resource instance state.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The number of bytes (metadata and data) stored in this datasource.
    /// </summary>
    [TerraformPropertyName("total_stored_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TotalStoredBytes => new TerraformReference(this, "total_stored_bytes");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
