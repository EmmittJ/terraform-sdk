using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_data_source_reference.
/// </summary>
public class GoogleBackupDrDataSourceReferenceDataSource : TerraformDataSource
{
    public GoogleBackupDrDataSourceReferenceDataSource(string name) : base("google_backup_dr_data_source_reference", name)
    {
    }

    /// <summary>
    /// The `id` of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceReferenceId is required")]
    [TerraformPropertyName("data_source_reference_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataSourceReferenceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The state of the backup config for the data source.
    /// </summary>
    [TerraformPropertyName("backup_config_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupConfigState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_config_state");

    /// <summary>
    /// The number of backups for the data source.
    /// </summary>
    [TerraformPropertyName("backup_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BackupCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backup_count");

    /// <summary>
    /// The underlying data source resource.
    /// </summary>
    [TerraformPropertyName("data_source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataSource => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_source");

    /// <summary>
    /// The GCP resource name for the data source.
    /// </summary>
    [TerraformPropertyName("gcp_resource_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GcpResourceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gcp_resource_name");

    /// <summary>
    /// The state of the last backup.
    /// </summary>
    [TerraformPropertyName("last_backup_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastBackupState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_backup_state");

    /// <summary>
    /// The last time a successful backup was made.
    /// </summary>
    [TerraformPropertyName("last_successful_backup_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastSuccessfulBackupTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_successful_backup_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_type");

}
