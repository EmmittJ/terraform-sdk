using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBackupDrBackupVault.
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrBackupVaultTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_backup_dr_backup_vault Terraform resource.
/// Manages a google_backup_dr_backup_vault resource.
/// </summary>
public partial class GoogleBackupDrBackupVault(string name) : TerraformResource("google_backup_dr_backup_vault", name)
{
    /// <summary>
    /// Access restriction for the backup vault. Default value is &#39;WITHIN_ORGANIZATION&#39; if not provided during creation. Default value: &amp;quot;WITHIN_ORGANIZATION&amp;quot; Possible values: [&amp;quot;ACCESS_RESTRICTION_UNSPECIFIED&amp;quot;, &amp;quot;WITHIN_PROJECT&amp;quot;, &amp;quot;WITHIN_ORGANIZATION&amp;quot;, &amp;quot;UNRESTRICTED&amp;quot;, &amp;quot;WITHIN_ORG_BUT_UNRESTRICTED_FOR_BA&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AccessRestriction
    {
        get => new TerraformReference<string>(this, "access_restriction");
        set => SetArgument("access_restriction", value);
    }

    /// <summary>
    /// Allow idempotent deletion of backup vault. The request will still succeed in case the backup vault does not exist.
    /// </summary>
    public TerraformValue<bool>? AllowMissing
    {
        get => new TerraformReference<bool>(this, "allow_missing");
        set => SetArgument("allow_missing", value);
    }

    /// <summary>
    /// Optional. User annotations. See https://google.aip.dev/128#annotations
    /// Stores small amounts of arbitrary data. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Required. The default and minimum enforced retention for each backup within the backup vault. The enforced retention for each backup can be extended.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupMinimumEnforcedRetentionDuration is required")]
    public required TerraformValue<string> BackupMinimumEnforcedRetentionDuration
    {
        get => new TerraformReference<string>(this, "backup_minimum_enforced_retention_duration");
        set => SetArgument("backup_minimum_enforced_retention_duration", value);
    }

    /// <summary>
    /// How a backup&#39;s enforced retention end time is inherited. Default value is &#39;INHERIT_VAULT_RETENTION&#39; if not provided during creation. Possible values: [&amp;quot;BACKUP_RETENTION_INHERITANCE_UNSPECIFIED&amp;quot;, &amp;quot;INHERIT_VAULT_RETENTION&amp;quot;, &amp;quot;MATCH_BACKUP_EXPIRE_TIME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? BackupRetentionInheritance
    {
        get => new TerraformReference<string>(this, "backup_retention_inheritance");
        set => SetArgument("backup_retention_inheritance", value);
    }

    /// <summary>
    /// Required. ID of the requesting object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformValue<string> BackupVaultId
    {
        get => new TerraformReference<string>(this, "backup_vault_id");
        set => SetArgument("backup_vault_id", value);
    }

    /// <summary>
    /// Optional. The description of the BackupVault instance (2048 characters or less).
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Optional. Time after which the BackupVault resource is locked.
    /// </summary>
    public TerraformValue<string>? EffectiveTime
    {
        get => new TerraformReference<string>(this, "effective_time");
        set => SetArgument("effective_time", value);
    }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? ForceDelete
    {
        get => new TerraformReference<bool>(this, "force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// If set, allow update to extend the minimum enforced retention for backup vault. This overrides
    ///  the restriction against conflicting retention periods. This conflict may occur when the
    ///  expiration schedule defined by the associated backup plan is shorter than the minimum
    ///  retention set by the backup vault.
    /// </summary>
    public TerraformValue<bool>? ForceUpdate
    {
        get => new TerraformReference<bool>(this, "force_update");
        set => SetArgument("force_update", value);
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
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance that is being referenced by an active backup plan.
    /// </summary>
    public TerraformValue<bool>? IgnoreBackupPlanReferences
    {
        get => new TerraformReference<bool>(this, "ignore_backup_plan_references");
        set => SetArgument("ignore_backup_plan_references", value);
    }

    /// <summary>
    /// If set, the following restrictions against deletion of the backup vault instance can be overridden:
    ///    * deletion of a backup vault instance containing no backups, but still containing empty datasources.
    /// </summary>
    public TerraformValue<bool>? IgnoreInactiveDatasources
    {
        get => new TerraformReference<bool>(this, "ignore_inactive_datasources");
        set => SetArgument("ignore_inactive_datasources", value);
    }

    /// <summary>
    /// Optional. Resource labels to represent user provided metadata. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The GCP location for the backup vault.
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
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The number of backups in this backup vault.
    /// </summary>
    public TerraformValue<string> BackupCount
    {
        get => new TerraformReference<string>(this, "backup_count");
    }

    /// <summary>
    /// Output only. The time when the instance was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. Set to true when there are no backups nested under this resource.
    /// </summary>
    public TerraformValue<bool> Deletable
    {
        get => new TerraformReference<bool>(this, "deletable");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Optional. Server specified ETag for the backup vault resource to prevent simultaneous updates from overwiting each other.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Output only. Identifier. The resource name.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. Service account used by the BackupVault Service for this BackupVault.  The user should grant this account permissions in their workload project to enable the service to run backups and restores there.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
    }

    /// <summary>
    /// Output only. The BackupVault resource instance state. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    ///  CREATING
    ///  ACTIVE
    ///  DELETING
    ///  ERROR
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Total size of the storage used by all backup resources.
    /// </summary>
    public TerraformValue<string> TotalStoredBytes
    {
        get => new TerraformReference<string>(this, "total_stored_bytes");
    }

    /// <summary>
    /// Output only. Output only Immutable after resource creation until resource deletion.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Output only. The time when the instance was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBackupDrBackupVaultTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBackupDrBackupVaultTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
