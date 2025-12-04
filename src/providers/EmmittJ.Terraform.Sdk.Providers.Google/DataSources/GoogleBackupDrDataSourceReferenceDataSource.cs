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
        get => GetArgument<TerraformValue<string>>("data_source_reference_id");
        set => SetArgument("data_source_reference_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The state of the backup config for the data source.
    /// </summary>
    public TerraformValue<string> BackupConfigState
        => AsReference("backup_config_state");

    /// <summary>
    /// The number of backups for the data source.
    /// </summary>
    public TerraformValue<double> BackupCount
        => AsReference("backup_count");

    /// <summary>
    /// The underlying data source resource.
    /// </summary>
    public TerraformValue<string> DataSource
        => AsReference("data_source");

    /// <summary>
    /// The GCP resource name for the data source.
    /// </summary>
    public TerraformValue<string> GcpResourceName
        => AsReference("gcp_resource_name");

    /// <summary>
    /// The state of the last backup.
    /// </summary>
    public TerraformValue<string> LastBackupState
        => AsReference("last_backup_state");

    /// <summary>
    /// The last time a successful backup was made.
    /// </summary>
    public TerraformValue<string> LastSuccessfulBackupTime
        => AsReference("last_successful_backup_time");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
        => AsReference("resource_type");

}
