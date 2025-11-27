using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_backup_dr_data_source_reference Terraform data source.
/// Retrieves information about a google_backup_dr_data_source_reference.
/// </summary>
public partial class GoogleBackupDrDataSourceReferenceDataSource(string name) : TerraformDataSource("google_backup_dr_data_source_reference", name)
{
    /// <summary>
    /// The `id` of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceReferenceId is required")]
    public required TerraformValue<string> DataSourceReferenceId
    {
        get => new TerraformReference<string>(this, "data_source_reference_id");
        set => SetArgument("data_source_reference_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The state of the backup config for the data source.
    /// </summary>
    public TerraformValue<string> BackupConfigState
    {
        get => new TerraformReference<string>(this, "backup_config_state");
    }

    /// <summary>
    /// The number of backups for the data source.
    /// </summary>
    public TerraformValue<double> BackupCount
    {
        get => new TerraformReference<double>(this, "backup_count");
    }

    /// <summary>
    /// The underlying data source resource.
    /// </summary>
    public TerraformValue<string> DataSource
    {
        get => new TerraformReference<string>(this, "data_source");
    }

    /// <summary>
    /// The GCP resource name for the data source.
    /// </summary>
    public TerraformValue<string> GcpResourceName
    {
        get => new TerraformReference<string>(this, "gcp_resource_name");
    }

    /// <summary>
    /// The state of the last backup.
    /// </summary>
    public TerraformValue<string> LastBackupState
    {
        get => new TerraformReference<string>(this, "last_backup_state");
    }

    /// <summary>
    /// The last time a successful backup was made.
    /// </summary>
    public TerraformValue<string> LastSuccessfulBackupTime
    {
        get => new TerraformReference<string>(this, "last_successful_backup_time");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

}
