using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_backup_dr_backup_vault resource.
/// </summary>
public class GoogleBackupDrBackupVault : TerraformResource
{
    public GoogleBackupDrBackupVault(string name) : base("google_backup_dr_backup_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_count");
        this.DeclareOutput("create_time");
        this.DeclareOutput("deletable");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("service_account");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("total_stored_bytes");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Access restriction for the backup vault. Default value is &#39;WITHIN_ORGANIZATION&#39; if not provided during creation. Default value: &amp;quot;WITHIN_ORGANIZATION&amp;quot; Possible values: [&amp;quot;ACCESS_RESTRICTION_UNSPECIFIED&amp;quot;, &amp;quot;WITHIN_PROJECT&amp;quot;, &amp;quot;WITHIN_ORGANIZATION&amp;quot;, &amp;quot;UNRESTRICTED&amp;quot;, &amp;quot;WITHIN_ORG_BUT_UNRESTRICTED_FOR_BA&amp;quot;]
    /// </summary>
    public string? AccessRestriction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_restriction")?.Value;
        set => this.WithProperty("access_restriction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Allow idempotent deletion of backup vault. The request will still succeed in case the backup vault does not exist.
    /// </summary>
    public bool? AllowMissing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_missing")?.Value;
        set => this.WithProperty("allow_missing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Optional. User annotations. See https://google.aip.dev/128#annotations
    /// Stores small amounts of arbitrary data. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Required. The default and minimum enforced retention for each backup within the backup vault. The enforced retention for each backup can be extended.
    /// </summary>
    public string? BackupMinimumEnforcedRetentionDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_minimum_enforced_retention_duration")?.Value;
        set => this.WithProperty("backup_minimum_enforced_retention_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// How a backup&#39;s enforced retention end time is inherited. Default value is &#39;INHERIT_VAULT_RETENTION&#39; if not provided during creation. Possible values: [&amp;quot;BACKUP_RETENTION_INHERITANCE_UNSPECIFIED&amp;quot;, &amp;quot;INHERIT_VAULT_RETENTION&amp;quot;, &amp;quot;MATCH_BACKUP_EXPIRE_TIME&amp;quot;]
    /// </summary>
    public string? BackupRetentionInheritance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_retention_inheritance")?.Value;
        set => this.WithProperty("backup_retention_inheritance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Required. ID of the requesting object.
    /// </summary>
    public string? BackupVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_vault_id")?.Value;
        set => this.WithProperty("backup_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. The description of the BackupVault instance (2048 characters or less).
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Time after which the BackupVault resource is locked.
    /// </summary>
    public string? EffectiveTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("effective_time")?.Value;
        set => this.WithProperty("effective_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? ForceDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_delete")?.Value;
        set => this.WithProperty("force_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// If set, allow update to extend the minimum enforced retention for backup vault. This overrides
    ///  the restriction against conflicting retention periods. This conflict may occur when the
    ///  expiration schedule defined by the associated backup plan is shorter than the minimum
    ///  retention set by the backup vault.
    /// </summary>
    public bool? ForceUpdate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_update")?.Value;
        set => this.WithProperty("force_update", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    public bool? IgnoreBackupPlanReferences
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_backup_plan_references")?.Value;
        set => this.WithProperty("ignore_backup_plan_references", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    /// </summary>
    public bool? IgnoreInactiveDatasources
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_inactive_datasources")?.Value;
        set => this.WithProperty("ignore_inactive_datasources", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Optional. Resource labels to represent user provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The GCP location for the backup vault.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. The number of backups in this backup vault.
    /// </summary>
    public TerraformExpression BackupCount => this["backup_count"];

    /// <summary>
    /// Output only. The time when the instance was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Set to true when there are no backups nested under this resource.
    /// </summary>
    public TerraformExpression Deletable => this["deletable"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Optional. Server specified ETag for the backup vault resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. Identifier. The resource name.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Service account used by the BackupVault Service for this BackupVault.  The user should grant this account permissions in their workload project to enable the service to run backups and restores there.
    /// </summary>
    public TerraformExpression ServiceAccount => this["service_account"];

    /// <summary>
    /// Output only. The BackupVault resource instance state. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    ///  CREATING
    ///  ACTIVE
    ///  DELETING
    ///  ERROR
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. Total size of the storage used by all backup resources.
    /// </summary>
    public TerraformExpression TotalStoredBytes => this["total_stored_bytes"];

    /// <summary>
    /// Output only. Output only Immutable after resource creation until resource deletion.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the instance was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
