using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerEgressPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerEgressPolicyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_access_context_manager_egress_policy Terraform resource.
/// Manages a google_access_context_manager_egress_policy resource.
/// </summary>
public partial class GoogleAccessContextManagerEgressPolicy(string name) : TerraformResource("google_access_context_manager_egress_policy", name)
{
    /// <summary>
    /// The name of the Service Perimeter to add this resource to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EgressPolicyName is required")]
    public required TerraformValue<string> EgressPolicyName
    {
        get => new TerraformReference<string>(this, "egress_policy_name");
        set => SetArgument("egress_policy_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A GCP resource that is inside of the service perimeter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    public required TerraformValue<string> Resource
    {
        get => new TerraformReference<string>(this, "resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformValue<string> AccessPolicyId
    {
        get => new TerraformReference<string>(this, "access_policy_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerEgressPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerEgressPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
