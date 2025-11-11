using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allow in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeFirewallAllowBlock
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// 
    /// Example inputs include: [22], [80, 443], and
    /// [&amp;quot;12345-12349&amp;quot;].
    /// </summary>
    [TerraformPropertyName("ports")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Block type for deny in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeFirewallDenyBlock
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// 
    /// Example inputs include: [22], [80, 443], and
    /// [&amp;quot;12345-12349&amp;quot;].
    /// </summary>
    [TerraformPropertyName("ports")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallLogConfigBlock
{
    /// <summary>
    /// This field denotes whether to include or exclude metadata for firewall logs. Possible values: [&amp;quot;EXCLUDE_ALL_METADATA&amp;quot;, &amp;quot;INCLUDE_ALL_METADATA&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    [TerraformPropertyName("metadata")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Metadata { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallParamsBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the firewall. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_firewall resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeFirewall : TerraformResource
{
    public GoogleComputeFirewall(string name) : base("google_compute_firewall", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If destination ranges are specified, the firewall will apply only to
    /// traffic that has destination IP address in these ranges. These ranges
    /// must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.
    /// </summary>
    [TerraformPropertyName("destination_ranges")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> DestinationRanges { get; set; } = default!;

    /// <summary>
    /// Direction of traffic to which this firewall applies; default is
    /// INGRESS. Note: For INGRESS traffic, one of &#39;source_ranges&#39;,
    /// &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("direction")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Direction { get; set; } = default!;

    /// <summary>
    /// Denotes whether the firewall rule is disabled, i.e not applied to the
    /// network it is associated with. When set to true, the firewall rule is
    /// not enforced and the network behaves as if it did not exist. If this
    /// is unspecified, the firewall rule will be enabled.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// This field denotes whether to enable logging for a particular firewall rule. If logging is enabled, logs will be exported to Stackdriver.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_logging")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableLogging { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name or self_link of the network to attach this firewall to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Priority for this rule. This is an integer between 0 and 65535, both
    /// inclusive. When not specified, the value assumed is 1000. Relative
    /// priorities determine precedence of conflicting rules. Lower value of
    /// priority implies higher precedence (eg, a rule with priority 0 has
    /// higher precedence than a rule with priority 1). DENY rules take
    /// precedence over ALLOW rules having equal priority.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

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
    [TerraformPropertyName("source_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SourceRanges { get; set; }

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
    [TerraformPropertyName("source_service_accounts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SourceServiceAccounts { get; set; }

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
    [TerraformPropertyName("source_tags")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SourceTags { get; set; }

    /// <summary>
    /// A list of service accounts indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// targetServiceAccounts cannot be used at the same time as targetTags or
    /// sourceTags. If neither targetServiceAccounts nor targetTags are
    /// specified, the firewall rule applies to all instances on the specified
    /// network.
    /// </summary>
    [TerraformPropertyName("target_service_accounts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// A list of instance tags indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// If no targetTags are specified, the firewall rule applies to all
    /// instances on the specified network.
    /// </summary>
    [TerraformPropertyName("target_tags")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? TargetTags { get; set; }

    /// <summary>
    /// Block for allow.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("allow")]
    public TerraformSet<TerraformBlock<GoogleComputeFirewallAllowBlock>>? Allow { get; set; }

    /// <summary>
    /// Block for deny.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("deny")]
    public TerraformSet<TerraformBlock<GoogleComputeFirewallDenyBlock>>? Deny { get; set; }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformPropertyName("log_config")]
    public TerraformList<TerraformBlock<GoogleComputeFirewallLogConfigBlock>>? LogConfig { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeFirewallParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeFirewallTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

}
