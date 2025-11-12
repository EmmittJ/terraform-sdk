using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeFirewallPolicyAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_compute_firewall_policy_association resource.
/// </summary>
public partial class GoogleComputeFirewallPolicyAssociation : TerraformResource
{
    public GoogleComputeFirewallPolicyAssociation(string name) : base("google_compute_firewall_policy_association", name)
    {
    }

    /// <summary>
    /// The target that the firewall policy is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentTarget is required")]
    [TerraformProperty("attachment_target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AttachmentTarget { get; set; }

    /// <summary>
    /// The firewall policy of the resource.
    /// 
    /// This field can be updated to refer to a different Firewall Policy, which will create a new association from that new
    /// firewall policy with the flag to override the existing attachmentTarget&#39;s policy association.
    /// 
    /// **Note** Due to potential risks with this operation it is *highly* recommended to use the &#39;create_before_destroy&#39; life cycle option
    /// on your exisiting firewall policy so as to prevent a situation where your attachment target has no associated policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    [TerraformProperty("firewall_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirewallPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name for an association.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeFirewallPolicyAssociationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    [TerraformProperty("short_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ShortName { get; }

}
