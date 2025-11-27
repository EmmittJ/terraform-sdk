using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination_ip_ranges in GoogleVmwareengineExternalAccessRule.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_ip_ranges";

    /// <summary>
    /// The name of an &#39;ExternalAddress&#39; resource.
    /// </summary>
    public TerraformValue<string>? ExternalAddress
    {
        get => new TerraformReference<string>(this, "external_address");
        set => SetArgument("external_address", value);
    }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    public TerraformValue<string>? IpAddressRange
    {
        get => new TerraformReference<string>(this, "ip_address_range");
        set => SetArgument("ip_address_range", value);
    }

}


/// <summary>
/// Block type for source_ip_ranges in GoogleVmwareengineExternalAccessRule.
/// Nesting mode: list
/// </summary>
public class GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_ip_ranges";

    /// <summary>
    /// A single IP address.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// An IP address range in the CIDR format.
    /// </summary>
    public TerraformValue<string>? IpAddressRange
    {
        get => new TerraformReference<string>(this, "ip_address_range");
        set => SetArgument("ip_address_range", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleVmwareengineExternalAccessRule.
/// Nesting mode: single
/// </summary>
public class GoogleVmwareengineExternalAccessRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_vmwareengine_external_access_rule Terraform resource.
/// Manages a google_vmwareengine_external_access_rule resource.
/// </summary>
public partial class GoogleVmwareengineExternalAccessRule(string name) : TerraformResource("google_vmwareengine_external_access_rule", name)
{
    /// <summary>
    /// The action that the external access rule performs. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// User-provided description for the external access rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A list of destination ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    public TerraformList<string>? DestinationPorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "destination_ports").ResolveNodes(ctx));
        set => SetArgument("destination_ports", value);
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
    /// The IP protocol to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => new TerraformReference<string>(this, "ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The ID of the external access rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource name of the network policy.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/networkPolicies/my-policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// External access rule priority, which determines the external access rule to use when multiple rules apply.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// A list of source ports to which the external access rule applies.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePorts is required")]
    public TerraformList<string>? SourcePorts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "source_ports").ResolveNodes(ctx));
        set => SetArgument("source_ports", value);
    }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// State of the Cluster.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// DestinationIpRanges block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationIpRanges block(s) required")]
    public required TerraformList<GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock> DestinationIpRanges
    {
        get => GetRequiredArgument<TerraformList<GoogleVmwareengineExternalAccessRuleDestinationIpRangesBlock>>("destination_ip_ranges");
        set => SetArgument("destination_ip_ranges", value);
    }

    /// <summary>
    /// SourceIpRanges block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIpRanges is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceIpRanges block(s) required")]
    public required TerraformList<GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock> SourceIpRanges
    {
        get => GetRequiredArgument<TerraformList<GoogleVmwareengineExternalAccessRuleSourceIpRangesBlock>>("source_ip_ranges");
        set => SetArgument("source_ip_ranges", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleVmwareengineExternalAccessRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleVmwareengineExternalAccessRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
