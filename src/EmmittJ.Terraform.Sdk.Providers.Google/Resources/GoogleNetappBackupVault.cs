using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_retention_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleNetappBackupVaultBackupRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Minimum retention duration in days for backups in the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupMinimumEnforcedRetentionDays is required")]
    public required TerraformProperty<double> BackupMinimumEnforcedRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_minimum_enforced_retention_days");
        set => WithProperty("backup_minimum_enforced_retention_days", value);
    }

    /// <summary>
    /// Indicates if the daily backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformProperty<bool>? DailyBackupImmutable
    {
        get => GetProperty<TerraformProperty<bool>>("daily_backup_immutable");
        set => WithProperty("daily_backup_immutable", value);
    }

    /// <summary>
    /// Indicates if the manual backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformProperty<bool>? ManualBackupImmutable
    {
        get => GetProperty<TerraformProperty<bool>>("manual_backup_immutable");
        set => WithProperty("manual_backup_immutable", value);
    }

    /// <summary>
    /// Indicates if the monthly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformProperty<bool>? MonthlyBackupImmutable
    {
        get => GetProperty<TerraformProperty<bool>>("monthly_backup_immutable");
        set => WithProperty("monthly_backup_immutable", value);
    }

    /// <summary>
    /// Indicates if the weekly backups are immutable. At least one of daily_backup_immutable, weekly_backup_immutable, monthly_backup_immutable and manual_backup_immutable must be true.
    /// </summary>
    public TerraformProperty<bool>? WeeklyBackupImmutable
    {
        get => GetProperty<TerraformProperty<bool>>("weekly_backup_immutable");
        set => WithProperty("weekly_backup_immutable", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupVaultTimeoutsBlock : TerraformBlock
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
/// Manages a google_netapp_backup_vault resource.
/// </summary>
public class GoogleNetappBackupVault : TerraformResource
{
    public GoogleNetappBackupVault(string name) : base("google_netapp_backup_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("destination_backup_vault");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("source_backup_vault");
        this.DeclareOutput("source_region");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    public TerraformProperty<string>? BackupRegion
    {
        get => GetProperty<TerraformProperty<string>>("backup_region");
        set => this.WithProperty("backup_region", value);
    }

    /// <summary>
    /// Type of the backup vault to be created. Default is IN_REGION. Possible values: [&amp;quot;BACKUP_VAULT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;IN_REGION&amp;quot;, &amp;quot;CROSS_REGION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? BackupVaultType
    {
        get => GetProperty<TerraformProperty<string>>("backup_vault_type");
        set => this.WithProperty("backup_vault_type", value);
    }

    /// <summary>
    /// An optional description of this resource.
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Location (region) of the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the backup vault. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for backup_retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupRetentionPolicy block(s) allowed")]
    public List<GoogleNetappBackupVaultBackupRetentionPolicyBlock>? BackupRetentionPolicy
    {
        get => GetProperty<List<GoogleNetappBackupVaultBackupRetentionPolicyBlock>>("backup_retention_policy");
        set => this.WithProperty("backup_retention_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetappBackupVaultTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetappBackupVaultTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Create time of the backup vault. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Name of the Backup vault created in backup region.
    /// </summary>
    public TerraformExpression DestinationBackupVault => this["destination_backup_vault"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Name of the Backup vault created in source region.
    /// </summary>
    public TerraformExpression SourceBackupVault => this["source_backup_vault"];

    /// <summary>
    /// Region in which the backup vault is created.
    /// </summary>
    public TerraformExpression SourceRegion => this["source_region"];

    /// <summary>
    /// The state of the Backup Vault.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
