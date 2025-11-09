using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gke_hub_scope resource.
/// </summary>
public class GoogleGkeHubScope : TerraformResource
{
    public GoogleGkeHubScope(string name) : base("google_gke_hub_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
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
    /// Labels for this Scope.
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
    /// Scope-level cluster namespace labels. For the member clusters bound
    /// to the Scope, these labels are applied to each namespace under the
    /// Scope. Scope-level labels take precedence over Namespace-level
    /// labels (&#39;namespace_labels&#39; in the Fleet Namespace resource) if they
    /// share a key. Keys and values must be Kubernetes-conformant.
    /// </summary>
    public TerraformMapProperty<string>? NamespaceLabels
    {
        get => GetProperty<TerraformMapProperty<string>>("namespace_labels");
        set => this.WithProperty("namespace_labels", value);
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
    /// The client-provided identifier of the scope.
    /// </summary>
    public TerraformProperty<string>? ScopeId
    {
        get => GetProperty<TerraformProperty<string>>("scope_id");
        set => this.WithProperty("scope_id", value);
    }

    /// <summary>
    /// Time the Scope was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time the Scope was deleted in UTC.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The unique identifier of the scope
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// State of the scope resource.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Google-generated UUID for this resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time the Scope was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
