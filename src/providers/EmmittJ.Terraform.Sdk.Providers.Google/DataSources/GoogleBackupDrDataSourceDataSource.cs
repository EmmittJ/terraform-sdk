using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_backup_dr_data_source Terraform data source.
/// Retrieves information about a google_backup_dr_data_source.
/// </summary>
public partial class GoogleBackupDrDataSourceDataSource(string name) : TerraformDataSource("google_backup_dr_data_source", name)
{
    /// <summary>
    /// The backup_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformValue<string> BackupVaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_vault_id");
        set => SetArgument("backup_vault_id", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformValue<string> DataSourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_source_id");
        set => SetArgument("data_source_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Details of how the resource is configured for backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackupConfigInfo
        => CreateReference("backup_config_info");

    /// <summary>
    /// Number of backups in the data source.
    /// </summary>
    public TerraformValue<string> BackupCount
        => CreateReference("backup_count");

    /// <summary>
    /// The backup configuration state.
    /// </summary>
    public TerraformValue<string> ConfigState
        => CreateReference("config_state");

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The backed up resource is a backup appliance application.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataSourceBackupApplianceApplication
        => CreateReference("data_source_backup_appliance_application");

    /// <summary>
    /// The backed up resource is a Google Cloud resource.
    /// 			The word &#39;DataSource&#39; was included in the names to indicate that this is
    /// 			the representation of the Google Cloud resource used within the
    /// 			DataSource object.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataSourceGcpResource
        => CreateReference("data_source_gcp_resource");

    /// <summary>
    /// Server specified ETag for the ManagementServer resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// </summary>
    public TerraformMap<string> Labels
        => CreateReference("labels");

    /// <summary>
    /// Name of the datasource to create.
    /// 			It must have the format &amp;quot;projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}&amp;quot;.
    /// 			&#39;{datasource}&#39; cannot be changed after creation. It must be between 3-63 characters long and must be unique within the backup vault.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The DataSource resource instance state.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The number of bytes (metadata and data) stored in this datasource.
    /// </summary>
    public TerraformValue<string> TotalStoredBytes
        => CreateReference("total_stored_bytes");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

}
