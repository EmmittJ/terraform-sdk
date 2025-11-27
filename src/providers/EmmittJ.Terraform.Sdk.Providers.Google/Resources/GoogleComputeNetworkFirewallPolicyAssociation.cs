using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeNetworkFirewallPolicyAssociation.
/// Nesting mode: single
/// </summary>
public class GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_network_firewall_policy_association Terraform resource.
/// Manages a google_compute_network_firewall_policy_association resource.
/// </summary>
public partial class GoogleComputeNetworkFirewallPolicyAssociation(string name) : TerraformResource("google_compute_network_firewall_policy_association", name)
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
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
    public GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeNetworkFirewallPolicyAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
