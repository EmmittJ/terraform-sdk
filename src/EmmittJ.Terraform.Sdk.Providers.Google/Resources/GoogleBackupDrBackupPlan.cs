using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_backup_dr_backup_plan resource.
/// </summary>
public class GoogleBackupDrBackupPlan : TerraformResource
{
    public GoogleBackupDrBackupPlan(string name) : base("google_backup_dr_backup_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_vault_service_account");
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("supported_resource_types");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID of the backup plan
    /// </summary>
    public TerraformLiteralProperty<string>? BackupPlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_plan_id");
        set => this.WithProperty("backup_plan_id", value);
    }

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    public TerraformLiteralProperty<string>? BackupVault
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_vault");
        set => this.WithProperty("backup_vault", value);
    }

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location for the backup plan
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    public TerraformLiteralProperty<double>? LogRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("log_retention_days");
        set => this.WithProperty("log_retention_days", value);
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
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the BackupVault for taking backups.
    /// </summary>
    public TerraformExpression BackupVaultServiceAccount => this["backup_vault_service_account"];

    /// <summary>
    /// When the &#39;BackupPlan&#39; was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The name of backup plan resource created
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The list of all resource types to which the &#39;BackupPlan&#39; can be applied.
    /// </summary>
    public TerraformExpression SupportedResourceTypes => this["supported_resource_types"];

    /// <summary>
    /// When the &#39;BackupPlan&#39; was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
