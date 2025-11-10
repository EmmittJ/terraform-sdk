using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_data_source.
/// </summary>
public class GoogleBackupDrDataSourceDataSource : TerraformDataSource
{
    public GoogleBackupDrDataSourceDataSource(string name) : base("google_backup_dr_data_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backup_config_info");
        SetOutput("backup_count");
        SetOutput("config_state");
        SetOutput("create_time");
        SetOutput("data_source_backup_appliance_application");
        SetOutput("data_source_gcp_resource");
        SetOutput("etag");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("state");
        SetOutput("total_stored_bytes");
        SetOutput("update_time");
        SetOutput("backup_vault_id");
        SetOutput("data_source_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The backup_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformProperty<string> BackupVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_vault_id");
        set => SetProperty("backup_vault_id", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformProperty<string> DataSourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_source_id");
        set => SetProperty("data_source_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Details of how the resource is configured for backup.
    /// </summary>
    public TerraformExpression BackupConfigInfo => this["backup_config_info"];

    /// <summary>
    /// Number of backups in the data source.
    /// </summary>
    public TerraformExpression BackupCount => this["backup_count"];

    /// <summary>
    /// The backup configuration state.
    /// </summary>
    public TerraformExpression ConfigState => this["config_state"];

    /// <summary>
    /// The time when the instance was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The backed up resource is a backup appliance application.
    /// </summary>
    public TerraformExpression DataSourceBackupApplianceApplication => this["data_source_backup_appliance_application"];

    /// <summary>
    /// The backed up resource is a Google Cloud resource.
    /// 			The word &#39;DataSource&#39; was included in the names to indicate that this is
    /// 			the representation of the Google Cloud resource used within the
    /// 			DataSource object.
    /// </summary>
    public TerraformExpression DataSourceGcpResource => this["data_source_gcp_resource"];

    /// <summary>
    /// Server specified ETag for the ManagementServer resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// Name of the datasource to create.
    /// 			It must have the format &amp;quot;projects/{project}/locations/{location}/backupVaults/{backupvault}/dataSources/{datasource}&amp;quot;.
    /// 			&#39;{datasource}&#39; cannot be changed after creation. It must be between 3-63 characters long and must be unique within the backup vault.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The DataSource resource instance state.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The number of bytes (metadata and data) stored in this datasource.
    /// </summary>
    public TerraformExpression TotalStoredBytes => this["total_stored_bytes"];

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
