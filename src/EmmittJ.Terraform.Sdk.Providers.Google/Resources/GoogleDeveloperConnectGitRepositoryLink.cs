using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Annotations
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Required. Git Clone URI.
    /// </summary>
    public TerraformProperty<string>? CloneUri
    {
        get => GetProperty<TerraformProperty<string>>("clone_uri");
        set => this.WithProperty("clone_uri", value);
    }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
    }

    /// <summary>
    /// Required. The ID to use for the repository, which will become the final component of
    /// the repository&#39;s resource name. This ID should be unique in the connection.
    /// Allows alphanumeric characters and any of -._~%!$&amp;amp;&#39;()*+,;=@.
    /// </summary>
    public TerraformProperty<string>? GitRepositoryLinkId
    {
        get => GetProperty<TerraformProperty<string>>("git_repository_link_id");
        set => this.WithProperty("git_repository_link_id", value);
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
    /// Optional. Labels as key value pairs 
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;developerconnect.googleapis.com/GitRepositoryLink&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. See documentation for resource type &#39;developerconnect.googleapis.com/GitRepositoryLink&#39;.
    /// </summary>
    public TerraformProperty<string>? ParentConnection
    {
        get => GetProperty<TerraformProperty<string>>("parent_connection");
        set => this.WithProperty("parent_connection", value);
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
