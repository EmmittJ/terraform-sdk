using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allow in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeFirewallAllowBlock : TerraformBlock
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
    public List<TerraformProperty<string>>? Ports
    {
        get => GetProperty<List<TerraformProperty<string>>>("ports");
        set => WithProperty("ports", value);
    }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

}

/// <summary>
/// Block type for deny in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeFirewallDenyBlock : TerraformBlock
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
    public List<TerraformProperty<string>>? Ports
    {
        get => GetProperty<List<TerraformProperty<string>>>("ports");
        set => WithProperty("ports", value);
    }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// This field denotes whether to include or exclude metadata for firewall logs. Possible values: [&amp;quot;EXCLUDE_ALL_METADATA&amp;quot;, &amp;quot;INCLUDE_ALL_METADATA&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    public required TerraformProperty<string> Metadata
    {
        get => GetProperty<TerraformProperty<string>>("metadata");
        set => WithProperty("metadata", value);
    }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeFirewallParamsBlock : TerraformBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the firewall. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceManagerTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_manager_tags");
        set => WithProperty("resource_manager_tags", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeFirewallTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_firewall resource.
/// </summary>
public class GoogleComputeFirewall : TerraformResource
{
    public GoogleComputeFirewall(string name) : base("google_compute_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// If destination ranges are specified, the firewall will apply only to
    /// traffic that has destination IP address in these ranges. These ranges
    /// must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DestinationRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("destination_ranges");
        set => this.WithProperty("destination_ranges", value);
    }

    /// <summary>
    /// Direction of traffic to which this firewall applies; default is
    /// INGRESS. Note: For INGRESS traffic, one of &#39;source_ranges&#39;,
    /// &#39;source_tags&#39; or &#39;source_service_accounts&#39; is required. Possible values: [&amp;quot;INGRESS&amp;quot;, &amp;quot;EGRESS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Direction
    {
        get => GetProperty<TerraformProperty<string>>("direction");
        set => this.WithProperty("direction", value);
    }

    /// <summary>
    /// Denotes whether the firewall rule is disabled, i.e not applied to the
    /// network it is associated with. When set to true, the firewall rule is
    /// not enforced and the network behaves as if it did not exist. If this
    /// is unspecified, the firewall rule will be enabled.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// This field denotes whether to enable logging for a particular firewall rule. If logging is enabled, logs will be exported to Stackdriver.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? EnableLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_logging");
        set => this.WithProperty("enable_logging", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name or self_link of the network to attach this firewall to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// Priority for this rule. This is an integer between 0 and 65535, both
    /// inclusive. When not specified, the value assumed is 1000. Relative
    /// priorities determine precedence of conflicting rules. Lower value of
    /// priority implies higher precedence (eg, a rule with priority 0 has
    /// higher precedence than a rule with priority 1). DENY rules take
    /// precedence over ALLOW rules having equal priority.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public HashSet<TerraformProperty<string>>? SourceRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_ranges");
        set => this.WithProperty("source_ranges", value);
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
    public HashSet<TerraformProperty<string>>? SourceServiceAccounts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_service_accounts");
        set => this.WithProperty("source_service_accounts", value);
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
    public HashSet<TerraformProperty<string>>? SourceTags
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("source_tags");
        set => this.WithProperty("source_tags", value);
    }

    /// <summary>
    /// A list of service accounts indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// targetServiceAccounts cannot be used at the same time as targetTags or
    /// sourceTags. If neither targetServiceAccounts nor targetTags are
    /// specified, the firewall rule applies to all instances on the specified
    /// network.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TargetServiceAccounts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("target_service_accounts");
        set => this.WithProperty("target_service_accounts", value);
    }

    /// <summary>
    /// A list of instance tags indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// If no targetTags are specified, the firewall rule applies to all
    /// instances on the specified network.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TargetTags
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("target_tags");
        set => this.WithProperty("target_tags", value);
    }

    /// <summary>
    /// Block for allow.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeFirewallAllowBlock>? Allow
    {
        get => GetProperty<HashSet<GoogleComputeFirewallAllowBlock>>("allow");
        set => this.WithProperty("allow", value);
    }

    /// <summary>
    /// Block for deny.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeFirewallDenyBlock>? Deny
    {
        get => GetProperty<HashSet<GoogleComputeFirewallDenyBlock>>("deny");
        set => this.WithProperty("deny", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<GoogleComputeFirewallLogConfigBlock>? LogConfig
    {
        get => GetProperty<List<GoogleComputeFirewallLogConfigBlock>>("log_config");
        set => this.WithProperty("log_config", value);
    }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    public List<GoogleComputeFirewallParamsBlock>? Params
    {
        get => GetProperty<List<GoogleComputeFirewallParamsBlock>>("params");
        set => this.WithProperty("params", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeFirewallTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeFirewallTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
