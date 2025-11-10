using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_data_source_reference.
/// </summary>
public class GoogleBackupDrDataSourceReferenceDataSource : TerraformDataSource
{
    public GoogleBackupDrDataSourceReferenceDataSource(string name) : base("google_backup_dr_data_source_reference", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backup_config_state");
        SetOutput("backup_count");
        SetOutput("data_source");
        SetOutput("gcp_resource_name");
        SetOutput("last_backup_state");
        SetOutput("last_successful_backup_time");
        SetOutput("name");
        SetOutput("resource_type");
        SetOutput("data_source_reference_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The `id` of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceReferenceId is required")]
    public required TerraformProperty<string> DataSourceReferenceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_source_reference_id");
        set => SetProperty("data_source_reference_id", value);
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
    /// The location of the data source reference.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The state of the backup config for the data source.
    /// </summary>
    public TerraformExpression BackupConfigState => this["backup_config_state"];

    /// <summary>
    /// The number of backups for the data source.
    /// </summary>
    public TerraformExpression BackupCount => this["backup_count"];

    /// <summary>
    /// The underlying data source resource.
    /// </summary>
    public TerraformExpression DataSource => this["data_source"];

    /// <summary>
    /// The GCP resource name for the data source.
    /// </summary>
    public TerraformExpression GcpResourceName => this["gcp_resource_name"];

    /// <summary>
    /// The state of the last backup.
    /// </summary>
    public TerraformExpression LastBackupState => this["last_backup_state"];

    /// <summary>
    /// The last time a successful backup was made.
    /// </summary>
    public TerraformExpression LastSuccessfulBackupTime => this["last_successful_backup_time"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

}
