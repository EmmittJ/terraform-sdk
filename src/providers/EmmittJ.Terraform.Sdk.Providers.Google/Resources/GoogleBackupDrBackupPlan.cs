using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_rules in .
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrBackupPlanBackupRulesBlock : TerraformBlock
{
    /// <summary>
    /// Configures the duration for which backup data will be kept. The value should be greater than or equal to minimum enforced retention of the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRetentionDays is required")]
    public required TerraformProperty<double> BackupRetentionDays
    {
        set => SetProperty("backup_retention_days", value);
    }

    /// <summary>
    /// The unique ID of this &#39;BackupRule&#39;. The &#39;rule_id&#39; is unique per &#39;BackupPlan&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformProperty<string> RuleId
    {
        set => SetProperty("rule_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrBackupPlanTimeoutsBlock : TerraformBlock
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
/// Manages a google_backup_dr_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBackupDrBackupPlan : TerraformResource
{
    public GoogleBackupDrBackupPlan(string name) : base("google_backup_dr_backup_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backup_vault_service_account");
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("supported_resource_types");
        SetOutput("update_time");
        SetOutput("backup_plan_id");
        SetOutput("backup_vault");
        SetOutput("description");
        SetOutput("id");
        SetOutput("location");
        SetOutput("log_retention_days");
        SetOutput("project");
        SetOutput("resource_type");
    }

    /// <summary>
    /// The ID of the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanId is required")]
    public required TerraformProperty<string> BackupPlanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_plan_id");
        set => SetProperty("backup_plan_id", value);
    }

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVault is required")]
    public required TerraformProperty<string> BackupVault
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_vault");
        set => SetProperty("backup_vault", value);
    }

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The location for the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    public TerraformProperty<double> LogRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("log_retention_days");
        set => SetProperty("log_retention_days", value);
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
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// Block for backup_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackupRules block(s) required")]
    public List<GoogleBackupDrBackupPlanBackupRulesBlock>? BackupRules
    {
        set => SetProperty("backup_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBackupDrBackupPlanTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
