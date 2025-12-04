using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeInstanceGroupMembership.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceGroupMembershipTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_instance_group_membership Terraform resource.
/// Manages a google_compute_instance_group_membership resource.
/// </summary>
public partial class GoogleComputeInstanceGroupMembership(string name) : TerraformResource("google_compute_instance_group_membership", name)
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
    /// An instance being added to the InstanceGroup
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// Represents an Instance Group resource name that the instance belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceGroup is required")]
    public required TerraformValue<string> InstanceGroup
    {
        get => GetArgument<TerraformValue<string>>("instance_group");
        set => SetArgument("instance_group", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A reference to the zone where the instance group resides.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInstanceGroupMembershipTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInstanceGroupMembershipTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
