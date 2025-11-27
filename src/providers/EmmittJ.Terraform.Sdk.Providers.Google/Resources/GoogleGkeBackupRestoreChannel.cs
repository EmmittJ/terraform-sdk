using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleGkeBackupRestoreChannel.
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupRestoreChannelTimeoutsBlock : TerraformBlock
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
/// Represents a google_gke_backup_restore_channel Terraform resource.
/// Manages a google_gke_backup_restore_channel resource.
/// </summary>
public partial class GoogleGkeBackupRestoreChannel(string name) : TerraformResource("google_gke_backup_restore_channel", name)
{
    /// <summary>
    /// User specified descriptive string for this RestoreChannel.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The project where Backups will be restored.
    /// The format is &#39;projects/{project}&#39;.
    /// {project} can be project number or project id.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationProject is required")]
    public required TerraformValue<string> DestinationProject
    {
        get => new TerraformReference<string>(this, "destination_project");
        set => SetArgument("destination_project", value);
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
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
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
    /// The region of the Restore Channel.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The full name of the RestoreChannel Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The project_id where Backups will be restored.
    /// Example Project ID: &amp;quot;my-project-id&amp;quot;.
    /// </summary>
    public TerraformValue<string> DestinationProjectId
    {
        get => new TerraformReference<string>(this, "destination_project_id");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// etag is used for optimistic concurrency control as a way to help prevent simultaneous
    /// updates of a restore channel from overwriting each other. It is strongly suggested that
    /// systems make use of the &#39;etag&#39; in the read-modify-write cycle to perform RestoreChannel updates
    /// in order to avoid race conditions: An etag is returned in the response to restoreChannels.get,
    /// and systems are expected to put that etag in the request to restoreChannels.patch or
    /// restoreChannels.delete to ensure that their change will be applied to the same version of the resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
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
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeBackupRestoreChannelTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeBackupRestoreChannelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
