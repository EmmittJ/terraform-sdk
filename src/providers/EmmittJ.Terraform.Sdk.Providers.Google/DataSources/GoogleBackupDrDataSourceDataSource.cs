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
    public required TerraformProperty<TerraformProperty<string>> BackupVaultId { get; set; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformPropertyName("data_source_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataSourceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

    /// <summary>
    /// Details of how the resource is configured for backup.
    /// </summary>
    [TerraformPropertyName("backup_config_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BackupConfigInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backup_config_info");

    /// <summary>
    /// Number of backups in the data source.
    /// </summary>
    [TerraformPropertyName("backup_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupCount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_count");

    /// <summary>
    /// The backup configuration state.
    /// </summary>
    [TerraformPropertyName("config_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "config_state");

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The backed up resource is a backup appliance application.
    /// </summary>
    [TerraformPropertyName("data_source_backup_appliance_application")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataSourceBackupApplianceApplication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_source_backup_appliance_application");

    /// <summary>
    /// The backed up resource is a Google Cloud resource.
    /// 			The word &#39;DataSource&#39; was included in the names to indicate that this is
    /// 			the representation of the Google Cloud resource used within the
    /// 			DataSource object.
    /// </summary>
    [TerraformPropertyName("data_source_gcp_resource")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataSourceGcpResource => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_source_gcp_resource");

    /// <summary>
    /// Server specified ETag for the ManagementServer resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// Name of the datasource to create.
    /// 			It must have the format &amp;quot;projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}&amp;quot;.
    /// 			&#39;{datasource}&#39; cannot be changed after creation. It must be between 3-63 characters long and must be unique within the backup vault.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The DataSource resource instance state.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The number of bytes (metadata and data) stored in this datasource.
    /// </summary>
    [TerraformPropertyName("total_stored_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TotalStoredBytes => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "total_stored_bytes");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
