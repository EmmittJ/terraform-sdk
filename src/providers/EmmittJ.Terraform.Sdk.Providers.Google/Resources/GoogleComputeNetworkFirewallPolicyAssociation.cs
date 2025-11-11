using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_compute_network_firewall_policy_association resource.
/// </summary>
public partial class GoogleComputeNetworkFirewallPolicyAssociation : TerraformResource
{
    public GoogleComputeNetworkFirewallPolicyAssociation(string name) : base("google_compute_network_firewall_policy_association", name)
    {
    }

    /// <summary>
    /// The target that the firewall policy is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentTarget is required")]
    [TerraformProperty("attachment_target")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AttachmentTarget { get; set; }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    [TerraformProperty("firewall_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FirewallPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name for an association.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    [TerraformProperty("short_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ShortName { get; }

}
