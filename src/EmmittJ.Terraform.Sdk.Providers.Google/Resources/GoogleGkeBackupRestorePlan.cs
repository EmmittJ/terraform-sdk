using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gke_backup_restore_plan resource.
/// </summary>
public class GoogleGkeBackupRestorePlan : TerraformResource
{
    public GoogleGkeBackupRestorePlan(string name) : base("google_gke_backup_restore_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("state");
        this.DeclareOutput("state_reason");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
    }

    /// <summary>
    /// A reference to the BackupPlan from which Backups may be used
    /// as the source for Restores created via this RestorePlan.
    /// </summary>
    public TerraformProperty<string>? BackupPlan
    {
        get => GetProperty<TerraformProperty<string>>("backup_plan");
        set => this.WithProperty("backup_plan", value);
    }

    /// <summary>
    /// The source cluster from which Restores will be created via this RestorePlan.
    /// </summary>
    public TerraformProperty<string>? Cluster
    {
        get => GetProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// User specified descriptive string for this RestorePlan.
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
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The region of the Restore Plan.
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
