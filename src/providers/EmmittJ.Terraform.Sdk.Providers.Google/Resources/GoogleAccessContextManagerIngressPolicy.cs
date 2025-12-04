using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerIngressPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerIngressPolicyTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_access_context_manager_ingress_policy Terraform resource.
/// Manages a google_access_context_manager_ingress_policy resource.
/// </summary>
public partial class GoogleAccessContextManagerIngressPolicy(string name) : TerraformResource("google_access_context_manager_ingress_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IngressPolicyName is required")]
    public required TerraformValue<string> IngressPolicyName
    {
        get => GetArgument<TerraformValue<string>>("ingress_policy_name");
        set => SetArgument("ingress_policy_name", value);
    }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformValue<string> AccessPolicyId
        => AsReference("access_policy_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerIngressPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerIngressPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
