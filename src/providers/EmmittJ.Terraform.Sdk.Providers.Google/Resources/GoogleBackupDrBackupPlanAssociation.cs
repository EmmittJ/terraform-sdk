using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrBackupPlanAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("create_time");
        SetOutput("data_source");
        SetOutput("last_successful_backup_consistency_time");
        SetOutput("name");
        SetOutput("rules_config_info");
        SetOutput("update_time");
        SetOutput("backup_plan");
        SetOutput("backup_plan_association_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("resource");
        SetOutput("resource_type");
    }

    /// <summary>
    /// The BP with which resource needs to be created
    /// Note:
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Instance&#39;, can only protect instance type resources.
    /// - A Backup Plan configured for &#39;compute.googleapis.com/Disk&#39; can be used to protect both standard Disks and Regional Disks resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlan is required")]
    public required TerraformProperty<string> BackupPlan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_plan");
        set => SetProperty("backup_plan", value);
    }

    /// <summary>
    /// The id of backupplan association
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanAssociationId is required")]
    public required TerraformProperty<string> BackupPlanAssociationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_plan_association_id");
        set => SetProperty("backup_plan_association_id", value);
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
    /// The location for the backupplan association
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
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The resource for which BPA needs to be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformProperty<string> Resource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource");
        set => SetProperty("resource", value);
    }

    /// <summary>
    /// The resource type of workload on which backupplan is applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, and &amp;quot;compute.googleapis.com/RegionDisk&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBackupDrBackupPlanAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
