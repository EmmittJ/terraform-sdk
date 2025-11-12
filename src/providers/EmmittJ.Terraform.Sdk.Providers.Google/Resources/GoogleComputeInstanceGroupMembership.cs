using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeInstanceGroupMembershipTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_compute_instance_group_membership resource.
/// </summary>
public partial class GoogleComputeInstanceGroupMembership : TerraformResource
{
    public GoogleComputeInstanceGroupMembership(string name) : base("google_compute_instance_group_membership", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// An instance being added to the InstanceGroup
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// Represents an Instance Group resource name that the instance belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceGroup is required")]
    [TerraformProperty("instance_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceGroup { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A reference to the zone where the instance group resides.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeInstanceGroupMembershipTimeoutsBlock Timeouts { get; set; } = new();

}
