using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allow in GoogleComputeFirewall.
/// Nesting mode: set
/// </summary>
public class GoogleComputeFirewallAllowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allow";

    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// 
    /// Example inputs include: [22], [80, 443], and
    /// [&amp;quot;12345-12349&amp;quot;].
    /// </summary>
    public TerraformList<string>? Ports
    {
        get => GetArgument<TerraformList<string>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for deny in GoogleComputeFirewall.
/// Nesting mode: set
/// </summary>
public class GoogleComputeFirewallDenyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deny";

    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// 
    /// Example inputs include: [22], [80, 443], and
    /// [&amp;quot;12345-12349&amp;quot;].
    /// </summary>
    public TerraformList<string>? Ports
    {
        get => GetArgument<TerraformList<string>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for log_config in GoogleComputeFirewall.
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_config";

    /// <summary>
    /// This field denotes whether to include or exclude metadata for firewall logs. Possible values: [&amp;quot;EXCLUDE_ALL_METADATA&amp;quot;, &amp;quot;INCLUDE_ALL_METADATA&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    public required TerraformValue<string> Metadata
    {
        get => GetRequiredArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}


/// <summary>
/// Block type for params in GoogleComputeFirewall.
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallParamsAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "params";

    /// <summary>
    /// Resource manager tags to be bound to the firewall. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
    /// </summary>
    public TerraformMap<string>? ResourceManagerTags
    {
        get => GetArgument<TerraformMap<string>>("resource_manager_tags");
        set => SetArgument("resource_manager_tags", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeFirewall.
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_firewall Terraform resource.
/// Manages a google_compute_firewall resource.
/// </summary>
public partial class GoogleComputeFirewall(string name) : TerraformResource("google_compute_firewall", name)
{
    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// If destination ranges are specified, the firewall will apply only to
    /// traffic that has destination IP address in these ranges. These ranges
    /// must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.
    /// </summary>
    public TerraformSet<string> DestinationRanges
    {
        get => GetArgument<TerraformSet<string>>("destination_ranges") ?? CreateReference("destination_ranges");
        set => SetArgument("destination_ranges", value);
    }

    /// <summary>
    /// Direction of traffic to which this firewall applies; default is
    /// INGRESS. Note: For INGRESS traffic, one of &#39;source_ranges&#39;,
    /// &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    public TerraformValue<string> Direction
    {
        get => GetArgument<TerraformValue<string>>("direction") ?? CreateReference("direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall rule is disabled, i.e not applied to the
    /// network it is associated with. When set to true, the firewall rule is
    /// not enforced and the network behaves as if it did not exist. If this
    /// is unspecified, the firewall rule will be enabled.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// This field denotes whether to enable logging for a particular firewall rule. If logging is enabled, logs will be exported to Stackdriver.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool> EnableLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_logging") ?? CreateReference("enable_logging");
        set => SetArgument("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name or self_link of the network to attach this firewall to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Priority for this rule. This is an integer between 0 and 65535, both
    /// inclusive. When not specified, the value assumed is 1000. Relative
    /// priorities determine precedence of conflicting rules. Lower value of
    /// priority implies higher precedence (eg, a rule with priority 0 has
    /// higher precedence than a rule with priority 1). DENY rules take
    /// precedence over ALLOW rules having equal priority.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// If source ranges are specified, the firewall will apply only to
    /// traffic that has source IP address in these ranges. These ranges must
    /// be expressed in CIDR format. One or both of sourceRanges and
    /// sourceTags may be set. If both properties are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP that belongs to a tag listed in the sourceTags property. The
    /// connection does not need to match both properties for the firewall to
    /// apply. IPv4 or IPv6 ranges are supported. For INGRESS traffic, one of
    /// &#39;source_ranges&#39;, &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required.
    /// </summary>
    public TerraformSet<string>? SourceRanges
    {
        get => GetArgument<TerraformSet<string>>("source_ranges");
        set => SetArgument("source_ranges", value);
    }

    /// <summary>
    /// If source service accounts are specified, the firewall will apply only
    /// to traffic originating from an instance with a service account in this
    /// list. Source service accounts cannot be used to control traffic to an
    /// instance&#39;s external IP address because service accounts are associated
    /// with an instance, not an IP address. sourceRanges can be set at the
    /// same time as sourceServiceAccounts. If both are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP belongs to an instance with service account listed in
    /// sourceServiceAccount. The connection does not need to match both
    /// properties for the firewall to apply. sourceServiceAccounts cannot be
    /// used at the same time as sourceTags or targetTags. For INGRESS traffic,
    /// one of &#39;source_ranges&#39;, &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required.
    /// </summary>
    public TerraformSet<string>? SourceServiceAccounts
    {
        get => GetArgument<TerraformSet<string>>("source_service_accounts");
        set => SetArgument("source_service_accounts", value);
    }

    /// <summary>
    /// If source tags are specified, the firewall will apply only to traffic
    /// with source IP that belongs to a tag listed in source tags. Source
    /// tags cannot be used to control traffic to an instance&#39;s external IP
    /// address. Because tags are associated with an instance, not an IP
    /// address. One or both of sourceRanges and sourceTags may be set. If
    /// both properties are set, the firewall will apply to traffic that has
    /// source IP address within sourceRanges OR the source IP that belongs to
    /// a tag listed in the sourceTags property. The connection does not need
    /// to match both properties for the firewall to apply. For INGRESS traffic,
    /// one of &#39;source_ranges&#39;, &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required.
    /// </summary>
    public TerraformSet<string>? SourceTags
    {
        get => GetArgument<TerraformSet<string>>("source_tags");
        set => SetArgument("source_tags", value);
    }

    /// <summary>
    /// A list of service accounts indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// targetServiceAccounts cannot be used at the same time as targetTags or
    /// sourceTags. If neither targetServiceAccounts nor targetTags are
    /// specified, the firewall rule applies to all instances on the specified
    /// network.
    /// </summary>
    public TerraformSet<string>? TargetServiceAccounts
    {
        get => GetArgument<TerraformSet<string>>("target_service_accounts");
        set => SetArgument("target_service_accounts", value);
    }

    /// <summary>
    /// A list of instance tags indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// If no targetTags are specified, the firewall rule applies to all
    /// instances on the specified network.
    /// </summary>
    public TerraformSet<string>? TargetTags
    {
        get => GetArgument<TerraformSet<string>>("target_tags");
        set => SetArgument("target_tags", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// Allow block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeFirewallAllowBlock>? Allow
    {
        get => GetArgument<TerraformSet<GoogleComputeFirewallAllowBlock>>("allow");
        set => SetArgument("allow", value);
    }

    /// <summary>
    /// Deny block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeFirewallDenyBlock>? Deny
    {
        get => GetArgument<TerraformSet<GoogleComputeFirewallDenyBlock>>("deny");
        set => SetArgument("deny", value);
    }

    /// <summary>
    /// LogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public TerraformList<GoogleComputeFirewallLogConfigBlock>? LogConfig
    {
        get => GetArgument<TerraformList<GoogleComputeFirewallLogConfigBlock>>("log_config");
        set => SetArgument("log_config", value);
    }

    /// <summary>
    /// ParamsAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParamsAttribute block(s) allowed")]
    public TerraformList<GoogleComputeFirewallParamsAttributeBlock>? ParamsAttribute
    {
        get => GetArgument<TerraformList<GoogleComputeFirewallParamsAttributeBlock>>("params");
        set => SetArgument("params", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeFirewallTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeFirewallTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
