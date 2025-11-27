using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_backup_dr_backup_plan_association Terraform data source.
/// Retrieves information about a google_backup_dr_backup_plan_association.
/// </summary>
public partial class GoogleBackupDrBackupPlanAssociationDataSource(string name) : TerraformDataSource("google_backup_dr_backup_plan_association", name)
{
    /// <summary>
    /// The id of backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanAssociationId is required")]
    public required TerraformValue<string> BackupPlanAssociationId
    {
        get => new TerraformReference<string>(this, "backup_plan_association_id");
        set => SetArgument("backup_plan_association_id", value);
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
    /// The location for the backupplan association
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
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    public TerraformValue<string> BackupPlan
    {
        get => new TerraformReference<string>(this, "backup_plan");
    }

    /// <summary>
    /// The time when the instance was created
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Resource name of data source which will be used as storage location for backups taken
    /// </summary>
    public TerraformValue<string> DataSource
    {
        get => new TerraformReference<string>(this, "data_source");
    }

    /// <summary>
    /// The point in time when the last successful backup was captured from the source
    /// </summary>
    public TerraformValue<string> LastSuccessfulBackupConsistencyTime
    {
        get => new TerraformReference<string>(this, "last_successful_backup_consistency_time");
    }

    /// <summary>
    /// The name of backup plan association resource created
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The resource for which BPA needs to be created
    /// </summary>
    public TerraformValue<string> Resource
    {
        get => new TerraformReference<string>(this, "resource");
    }

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

    /// <summary>
    /// Message for rules config info
    /// </summary>
    public TerraformList<TerraformMap<object>> RulesConfigInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "rules_config_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}
