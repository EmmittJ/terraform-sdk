using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for role in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeHubScopeRbacRoleBindingRoleBlock : TerraformBlockBase
{
    /// <summary>
    /// CustomRole is the custom Kubernetes ClusterRole to be used. The custom role format must be allowlisted in the rbacrolebindingactuation feature and RFC 1123 compliant.
    /// </summary>
    [TerraformProperty("custom_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomRole { get; set; }

    /// <summary>
    /// PredefinedRole is an ENUM representation of the default Kubernetes Roles Possible values: [&amp;quot;UNKNOWN&amp;quot;, &amp;quot;ADMIN&amp;quot;, &amp;quot;EDIT&amp;quot;, &amp;quot;VIEW&amp;quot;]
    /// </summary>
    [TerraformProperty("predefined_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PredefinedRole { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_gke_hub_scope_rbac_role_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeHubScopeRbacRoleBinding : TerraformResource
{
    public GoogleGkeHubScopeRbacRoleBinding(string name) : base("google_gke_hub_scope_rbac_role_binding", name)
    {
    }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// group is the group, as seen by the kubernetes cluster.
    /// </summary>
    [TerraformProperty("group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels for this ScopeRBACRoleBinding.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Id of the scope
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    [TerraformProperty("scope_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScopeId { get; set; }

    /// <summary>
    /// The client-provided identifier of the RBAC Role Binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeRbacRoleBindingId is required")]
    [TerraformProperty("scope_rbac_role_binding_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScopeRbacRoleBindingId { get; set; }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// user is the name of the user as seen by the kubernetes cluster, example
    /// &amp;quot;alice&amp;quot; or &amp;quot;alice@domain.tld&amp;quot;
    /// </summary>
    [TerraformProperty("user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? User { get; set; }

    /// <summary>
    /// Block for role.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Role block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Role block(s) allowed")]
    [TerraformProperty("role")]
    public partial TerraformList<TerraformBlock<GoogleGkeHubScopeRbacRoleBindingRoleBlock>>? Role { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time the RBAC Role Binding was created in UTC.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Time the RBAC Role Binding was deleted in UTC.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The resource name for the RBAC Role Binding
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// State of the RBAC Role Binding resource.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Google-generated UUID for this resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time the RBAC Role Binding was updated in UTC.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
