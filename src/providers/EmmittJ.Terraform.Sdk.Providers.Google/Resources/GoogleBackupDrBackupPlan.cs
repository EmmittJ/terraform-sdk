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
        get => GetRequiredProperty<TerraformProperty<double>>("backup_retention_days");
        set => WithProperty("backup_retention_days", value);
    }

    /// <summary>
    /// The unique ID of this &#39;BackupRule&#39;. The &#39;rule_id&#39; is unique per &#39;BackupPlan&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformProperty<string> RuleId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule_id");
        set => WithProperty("rule_id", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("backup_vault_service_account");
        this.WithOutput("create_time");
        this.WithOutput("name");
        this.WithOutput("supported_resource_types");
        this.WithOutput("update_time");
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
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVault is required")]
    public required TerraformProperty<string> BackupVault
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backup_vault");
        set => this.WithProperty("backup_vault", value);
    }

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    public TerraformProperty<double>? LogRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("log_retention_days");
        set => this.WithProperty("log_retention_days", value);
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
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// Block for backup_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackupRules block(s) required")]
    public List<GoogleBackupDrBackupPlanBackupRulesBlock>? BackupRules
    {
        get => GetProperty<List<GoogleBackupDrBackupPlanBackupRulesBlock>>("backup_rules");
        set => this.WithProperty("backup_rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBackupDrBackupPlanTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBackupDrBackupPlanTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
