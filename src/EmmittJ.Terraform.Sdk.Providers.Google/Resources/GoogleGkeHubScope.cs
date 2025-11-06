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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels for this Scope.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Scope-level cluster namespace labels. For the member clusters bound
    /// to the Scope, these labels are applied to each namespace under the
    /// Scope. Scope-level labels take precedence over Namespace-level
    /// labels (&#39;namespace_labels&#39; in the Fleet Namespace resource) if they
    /// share a key. Keys and values must be Kubernetes-conformant.
    /// </summary>
    public Dictionary<string, string>? NamespaceLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("namespace_labels")?.Value;
        set => this.WithProperty("namespace_labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client-provided identifier of the scope.
    /// </summary>
    public string? ScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope_id")?.Value;
        set => this.WithProperty("scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
