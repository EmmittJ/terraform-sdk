using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectGitRepositoryLinkTimeoutsBlock : TerraformBlock
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
/// Manages a google_developer_connect_git_repository_link resource.
/// </summary>
public class GoogleDeveloperConnectGitRepositoryLink : TerraformResource
{
    public GoogleDeveloperConnectGitRepositoryLink(string name) : base("google_developer_connect_git_repository_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("delete_time");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("reconciling");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("clone_uri");
        SetOutput("etag");
        SetOutput("git_repository_link_id");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("parent_connection");
        SetOutput("project");
    }

    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// Required. Git Clone URI.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloneUri is required")]
    public required TerraformProperty<string> CloneUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("clone_uri");
        set => SetProperty("clone_uri", value);
    }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformProperty<string> Etag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("etag");
        set => SetProperty("etag", value);
    }

    /// <summary>
    /// Required. The ID to use for the repository, which will become the final component of
    /// the repository&#39;s resource name. This ID should be unique in the connection.
    /// Allows alphanumeric characters and any of -._~%!$&amp;amp;&#39;()*+,;=@.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitRepositoryLinkId is required")]
    public required TerraformProperty<string> GitRepositoryLinkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("git_repository_link_id");
        set => SetProperty("git_repository_link_id", value);
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
    /// Optional. Labels as key value pairs 
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;developerconnect.googleapis.com/GitRepositoryLink&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;developerconnect.googleapis.com/GitRepositoryLink&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentConnection is required")]
    public required TerraformProperty<string> ParentConnection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_connection");
        set => SetProperty("parent_connection", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDeveloperConnectGitRepositoryLinkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. [Output only] Create timestamp
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. [Output only] Delete timestamp
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. Resource name of the repository, in the format
    /// &#39;projects/*/locations/*/connections/*/gitRepositoryLinks/*&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. A system-assigned unique identifier for a the GitRepositoryLink.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. [Output only] Update timestamp
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
