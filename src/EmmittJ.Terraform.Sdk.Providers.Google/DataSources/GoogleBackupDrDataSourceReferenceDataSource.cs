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
        this.DeclareOutput("backup_config_state");
        this.DeclareOutput("backup_count");
        this.DeclareOutput("data_source");
        this.DeclareOutput("gcp_resource_name");
        this.DeclareOutput("last_backup_state");
        this.DeclareOutput("last_successful_backup_time");
        this.DeclareOutput("name");
        this.DeclareOutput("resource_type");
    }

    /// <summary>
    /// The `id` of the data source reference.
    /// </summary>
    public TerraformLiteralProperty<string>? DataSourceReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_reference_id");
        set => this.WithProperty("data_source_reference_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location of the data source reference.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
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
