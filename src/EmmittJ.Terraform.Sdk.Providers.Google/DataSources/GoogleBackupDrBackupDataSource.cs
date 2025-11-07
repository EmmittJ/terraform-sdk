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
        this.DeclareOutput("backups");
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The backup_vault_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BackupVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_vault_id");
        set => this.WithProperty("backup_vault_id", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataSourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_id");
        set => this.WithProperty("data_source_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
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
