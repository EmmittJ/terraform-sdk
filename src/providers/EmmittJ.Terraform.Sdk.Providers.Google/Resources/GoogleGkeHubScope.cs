using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleGkeHubScope.
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubScopeTimeoutsBlock : TerraformBlock
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
/// Represents a google_gke_hub_scope Terraform resource.
/// Manages a google_gke_hub_scope resource.
/// </summary>
public partial class GoogleGkeHubScope(string name) : TerraformResource("google_gke_hub_scope", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels for this Scope.
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
    /// Scope-level cluster namespace labels. For the member clusters bound
    /// to the Scope, these labels are applied to each namespace under the
    /// Scope. Scope-level labels take precedence over Namespace-level
    /// labels (&#39;namespace_labels&#39; in the Fleet Namespace resource) if they
    /// share a key. Keys and values must be Kubernetes-conformant.
    /// </summary>
    public TerraformMap<string>? NamespaceLabels
    {
        get => GetArgument<TerraformMap<string>>("namespace_labels");
        set => SetArgument("namespace_labels", value);
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
    /// The client-provided identifier of the scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformValue<string> ScopeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope_id");
        set => SetArgument("scope_id", value);
    }

    /// <summary>
    /// Time the Scope was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Time the Scope was deleted in UTC.
    /// </summary>
    public TerraformValue<string> DeleteTime
        => AsReference("delete_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The unique identifier of the scope
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// State of the scope resource.
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
    /// Time the Scope was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeHubScopeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeHubScopeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
