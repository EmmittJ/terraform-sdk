using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallPolicyAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_firewall_policy_association resource.
/// </summary>
public class GoogleComputeFirewallPolicyAssociation : TerraformResource
{
    public GoogleComputeFirewallPolicyAssociation(string name) : base("google_compute_firewall_policy_association", name)
    {
    }

    /// <summary>
    /// The target that the firewall policy is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentTarget is required")]
    [TerraformPropertyName("attachment_target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AttachmentTarget { get; set; }

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
    [TerraformPropertyName("firewall_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name for an association.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeFirewallPolicyAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    [TerraformPropertyName("short_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ShortName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "short_name");

}
