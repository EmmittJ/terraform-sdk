using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBackupDrBackupPlanAssociation.
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrBackupPlanAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_backup_dr_backup_plan_association Terraform resource.
/// Manages a google_backup_dr_backup_plan_association resource.
/// </summary>
public partial class GoogleBackupDrBackupPlanAssociation(string name) : TerraformResource("google_backup_dr_backup_plan_association", name)
{
    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlan is required")]
    public required TerraformValue<string> BackupPlan
    {
        get => GetArgument<TerraformValue<string>>("backup_plan");
        set => SetArgument("backup_plan", value);
    }

    /// <summary>
    /// The id of backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanAssociationId is required")]
    public required TerraformValue<string> BackupPlanAssociationId
    {
        get => GetArgument<TerraformValue<string>>("backup_plan_association_id");
        set => SetArgument("backup_plan_association_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
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
    /// The resource for which BPA needs to be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

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
    /// Message for rules config info
    /// </summary>
    public TerraformList<TerraformMap<object>> RulesConfigInfo
        => AsReference("rules_config_info");

    /// <summary>
    /// The time when the instance was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBackupDrBackupPlanAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBackupDrBackupPlanAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
