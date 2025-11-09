using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gke_backup_backup_plan resource.
/// </summary>
public class GoogleGkeBackupBackupPlan : TerraformResource
{
    public GoogleGkeBackupBackupPlan(string name) : base("google_gke_backup_backup_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("protected_pod_count");
        this.DeclareOutput("state");
        this.DeclareOutput("state_reason");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
    }

    /// <summary>
    /// The source cluster from which Backups will be created via this BackupPlan.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// This flag indicates whether this BackupPlan has been deactivated.
    /// Setting this field to True locks the BackupPlan such that no further updates will be allowed
    /// (except deletes), including the deactivated field itself. It also prevents any new Backups
    /// from being created via this BackupPlan (including scheduled Backups).
    /// </summary>
    public TerraformProperty<bool>? Deactivated
    {
        get => GetProperty<TerraformProperty<bool>>("deactivated");
        set => this.WithProperty("deactivated", value);
    }

    /// <summary>
    /// User specified descriptive string for this BackupPlan.
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
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The region of the Backup Plan.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    public TerraformProperty<string>? Name
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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// etag is used for optimistic concurrency control as a way to help prevent simultaneous
    /// updates of a backup plan from overwriting each other. It is strongly suggested that
    /// systems make use of the &#39;etag&#39; in the read-modify-write cycle to perform BackupPlan updates
    /// in order to avoid race conditions: An etag is returned in the response to backupPlans.get,
    /// and systems are expected to put that etag in the request to backupPlans.patch or
    /// backupPlans.delete to ensure that their change will be applied to the same version of the resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.
    /// </summary>
    public TerraformExpression ProtectedPodCount => this["protected_pod_count"];

    /// <summary>
    /// The State of the BackupPlan.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Detailed description of why BackupPlan is in its current state.
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
