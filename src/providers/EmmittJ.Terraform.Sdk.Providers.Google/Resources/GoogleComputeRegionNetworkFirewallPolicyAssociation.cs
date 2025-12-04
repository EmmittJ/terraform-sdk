using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeRegionNetworkFirewallPolicyAssociation.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_network_firewall_policy_association Terraform resource.
/// Manages a google_compute_region_network_firewall_policy_association resource.
/// </summary>
public partial class GoogleComputeRegionNetworkFirewallPolicyAssociation(string name) : TerraformResource("google_compute_region_network_firewall_policy_association", name)
{
    /// <summary>
    /// The target that the firewall policy is attached to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentTarget is required")]
    public required TerraformValue<string> AttachmentTarget
    {
        get => GetArgument<TerraformValue<string>>("attachment_target");
        set => SetArgument("attachment_target", value);
    }

    /// <summary>
    /// The firewall policy of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    public required TerraformValue<string> FirewallPolicy
    {
        get => GetArgument<TerraformValue<string>>("firewall_policy");
        set => SetArgument("firewall_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name for an association.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The location of this resource.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The short name of the firewall policy of the association.
    /// </summary>
    public TerraformValue<string> ShortName
        => AsReference("short_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionNetworkFirewallPolicyAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionNetworkFirewallPolicyAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
