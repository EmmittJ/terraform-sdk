using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubNamespaceTimeoutsBlock : TerraformBlock
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
/// Manages a google_gke_hub_namespace resource.
/// </summary>
public class GoogleGkeHubNamespace : TerraformResource
{
    public GoogleGkeHubNamespace(string name) : base("google_gke_hub_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("delete_time");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("namespace_labels");
        SetOutput("project");
        SetOutput("scope");
        SetOutput("scope_id");
        SetOutput("scope_namespace_id");
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
    /// Labels for this Namespace.
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
    /// Namespace-level cluster namespace labels. These labels are applied
    /// to the related namespace of the member clusters bound to the parent
    /// Scope. Scope-level labels (&#39;namespace_labels&#39; in the Fleet Scope
    /// resource) take precedence over Namespace-level labels if they share
    /// a key. Keys and values must be Kubernetes-conformant.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> NamespaceLabels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("namespace_labels");
        set => SetProperty("namespace_labels", value);
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
    /// The name of the Scope instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Id of the scope
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformProperty<string> ScopeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope_id");
        set => SetProperty("scope_id", value);
    }

    /// <summary>
    /// The client-provided identifier of the namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeNamespaceId is required")]
    public required TerraformProperty<string> ScopeNamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope_namespace_id");
        set => SetProperty("scope_namespace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeHubNamespaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time the Namespace was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time the Namespace was deleted in UTC.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name for the namespace
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// State of the namespace resource.
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
    /// Time the Namespace was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
