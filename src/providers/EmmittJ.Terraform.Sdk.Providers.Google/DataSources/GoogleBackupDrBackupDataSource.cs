using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_backup_dr_backup Terraform data source.
/// Retrieves information about a google_backup_dr_backup.
/// </summary>
public partial class GoogleBackupDrBackupDataSource(string name) : TerraformDataSource("google_backup_dr_backup", name)
{
    /// <summary>
    /// The backup_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformValue<string> BackupVaultId
    {
        get => new TerraformReference<string>(this, "backup_vault_id");
        set => SetArgument("backup_vault_id", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformValue<string> DataSourceId
    {
        get => new TerraformReference<string>(this, "data_source_id");
        set => SetArgument("data_source_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// List of all backups under data source.
    /// </summary>
    public TerraformList<TerraformMap<object>> Backups
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time when the backup was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Name of resource
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
