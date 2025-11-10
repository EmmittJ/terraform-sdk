using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for restore_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlock : ITerraformBlock
{
    /// <summary>
    /// If True, restore all namespaced resources in the Backup.
    /// Setting this field to False will result in an error.
    /// </summary>
    [TerraformPropertyName("all_namespaces")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllNamespaces { get; set; }

    /// <summary>
    /// Defines the behavior for handling the situation where cluster-scoped resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;CLUSTER_RESOURCE_CONFLICT_POLICY_UNSPECIFIED&#39;
    /// if &#39;clusterResourceRestoreScope&#39; is anyting other than &#39;noGroupKinds&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#clusterresourceconflictpolicy
    /// for more information on each policy option. Possible values: [&amp;quot;USE_EXISTING_VERSION&amp;quot;, &amp;quot;USE_BACKUP_VERSION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("cluster_resource_conflict_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterResourceConflictPolicy { get; set; }

    /// <summary>
    /// Defines the behavior for handling the situation where sets of namespaced resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#namespacedresourcerestoremode
    /// for more information on each mode. Possible values: [&amp;quot;DELETE_AND_RESTORE&amp;quot;, &amp;quot;FAIL_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_SKIP_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_VOLUME_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_ON_CONFLICT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("namespaced_resource_restore_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NamespacedResourceRestoreMode { get; set; }

    /// <summary>
    /// Do not restore any namespaced resources if set to &amp;quot;True&amp;quot;.
    /// Specifying this field to &amp;quot;False&amp;quot; is not allowed.
    /// </summary>
    [TerraformPropertyName("no_namespaces")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoNamespaces { get; set; }

    /// <summary>
    /// Specifies the mechanism to be used to restore volume data.
    /// This should be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// If not specified, it will be treated as &#39;NO_VOLUME_DATA_RESTORATION&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#VolumeDataRestorePolicy
    /// for more information on each policy option. Possible values: [&amp;quot;RESTORE_VOLUME_DATA_FROM_BACKUP&amp;quot;, &amp;quot;REUSE_VOLUME_HANDLE_FROM_BACKUP&amp;quot;, &amp;quot;NO_VOLUME_DATA_RESTORATION&amp;quot;]
    /// </summary>
    [TerraformPropertyName("volume_data_restore_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VolumeDataRestorePolicy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupRestorePlanTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_gke_backup_restore_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeBackupRestorePlan : TerraformResource
{
    public GoogleGkeBackupRestorePlan(string name) : base("google_gke_backup_restore_plan", name)
    {
    }

    /// <summary>
    /// A reference to the BackupPlan from which Backups may be used
    /// as the source for Restores created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlan is required")]
    [TerraformPropertyName("backup_plan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupPlan { get; set; }

    /// <summary>
    /// The source cluster from which Restores will be created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cluster { get; set; }

    /// <summary>
    /// User specified descriptive string for this RestorePlan.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The region of the Restore Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for restore_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RestoreConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreConfig block(s) allowed")]
    [TerraformPropertyName("restore_config")]
    public TerraformList<TerraformBlock<GoogleGkeBackupRestorePlanRestoreConfigBlock>>? RestoreConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeBackupRestorePlanTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The State of the RestorePlan.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Detailed description of why RestorePlan is in its current state.
    /// </summary>
    [TerraformPropertyName("state_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_reason");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

}
