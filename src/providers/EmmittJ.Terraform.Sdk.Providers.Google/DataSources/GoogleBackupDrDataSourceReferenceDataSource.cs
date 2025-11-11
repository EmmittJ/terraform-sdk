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
    public required TerraformValue<string> DataSourceReferenceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The state of the backup config for the data source.
    /// </summary>
    [TerraformPropertyName("backup_config_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupConfigState => new TerraformReference(this, "backup_config_state");

    /// <summary>
    /// The number of backups for the data source.
    /// </summary>
    [TerraformPropertyName("backup_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BackupCount => new TerraformReference(this, "backup_count");

    /// <summary>
    /// The underlying data source resource.
    /// </summary>
    [TerraformPropertyName("data_source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataSource => new TerraformReference(this, "data_source");

    /// <summary>
    /// The GCP resource name for the data source.
    /// </summary>
    [TerraformPropertyName("gcp_resource_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GcpResourceName => new TerraformReference(this, "gcp_resource_name");

    /// <summary>
    /// The state of the last backup.
    /// </summary>
    [TerraformPropertyName("last_backup_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastBackupState => new TerraformReference(this, "last_backup_state");

    /// <summary>
    /// The last time a successful backup was made.
    /// </summary>
    [TerraformPropertyName("last_successful_backup_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastSuccessfulBackupTime => new TerraformReference(this, "last_successful_backup_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceType => new TerraformReference(this, "resource_type");

}
