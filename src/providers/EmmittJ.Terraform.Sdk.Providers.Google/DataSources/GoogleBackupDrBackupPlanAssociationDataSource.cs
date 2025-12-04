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
        get => GetRequiredArgument<TerraformValue<string>>("backup_plan_association_id");
        set => SetArgument("backup_plan_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the backupplan association
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
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    public TerraformValue<string> BackupPlan
        => AsReference("backup_plan");

    /// <summary>
    /// The time when the instance was created
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Resource name of data source which will be used as storage location for backups taken
    /// </summary>
    public TerraformValue<string> DataSource
        => AsReference("data_source");

    /// <summary>
    /// The point in time when the last successful backup was captured from the source
    /// </summary>
    public TerraformValue<string> LastSuccessfulBackupConsistencyTime
        => AsReference("last_successful_backup_consistency_time");

    /// <summary>
    /// The name of backup plan association resource created
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The resource for which BPA needs to be created
    /// </summary>
    public TerraformValue<string> Resource
        => AsReference("resource");

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
        => AsReference("resource_type");

    /// <summary>
    /// Message for rules config info
    /// </summary>
    public TerraformList<TerraformMap<object>> RulesConfigInfo
        => AsReference("rules_config_info");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
