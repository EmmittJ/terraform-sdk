using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for role in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubScopeRbacRoleBindingRoleBlock : ITerraformBlock
{
    /// <summary>
    /// CustomRole is the custom Kubernetes ClusterRole to be used. The custom role format must be allowlisted in the rbacrolebindingactuation feature and RFC 1123 compliant.
    /// </summary>
    [TerraformPropertyName("custom_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomRole { get; set; }

    /// <summary>
    /// PredefinedRole is an ENUM representation of the default Kubernetes Roles Possible values: [&amp;quot;UNKNOWN&amp;quot;, &amp;quot;ADMIN&amp;quot;, &amp;quot;EDIT&amp;quot;, &amp;quot;VIEW&amp;quot;]
    /// </summary>
    [TerraformPropertyName("predefined_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PredefinedRole { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_gke_hub_scope_rbac_role_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeHubScopeRbacRoleBinding : TerraformResource
{
    public GoogleGkeHubScopeRbacRoleBinding(string name) : base("google_gke_hub_scope_rbac_role_binding", name)
    {
    }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// group is the group, as seen by the kubernetes cluster.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels for this ScopeRBACRoleBinding.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Id of the scope
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    [TerraformPropertyName("scope_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScopeId { get; set; }

    /// <summary>
    /// The client-provided identifier of the RBAC Role Binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeRbacRoleBindingId is required")]
    [TerraformPropertyName("scope_rbac_role_binding_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScopeRbacRoleBindingId { get; set; }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// user is the name of the user as seen by the kubernetes cluster, example
    /// &amp;quot;alice&amp;quot; or &amp;quot;alice@domain.tld&amp;quot;
    /// </summary>
    [TerraformPropertyName("user")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? User { get; set; }

    /// <summary>
    /// Block for role.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Role block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Role block(s) allowed")]
    [TerraformPropertyName("role")]
    public TerraformList<TerraformBlock<GoogleGkeHubScopeRbacRoleBindingRoleBlock>>? Role { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Time the RBAC Role Binding was created in UTC.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Time the RBAC Role Binding was deleted in UTC.
    /// </summary>
    [TerraformPropertyName("delete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The resource name for the RBAC Role Binding
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// State of the RBAC Role Binding resource.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> State => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Google-generated UUID for this resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Time the RBAC Role Binding was updated in UTC.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
