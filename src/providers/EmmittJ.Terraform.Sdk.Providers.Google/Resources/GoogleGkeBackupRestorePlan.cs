using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for restore_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeBackupRestorePlanRestoreConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// If True, restore all namespaced resources in the Backup.
    /// Setting this field to False will result in an error.
    /// </summary>
    [TerraformProperty("all_namespaces")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllNamespaces { get; set; }

    /// <summary>
    /// Defines the behavior for handling the situation where cluster-scoped resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;CLUSTER_RESOURCE_CONFLICT_POLICY_UNSPECIFIED&#39;
    /// if &#39;clusterResourceRestoreScope&#39; is anyting other than &#39;noGroupKinds&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#clusterresourceconflictpolicy
    /// for more information on each policy option. Possible values: [&amp;quot;USE_EXISTING_VERSION&amp;quot;, &amp;quot;USE_BACKUP_VERSION&amp;quot;]
    /// </summary>
    [TerraformProperty("cluster_resource_conflict_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterResourceConflictPolicy { get; set; }

    /// <summary>
    /// Defines the behavior for handling the situation where sets of namespaced resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#namespacedresourcerestoremode
    /// for more information on each mode. Possible values: [&amp;quot;DELETE_AND_RESTORE&amp;quot;, &amp;quot;FAIL_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_SKIP_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_VOLUME_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_ON_CONFLICT&amp;quot;]
    /// </summary>
    [TerraformProperty("namespaced_resource_restore_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamespacedResourceRestoreMode { get; set; }

    /// <summary>
    /// Do not restore any namespaced resources if set to &amp;quot;True&amp;quot;.
    /// Specifying this field to &amp;quot;False&amp;quot; is not allowed.
    /// </summary>
    [TerraformProperty("no_namespaces")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NoNamespaces { get; set; }

    /// <summary>
    /// Specifies the mechanism to be used to restore volume data.
    /// This should be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// If not specified, it will be treated as &#39;NO_VOLUME_DATA_RESTORATION&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#VolumeDataRestorePolicy
    /// for more information on each policy option. Possible values: [&amp;quot;RESTORE_VOLUME_DATA_FROM_BACKUP&amp;quot;, &amp;quot;REUSE_VOLUME_HANDLE_FROM_BACKUP&amp;quot;, &amp;quot;NO_VOLUME_DATA_RESTORATION&amp;quot;]
    /// </summary>
    [TerraformProperty("volume_data_restore_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VolumeDataRestorePolicy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeBackupRestorePlanTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_gke_backup_restore_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeBackupRestorePlan : TerraformResource
{
    public GoogleGkeBackupRestorePlan(string name) : base("google_gke_backup_restore_plan", name)
    {
    }

    /// <summary>
    /// A reference to the BackupPlan from which Backups may be used
    /// as the source for Restores created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlan is required")]
    [TerraformProperty("backup_plan")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupPlan { get; set; }

    /// <summary>
    /// The source cluster from which Restores will be created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// User specified descriptive string for this RestorePlan.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The region of the Restore Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for restore_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RestoreConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreConfig block(s) allowed")]
    [TerraformProperty("restore_config")]
    public partial TerraformList<TerraformBlock<GoogleGkeBackupRestorePlanRestoreConfigBlock>>? RestoreConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleGkeBackupRestorePlanTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The State of the RestorePlan.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Detailed description of why RestorePlan is in its current state.
    /// </summary>
    [TerraformProperty("state_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateReason { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

}
