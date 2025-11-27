using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_backup_dr_backup_plan Terraform data source.
/// Retrieves information about a google_backup_dr_backup_plan.
/// </summary>
public partial class GoogleBackupDrBackupPlanDataSource(string name) : TerraformDataSource("google_backup_dr_backup_plan", name)
{
    /// <summary>
    /// The ID of the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanId is required")]
    public required TerraformValue<string> BackupPlanId
    {
        get => new TerraformReference<string>(this, "backup_plan_id");
        set => SetArgument("backup_plan_id", value);
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
    /// The location for the backup plan
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
    /// The backup rules for this &#39;BackupPlan&#39;. There must be at least one &#39;BackupRule&#39; message.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackupRules
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backup_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    public TerraformValue<string> BackupVault
    {
        get => new TerraformReference<string>(this, "backup_vault");
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the BackupVault for taking backups.
    /// </summary>
    public TerraformValue<string> BackupVaultServiceAccount
    {
        get => new TerraformReference<string>(this, "backup_vault_service_account");
    }

    /// <summary>
    /// When the &#39;BackupPlan&#39; was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    public TerraformValue<double> LogRetentionDays
    {
        get => new TerraformReference<double>(this, "log_retention_days");
    }

    /// <summary>
    /// The name of backup plan resource created
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

    /// <summary>
    /// The list of all resource types to which the &#39;BackupPlan&#39; can be applied.
    /// </summary>
    public TerraformList<string> SupportedResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_resource_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// When the &#39;BackupPlan&#39; was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}
