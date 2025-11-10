using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_backup_dr_backup_vault.
/// </summary>
public class GoogleBackupDrBackupVaultDataSource : TerraformDataSource
{
    public GoogleBackupDrBackupVaultDataSource(string name) : base("google_backup_dr_backup_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_restriction");
        this.WithOutput("allow_missing");
        this.WithOutput("annotations");
        this.WithOutput("backup_count");
        this.WithOutput("backup_minimum_enforced_retention_duration");
        this.WithOutput("backup_retention_inheritance");
        this.WithOutput("create_time");
        this.WithOutput("deletable");
        this.WithOutput("description");
        this.WithOutput("effective_annotations");
        this.WithOutput("effective_labels");
        this.WithOutput("effective_time");
        this.WithOutput("etag");
        this.WithOutput("force_delete");
        this.WithOutput("force_update");
        this.WithOutput("ignore_backup_plan_references");
        this.WithOutput("ignore_inactive_datasources");
        this.WithOutput("labels");
        this.WithOutput("name");
        this.WithOutput("service_account");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
        this.WithOutput("total_stored_bytes");
        this.WithOutput("uid");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// Required. ID of the requesting object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformProperty<string> BackupVaultId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("backup_vault_id");
        set => this.WithProperty("backup_vault_id", value);
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
    /// The GCP location for the backup vault.
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
    /// Access restriction for the backup vault. Default value is &#39;WITHIN_ORGANIZATION&#39; if not provided during creation. Default value: &amp;quot;WITHIN_ORGANIZATION&amp;quot; Possible values: [&amp;quot;ACCESS_RESTRICTION_UNSPECIFIED&amp;quot;, &amp;quot;WITHIN_PROJECT&amp;quot;, &amp;quot;WITHIN_ORGANIZATION&amp;quot;, &amp;quot;UNRESTRICTED&amp;quot;, &amp;quot;WITHIN_ORG_BUT_UNRESTRICTED_FOR_BA&amp;quot;]
    /// </summary>
    public TerraformExpression AccessRestriction => this["access_restriction"];

    /// <summary>
    /// Allow idempotent deletion of backup vault. The request will still succeed in case the backup vault does not exist.
    /// </summary>
    public TerraformExpression AllowMissing => this["allow_missing"];

    /// <summary>
    /// Optional. User annotations. See https://google.aip.dev/128#annotations
    /// Stores small amounts of arbitrary data. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformExpression Annotations => this["annotations"];

    /// <summary>
    /// Output only. The number of backups in this backup vault.
    /// </summary>
    public TerraformExpression BackupCount => this["backup_count"];

    /// <summary>
    /// Required. The default and minimum enforced retention for each backup within the backup vault. The enforced retention for each backup can be extended.
    /// </summary>
    public TerraformExpression BackupMinimumEnforcedRetentionDuration => this["backup_minimum_enforced_retention_duration"];

    /// <summary>
    /// How a backup&#39;s enforced retention end time is inherited. Default value is &#39;INHERIT_VAULT_RETENTION&#39; if not provided during creation. Possible values: [&amp;quot;BACKUP_RETENTION_INHERITANCE_UNSPECIFIED&amp;quot;, &amp;quot;INHERIT_VAULT_RETENTION&amp;quot;, &amp;quot;MATCH_BACKUP_EXPIRE_TIME&amp;quot;]
    /// </summary>
    public TerraformExpression BackupRetentionInheritance => this["backup_retention_inheritance"];

    /// <summary>
    /// Output only. The time when the instance was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Set to true when there are no backups nested under this resource.
    /// </summary>
    public TerraformExpression Deletable => this["deletable"];

    /// <summary>
    /// Optional. The description of the BackupVault instance (2048 characters or less).
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Optional. Time after which the BackupVault resource is locked.
    /// </summary>
    public TerraformExpression EffectiveTime => this["effective_time"];

    /// <summary>
    /// Optional. Server specified ETag for the backup vault resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    public TerraformExpression ForceDelete => this["force_delete"];

    /// <summary>
    /// If set, allow update to extend the minimum enforced retention for backup vault. This overrides
    ///  the restriction against conflicting retention periods. This conflict may occur when the
    ///  expiration schedule defined by the associated backup plan is shorter than the minimum
    ///  retention set by the backup vault.
    /// </summary>
    public TerraformExpression ForceUpdate => this["force_update"];

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    public TerraformExpression IgnoreBackupPlanReferences => this["ignore_backup_plan_references"];

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    /// </summary>
    public TerraformExpression IgnoreInactiveDatasources => this["ignore_inactive_datasources"];

    /// <summary>
    /// Optional. Resource labels to represent user provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

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
