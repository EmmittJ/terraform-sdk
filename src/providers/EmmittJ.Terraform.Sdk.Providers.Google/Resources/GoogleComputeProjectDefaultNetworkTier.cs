using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeProjectDefaultNetworkTier.
/// Nesting mode: single
/// </summary>
public class GoogleComputeProjectDefaultNetworkTierTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_compute_project_default_network_tier Terraform resource.
/// Manages a google_compute_project_default_network_tier resource.
/// </summary>
public partial class GoogleComputeProjectDefaultNetworkTier(string name) : TerraformResource("google_compute_project_default_network_tier", name)
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
    /// The default network tier to be configured for the project. This field can take the following values: PREMIUM or STANDARD.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkTier is required")]
    public required TerraformValue<string> NetworkTier
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeProjectDefaultNetworkTierTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeProjectDefaultNetworkTierTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
