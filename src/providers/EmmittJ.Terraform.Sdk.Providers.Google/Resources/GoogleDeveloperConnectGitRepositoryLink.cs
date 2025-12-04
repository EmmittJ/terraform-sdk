using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDeveloperConnectGitRepositoryLink.
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectGitRepositoryLinkTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_developer_connect_git_repository_link Terraform resource.
/// Manages a google_developer_connect_git_repository_link resource.
/// </summary>
public partial class GoogleDeveloperConnectGitRepositoryLink(string name) : TerraformResource("google_developer_connect_git_repository_link", name)
{
    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Required. Git Clone URI.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloneUri is required")]
    public required TerraformValue<string> CloneUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("clone_uri");
        set => SetArgument("clone_uri", value);
    }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string>? Etag
    {
        get => GetArgument<TerraformValue<string>>("etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// Required. The ID to use for the repository, which will become the final component of
    /// the repository&#39;s resource name. This ID should be unique in the connection.
    /// Allows alphanumeric characters and any of -._~%!$&amp;amp;&#39;()*+,;=@.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitRepositoryLinkId is required")]
    public required TerraformValue<string> GitRepositoryLinkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("git_repository_link_id");
        set => SetArgument("git_repository_link_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Labels as key value pairs 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;developerconnect.googleapis.com/GitRepositoryLink&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;developerconnect.googleapis.com/GitRepositoryLink&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentConnection is required")]
    public required TerraformValue<string> ParentConnection
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent_connection");
        set => SetArgument("parent_connection", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. [Output only] Create timestamp
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Output only. [Output only] Delete timestamp
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Identifier. Resource name of the repository, in the format
    /// &#39;projects/*/locations/*/connections/*/gitRepositoryLinks/*&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. A system-assigned unique identifier for a the GitRepositoryLink.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. [Output only] Update timestamp
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDeveloperConnectGitRepositoryLinkTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDeveloperConnectGitRepositoryLinkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
