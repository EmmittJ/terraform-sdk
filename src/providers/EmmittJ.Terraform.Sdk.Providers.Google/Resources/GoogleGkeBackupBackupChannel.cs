using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupBackupChannelTimeoutsBlock : TerraformBlock
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
/// Manages a google_gke_backup_backup_channel resource.
/// </summary>
public class GoogleGkeBackupBackupChannel : TerraformResource
{
    public GoogleGkeBackupBackupChannel(string name) : base("google_gke_backup_backup_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("destination_project_id");
        this.WithOutput("effective_labels");
        this.WithOutput("etag");
        this.WithOutput("terraform_labels");
        this.WithOutput("uid");
    }

    /// <summary>
    /// User specified descriptive string for this BackupChannel.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The project where Backups are allowed to be stored.
    /// The format is &#39;projects/{project}&#39;.
    /// {project} can be project number or project id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationProject is required")]
    public required TerraformProperty<string> DestinationProject
    {
        get => GetRequiredProperty<TerraformProperty<string>>("destination_project");
        set => this.WithProperty("destination_project", value);
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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The region of the Backup Channel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The full name of the BackupChannel Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeBackupBackupChannelTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGkeBackupBackupChannelTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The project_id where Backups are allowed to be stored.
    /// Example Project ID: &amp;quot;my-project-id&amp;quot;.
    /// </summary>
    public TerraformExpression DestinationProjectId => this["destination_project_id"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// etag is used for optimistic concurrency control as a way to help prevent simultaneous
    /// updates of a backup channel from overwriting each other. It is strongly suggested that
    /// systems make use of the &#39;etag&#39; in the read-modify-write cycle to perform BackupChannel updates
    /// in order to avoid race conditions: An etag is returned in the response to backupChannels.get,
    /// and systems are expected to put that etag in the request to backupChannels.patch or
    /// backupChannels.delete to ensure that their change will be applied to the same version of the resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

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
