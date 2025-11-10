using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_plan.
/// </summary>
public class GoogleBackupDrBackupPlanDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupPlanDataSource(string name) : base("google_backup_dr_backup_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_rules");
        this.DeclareOutput("backup_vault");
        this.DeclareOutput("backup_vault_service_account");
        this.DeclareOutput("create_time");
        this.DeclareOutput("description");
        this.DeclareOutput("log_retention_days");
        this.DeclareOutput("name");
        this.DeclareOutput("resource_type");
        this.DeclareOutput("supported_resource_types");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID of the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanId is required")]
    public required TerraformProperty<string> BackupPlanId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backup_plan_id");
        set => this.WithProperty("backup_plan_id", value);
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
    /// The location for the backup plan
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
    /// The backup rules for this &#39;BackupPlan&#39;. There must be at least one &#39;BackupRule&#39; message.
    /// </summary>
    public TerraformExpression BackupRules => this["backup_rules"];

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    public TerraformExpression BackupVault => this["backup_vault"];

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the BackupVault for taking backups.
    /// </summary>
    public TerraformExpression BackupVaultServiceAccount => this["backup_vault_service_account"];

    /// <summary>
    /// When the &#39;BackupPlan&#39; was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    public TerraformExpression LogRetentionDays => this["log_retention_days"];

    /// <summary>
    /// The name of backup plan resource created
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// The list of all resource types to which the &#39;BackupPlan&#39; can be applied.
    /// </summary>
    public TerraformExpression SupportedResourceTypes => this["supported_resource_types"];

    /// <summary>
    /// When the &#39;BackupPlan&#39; was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
