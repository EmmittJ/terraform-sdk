using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for restore_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// If True, restore all namespaced resources in the Backup.
    /// Setting this field to False will result in an error.
    /// </summary>
    public TerraformProperty<bool>? AllNamespaces
    {
        set => SetProperty("all_namespaces", value);
    }

    /// <summary>
    /// Defines the behavior for handling the situation where cluster-scoped resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;CLUSTER_RESOURCE_CONFLICT_POLICY_UNSPECIFIED&#39;
    /// if &#39;clusterResourceRestoreScope&#39; is anyting other than &#39;noGroupKinds&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#clusterresourceconflictpolicy
    /// for more information on each policy option. Possible values: [&amp;quot;USE_EXISTING_VERSION&amp;quot;, &amp;quot;USE_BACKUP_VERSION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ClusterResourceConflictPolicy
    {
        set => SetProperty("cluster_resource_conflict_policy", value);
    }

    /// <summary>
    /// Defines the behavior for handling the situation where sets of namespaced resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#namespacedresourcerestoremode
    /// for more information on each mode. Possible values: [&amp;quot;DELETE_AND_RESTORE&amp;quot;, &amp;quot;FAIL_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_SKIP_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_VOLUME_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_ON_CONFLICT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? NamespacedResourceRestoreMode
    {
        set => SetProperty("namespaced_resource_restore_mode", value);
    }

    /// <summary>
    /// Do not restore any namespaced resources if set to &amp;quot;True&amp;quot;.
    /// Specifying this field to &amp;quot;False&amp;quot; is not allowed.
    /// </summary>
    public TerraformProperty<bool>? NoNamespaces
    {
        set => SetProperty("no_namespaces", value);
    }

    /// <summary>
    /// Specifies the mechanism to be used to restore volume data.
    /// This should be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// If not specified, it will be treated as &#39;NO_VOLUME_DATA_RESTORATION&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#VolumeDataRestorePolicy
    /// for more information on each policy option. Possible values: [&amp;quot;RESTORE_VOLUME_DATA_FROM_BACKUP&amp;quot;, &amp;quot;REUSE_VOLUME_HANDLE_FROM_BACKUP&amp;quot;, &amp;quot;NO_VOLUME_DATA_RESTORATION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? VolumeDataRestorePolicy
    {
        set => SetProperty("volume_data_restore_policy", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupRestorePlanTimeoutsBlock : TerraformBlock
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
/// Manages a google_gke_backup_restore_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeBackupRestorePlan : TerraformResource
{
    public GoogleGkeBackupRestorePlan(string name) : base("google_gke_backup_restore_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("state");
        SetOutput("state_reason");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("backup_plan");
        SetOutput("cluster");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// A reference to the BackupPlan from which Backups may be used
    /// as the source for Restores created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlan is required")]
    public required TerraformProperty<string> BackupPlan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_plan");
        set => SetProperty("backup_plan", value);
    }

    /// <summary>
    /// The source cluster from which Restores will be created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// User specified descriptive string for this RestorePlan.
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
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The region of the Restore Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for restore_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RestoreConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreConfig block(s) allowed")]
    public List<GoogleGkeBackupRestorePlanRestoreConfigBlock>? RestoreConfig
    {
        set => SetProperty("restore_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeBackupRestorePlanTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The State of the RestorePlan.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Detailed description of why RestorePlan is in its current state.
    /// </summary>
    public TerraformExpression StateReason => this["state_reason"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

}
