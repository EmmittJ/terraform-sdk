using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_gke_hub_scope_rbac_role_binding resource.
/// </summary>
public class GoogleGkeHubScopeRbacRoleBinding : TerraformResource
{
    public GoogleGkeHubScopeRbacRoleBinding(string name) : base("google_gke_hub_scope_rbac_role_binding", name)
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
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// group is the group, as seen by the kubernetes cluster.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
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
    /// Labels for this ScopeRBACRoleBinding.
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Id of the scope
    /// </summary>
    public TerraformProperty<string>? ScopeId
    {
        get => GetProperty<TerraformProperty<string>>("scope_id");
        set => this.WithProperty("scope_id", value);
    }

    /// <summary>
    /// The client-provided identifier of the RBAC Role Binding.
    /// </summary>
    public TerraformProperty<string>? ScopeRbacRoleBindingId
    {
        get => GetProperty<TerraformProperty<string>>("scope_rbac_role_binding_id");
        set => this.WithProperty("scope_rbac_role_binding_id", value);
    }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// user is the name of the user as seen by the kubernetes cluster, example
    /// &amp;quot;alice&amp;quot; or &amp;quot;alice@domain.tld&amp;quot;
    /// </summary>
    public TerraformProperty<string>? User
    {
        get => GetProperty<TerraformProperty<string>>("user");
        set => this.WithProperty("user", value);
    }

    /// <summary>
    /// Time the RBAC Role Binding was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time the RBAC Role Binding was deleted in UTC.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name for the RBAC Role Binding
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// State of the RBAC Role Binding resource.
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
    /// Time the RBAC Role Binding was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
