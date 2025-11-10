using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup.
/// </summary>
public class GoogleBackupDrBackupDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupDataSource(string name) : base("google_backup_dr_backup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backups");
        SetOutput("create_time");
        SetOutput("name");
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
    /// List of all backups under data source.
    /// </summary>
    public TerraformExpression Backups => this["backups"];

    /// <summary>
    /// The time when the backup was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Name of resource
    /// </summary>
    public TerraformExpression Name => this["name"];

}
