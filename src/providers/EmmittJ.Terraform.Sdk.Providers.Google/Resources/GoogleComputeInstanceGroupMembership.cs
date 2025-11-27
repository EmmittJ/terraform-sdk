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
/// Represents a google_compute_instance_group_membership Terraform resource.
/// Manages a google_compute_instance_group_membership resource.
/// </summary>
public partial class GoogleComputeInstanceGroupMembership(string name) : TerraformResource("google_compute_instance_group_membership", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// An instance being added to the InstanceGroup
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// Represents an Instance Group resource name that the instance belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceGroup is required")]
    public required TerraformValue<string> InstanceGroup
    {
        get => new TerraformReference<string>(this, "instance_group");
        set => SetArgument("instance_group", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A reference to the zone where the instance group resides.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
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
