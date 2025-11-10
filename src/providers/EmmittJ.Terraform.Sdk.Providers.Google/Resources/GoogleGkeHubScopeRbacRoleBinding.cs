using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for role in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubScopeRbacRoleBindingRoleBlock : TerraformBlock
{
    /// <summary>
    /// CustomRole is the custom Kubernetes ClusterRole to be used. The custom role format must be allowlisted in the rbacrolebindingactuation feature and RFC 1123 compliant.
    /// </summary>
    public TerraformProperty<string>? CustomRole
    {
        set => SetProperty("custom_role", value);
    }

    /// <summary>
    /// PredefinedRole is an ENUM representation of the default Kubernetes Roles Possible values: [&amp;quot;UNKNOWN&amp;quot;, &amp;quot;ADMIN&amp;quot;, &amp;quot;EDIT&amp;quot;, &amp;quot;VIEW&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PredefinedRole
    {
        set => SetProperty("predefined_role", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock : TerraformBlock
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
/// Manages a google_gke_hub_scope_rbac_role_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeHubScopeRbacRoleBinding : TerraformResource
{
    public GoogleGkeHubScopeRbacRoleBinding(string name) : base("google_gke_hub_scope_rbac_role_binding", name)
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
        SetOutput("group");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("project");
        SetOutput("scope_id");
        SetOutput("scope_rbac_role_binding_id");
        SetOutput("user");
    }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// group is the group, as seen by the kubernetes cluster.
    /// </summary>
    public TerraformProperty<string> Group
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group");
        set => SetProperty("group", value);
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
    /// Labels for this ScopeRBACRoleBinding.
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
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
    /// The client-provided identifier of the RBAC Role Binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeRbacRoleBindingId is required")]
    public required TerraformProperty<string> ScopeRbacRoleBindingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope_rbac_role_binding_id");
        set => SetProperty("scope_rbac_role_binding_id", value);
    }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// user is the name of the user as seen by the kubernetes cluster, example
    /// &amp;quot;alice&amp;quot; or &amp;quot;alice@domain.tld&amp;quot;
    /// </summary>
    public TerraformProperty<string> User
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user");
        set => SetProperty("user", value);
    }

    /// <summary>
    /// Block for role.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Role block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Role block(s) allowed")]
    public List<GoogleGkeHubScopeRbacRoleBindingRoleBlock>? Role
    {
        set => SetProperty("role", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
