using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeFirewallPolicyAssociation.
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallPolicyAssociationTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_firewall_policy_association Terraform resource.
/// Manages a google_compute_firewall_policy_association resource.
/// </summary>
public partial class GoogleComputeFirewallPolicyAssociation(string name) : TerraformResource("google_compute_firewall_policy_association", name)
{
    /// <summary>
    /// The target that the firewall policy is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentTarget is required")]
    public required TerraformValue<string> AttachmentTarget
    {
        get => new TerraformReference<string>(this, "attachment_target");
        set => SetArgument("attachment_target", value);
    }

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
    public required TerraformValue<string> FirewallPolicy
    {
        get => new TerraformReference<string>(this, "firewall_policy");
        set => SetArgument("firewall_policy", value);
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
    /// The name for an association.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    public TerraformValue<string> ShortName
    {
        get => new TerraformReference<string>(this, "short_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeFirewallPolicyAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeFirewallPolicyAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
