using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_plan_association.
/// </summary>
public class GoogleBackupDrBackupPlanAssociationDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupPlanAssociationDataSource(string name) : base("google_backup_dr_backup_plan_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("backup_plan");
        this.WithOutput("create_time");
        this.WithOutput("data_source");
        this.WithOutput("last_successful_backup_consistency_time");
        this.WithOutput("name");
        this.WithOutput("resource");
        this.WithOutput("resource_type");
        this.WithOutput("rules_config_info");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The id of backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanAssociationId is required")]
    public required TerraformProperty<string> BackupPlanAssociationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backup_plan_association_id");
        set => this.WithProperty("backup_plan_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location for the backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    public TerraformExpression BackupPlan => this["backup_plan"];

    /// <summary>
    /// The time when the instance was created
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Resource name of data source which will be used as storage location for backups taken
    /// </summary>
    public TerraformExpression DataSource => this["data_source"];

    /// <summary>
    /// The point in time when the last successful backup was captured from the source
    /// </summary>
    public TerraformExpression LastSuccessfulBackupConsistencyTime => this["last_successful_backup_consistency_time"];

    /// <summary>
    /// The name of backup plan association resource created
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource for which BPA needs to be created
    /// </summary>
    public TerraformExpression Resource => this["resource"];

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// Message for rules config info
    /// </summary>
    public TerraformExpression RulesConfigInfo => this["rules_config_info"];

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
