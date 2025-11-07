using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_backup_dr_backup_plan_association resource.
/// </summary>
public class GoogleBackupDrBackupPlanAssociation : TerraformResource
{
    public GoogleBackupDrBackupPlanAssociation(string name) : base("google_backup_dr_backup_plan_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("data_source");
        this.DeclareOutput("last_successful_backup_consistency_time");
        this.DeclareOutput("name");
        this.DeclareOutput("rules_config_info");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    public TerraformProperty<string>? BackupPlan
    {
        get => GetProperty<TerraformProperty<string>>("backup_plan");
        set => this.WithProperty("backup_plan", value);
    }

    /// <summary>
    /// The id of backupplan association
    /// </summary>
    public TerraformProperty<string>? BackupPlanAssociationId
    {
        get => GetProperty<TerraformProperty<string>>("backup_plan_association_id");
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
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
    /// The resource for which BPA needs to be created
    /// </summary>
    public TerraformProperty<string>? Resource
    {
        get => GetProperty<TerraformProperty<string>>("resource");
        set => this.WithProperty("resource", value);
    }

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

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
    /// Message for rules config info
    /// </summary>
    public TerraformExpression RulesConfigInfo => this["rules_config_info"];

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
