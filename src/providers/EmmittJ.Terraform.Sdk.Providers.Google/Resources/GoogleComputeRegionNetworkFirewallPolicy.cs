using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeRegionNetworkFirewallPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionNetworkFirewallPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_region_network_firewall_policy Terraform resource.
/// Manages a google_compute_region_network_firewall_policy resource.
/// </summary>
public partial class GoogleComputeRegionNetworkFirewallPolicy(string name) : TerraformResource("google_compute_region_network_firewall_policy", name)
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// User-provided name of the Network firewall policy. The name should be unique in the project in which the firewall policy is created. The name must be 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])? which means the first character must be a lowercase letter, and all following characters must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Policy type is used to determine which resources (networks) the policy can be associated with.
    /// A policy can be associated with a network only if the network has the matching policyType in its network profile.
    /// Different policy types may support some of the Firewall Rules features. Possible values: [&amp;quot;VPC_POLICY&amp;quot;, &amp;quot;RDMA_ROCE_POLICY&amp;quot;]
    /// </summary>
    public TerraformValue<string> PolicyType
    {
        get => new TerraformReference<string>(this, "policy_type");
        set => SetArgument("policy_type", value);
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
    /// The region of this resource.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// Fingerprint of the resource. This field is used internally during updates of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<string> RegionNetworkFirewallPolicyId
    {
        get => new TerraformReference<string>(this, "region_network_firewall_policy_id");
    }

    /// <summary>
    /// Total count of all firewall policy rule tuples. A firewall policy can not exceed a set number of tuples.
    /// </summary>
    public TerraformValue<double> RuleTupleCount
    {
        get => new TerraformReference<double>(this, "rule_tuple_count");
    }

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformValue<string> SelfLinkWithId
    {
        get => new TerraformReference<string>(this, "self_link_with_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionNetworkFirewallPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionNetworkFirewallPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
