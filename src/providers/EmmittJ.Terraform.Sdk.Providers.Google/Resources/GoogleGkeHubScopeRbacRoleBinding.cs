using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for role in GoogleGkeHubScopeRbacRoleBinding.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubScopeRbacRoleBindingRoleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "role";

    /// <summary>
    /// CustomRole is the custom Kubernetes ClusterRole to be used. The custom role format must be allowlisted in the rbacrolebindingactuation feature and RFC 1123 compliant.
    /// </summary>
    public TerraformValue<string>? CustomRole
    {
        get => GetArgument<TerraformValue<string>>("custom_role");
        set => SetArgument("custom_role", value);
    }

    /// <summary>
    /// PredefinedRole is an ENUM representation of the default Kubernetes Roles Possible values: [&amp;quot;UNKNOWN&amp;quot;, &amp;quot;ADMIN&amp;quot;, &amp;quot;EDIT&amp;quot;, &amp;quot;VIEW&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PredefinedRole
    {
        get => GetArgument<TerraformValue<string>>("predefined_role");
        set => SetArgument("predefined_role", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeHubScopeRbacRoleBinding.
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock : TerraformBlock
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
/// Represents a google_gke_hub_scope_rbac_role_binding Terraform resource.
/// Manages a google_gke_hub_scope_rbac_role_binding resource.
/// </summary>
public partial class GoogleGkeHubScopeRbacRoleBinding(string name) : TerraformResource("google_gke_hub_scope_rbac_role_binding", name)
{
    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// group is the group, as seen by the kubernetes cluster.
    /// </summary>
    public TerraformValue<string>? Group
    {
        get => GetArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
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
    /// Labels for this ScopeRBACRoleBinding.
    /// 
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Id of the scope
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformValue<string> ScopeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope_id");
        set => SetArgument("scope_id", value);
    }

    /// <summary>
    /// The client-provided identifier of the RBAC Role Binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeRbacRoleBindingId is required")]
    public required TerraformValue<string> ScopeRbacRoleBindingId
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope_rbac_role_binding_id");
        set => SetArgument("scope_rbac_role_binding_id", value);
    }

    /// <summary>
    /// Principal that is be authorized in the cluster (at least of one the oneof
    /// is required). Updating one will unset the other automatically.
    /// user is the name of the user as seen by the kubernetes cluster, example
    /// &amp;quot;alice&amp;quot; or &amp;quot;alice@domain.tld&amp;quot;
    /// </summary>
    public TerraformValue<string>? User
    {
        get => GetArgument<TerraformValue<string>>("user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// Time the RBAC Role Binding was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Time the RBAC Role Binding was deleted in UTC.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The resource name for the RBAC Role Binding
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// State of the RBAC Role Binding resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Google-generated UUID for this resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Time the RBAC Role Binding was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Role block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Role block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Role block(s) allowed")]
    public required TerraformList<GoogleGkeHubScopeRbacRoleBindingRoleBlock> Role
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeHubScopeRbacRoleBindingRoleBlock>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeHubScopeRbacRoleBindingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
