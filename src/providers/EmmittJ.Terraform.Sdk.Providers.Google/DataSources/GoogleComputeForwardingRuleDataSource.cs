using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_forwarding_rule Terraform data source.
/// Retrieves information about a google_compute_forwarding_rule.
/// </summary>
public partial class GoogleComputeForwardingRuleDataSource(string name) : TerraformDataSource("google_compute_forwarding_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-63 characters long, and comply with
    /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
    /// 
    /// Specifically, the name must be 1-63 characters long and match the regular
    /// expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must
    /// be a dash, lowercase letter, or digit, except the last character, which
    /// cannot be a dash.
    /// 
    /// For Private Service Connect forwarding rules that forward traffic to Google
    /// APIs, the forwarding rule name must be a 1-20 characters string with
    /// lowercase letters and numbers and must start with a letter.
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
    /// A reference to the region where the regional forwarding rule resides.
    /// 
    /// This field is not applicable to global forwarding rules.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The &#39;ports&#39;, &#39;portRange&#39;, and &#39;allPorts&#39; fields are mutually exclusive.
    /// Only packets addressed to ports in the specified range will be forwarded
    /// to the backends configured with this forwarding rule.
    /// 
    /// The &#39;allPorts&#39; field has the following limitations:
    /// * It requires that the forwarding rule &#39;IPProtocol&#39; be TCP, UDP, SCTP, or
    /// L3_DEFAULT.
    /// * It&#39;s applicable only to the following products: internal passthrough
    /// Network Load Balancers, backend service-based external passthrough Network
    /// Load Balancers, and internal and external protocol forwarding.
    /// * Set this field to true to allow packets addressed to any port or packets
    /// lacking destination port information (for example, UDP fragments after the
    /// first fragment) to be forwarded to the backends configured with this
    /// forwarding rule. The L3_DEFAULT protocol requires &#39;allPorts&#39; be set to
    /// true.
    /// </summary>
    public TerraformValue<bool> AllPorts
        => AsReference("all_ports");

    /// <summary>
    /// This field is used along with the &#39;backend_service&#39; field for
    /// internal load balancing or with the &#39;target&#39; field for internal
    /// TargetInstance.
    /// 
    /// If the field is set to &#39;TRUE&#39;, clients can access ILB from all
    /// regions.
    /// 
    /// Otherwise only allows access from clients in the same region as the
    /// internal load balancer.
    /// </summary>
    public TerraformValue<bool> AllowGlobalAccess
        => AsReference("allow_global_access");

    /// <summary>
    /// This is used in PSC consumer ForwardingRule to control whether the PSC endpoint can be accessed from another region.
    /// </summary>
    public TerraformValue<bool> AllowPscGlobalAccess
        => AsReference("allow_psc_global_access");

    /// <summary>
    /// Identifies the backend service to which the forwarding rule sends traffic.
    /// 
    /// Required for Internal TCP/UDP Load Balancing and Network Load Balancing;
    /// must be omitted for all other load balancer types.
    /// </summary>
    public TerraformValue<string> BackendService
        => AsReference("backend_service");

    /// <summary>
    /// [Output Only] The URL for the corresponding base Forwarding Rule. By base Forwarding Rule, we mean the Forwarding Rule that has the same IP address, protocol, and port settings with the current Forwarding Rule, but without sourceIPRanges specified. Always empty if the current Forwarding Rule does not have sourceIPRanges specified.
    /// </summary>
    public TerraformValue<string> BaseForwardingRule
        => AsReference("base_forwarding_rule");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> ForwardingRuleId
        => AsReference("forwarding_rule_id");

    /// <summary>
    /// IP address for which this forwarding rule accepts traffic. When a client
    /// sends traffic to this IP address, the forwarding rule directs the traffic
    /// to the referenced &#39;target&#39; or &#39;backendService&#39;.
    /// 
    /// While creating a forwarding rule, specifying an &#39;IPAddress&#39; is
    /// required under the following circumstances:
    /// 
    /// * When the &#39;target&#39; is set to &#39;targetGrpcProxy&#39; and
    /// &#39;validateForProxyless&#39; is set to &#39;true&#39;, the
    /// &#39;IPAddress&#39; should be set to &#39;0.0.0.0&#39;.
    /// * When the &#39;target&#39; is a Private Service Connect Google APIs
    /// bundle, you must specify an &#39;IPAddress&#39;.
    /// 
    /// Otherwise, you can optionally specify an IP address that references an
    /// existing static (reserved) IP address resource. When omitted, Google Cloud
    /// assigns an ephemeral IP address.
    /// 
    /// Use one of the following formats to specify an IP address while creating a
    /// forwarding rule:
    /// 
    /// * IP address number, as in &#39;100.1.2.3&#39;
    /// * IPv6 address range, as in &#39;2600:1234::/96&#39;
    /// * Full resource URL, as in
    /// &#39;https://www.googleapis.com/compute/v1/projects/project_id/regions/region/addresses/address-name&#39;
    /// * Partial URL or by name, as in:
    ///   * &#39;projects/project_id/regions/region/addresses/address-name&#39;
    ///   * &#39;regions/region/addresses/address-name&#39;
    ///   * &#39;global/addresses/address-name&#39;
    ///   * &#39;address-name&#39;
    /// 
    /// The forwarding rule&#39;s &#39;target&#39; or &#39;backendService&#39;,
    /// and in most cases, also the &#39;loadBalancingScheme&#39;, determine the
    /// type of IP address that you can use. For detailed information, see
    /// [IP address
    /// specifications](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts#ip_address_specifications).
    /// 
    /// When reading an &#39;IPAddress&#39;, the API always returns the IP
    /// address number.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// Resource reference of a PublicDelegatedPrefix. The PDP must be a sub-PDP
    /// in EXTERNAL_IPV6_FORWARDING_RULE_CREATION mode.
    /// Use one of the following formats to specify a sub-PDP when creating an
    /// IPv6 NetLB forwarding rule using BYOIP:
    /// Full resource URL, as in:
    ///   * &#39;https://www.googleapis.com/compute/v1/projects/{{projectId}}/regions/{{region}}/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    /// Partial URL, as in:
    ///   * &#39;projects/{{projectId}}/regions/region/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    ///   * &#39;regions/{{region}}/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    /// </summary>
    public TerraformValue<string> IpCollection
        => AsReference("ip_collection");

    /// <summary>
    /// The IP protocol to which this rule applies.
    /// 
    /// For protocol forwarding, valid
    /// options are &#39;TCP&#39;, &#39;UDP&#39;, &#39;ESP&#39;,
    /// &#39;AH&#39;, &#39;SCTP&#39;, &#39;ICMP&#39; and
    /// &#39;L3_DEFAULT&#39;.
    /// 
    /// The valid IP protocols are different for different load balancing products
    /// as described in [Load balancing
    /// features](https://cloud.google.com/load-balancing/docs/features#protocols_from_the_load_balancer_to_the_backends).
    /// 
    /// A Forwarding Rule with protocol L3_DEFAULT can attach with target instance or
    /// backend service with UNSPECIFIED protocol.
    /// A forwarding rule with &amp;quot;L3_DEFAULT&amp;quot; IPProtocal cannot be attached to a backend service with TCP or UDP. Possible values: [&amp;quot;TCP&amp;quot;, &amp;quot;UDP&amp;quot;, &amp;quot;ESP&amp;quot;, &amp;quot;AH&amp;quot;, &amp;quot;SCTP&amp;quot;, &amp;quot;ICMP&amp;quot;, &amp;quot;L3_DEFAULT&amp;quot;]
    /// </summary>
    public TerraformValue<string> IpProtocol
        => AsReference("ip_protocol");

    /// <summary>
    /// The IP address version that will be used by this forwarding rule.
    /// Valid options are IPV4 and IPV6.
    /// 
    /// If not set, the IPv4 address will be used by default. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformValue<string> IpVersion
        => AsReference("ip_version");

    /// <summary>
    /// Indicates whether or not this load balancer can be used as a collector for
    /// packet mirroring. To prevent mirroring loops, instances behind this
    /// load balancer will not have their traffic mirrored even if a
    /// &#39;PacketMirroring&#39; rule applies to them.
    /// 
    /// This can only be set to true for load balancers that have their
    /// &#39;loadBalancingScheme&#39; set to &#39;INTERNAL&#39;.
    /// </summary>
    public TerraformValue<bool> IsMirroringCollector
        => AsReference("is_mirroring_collector");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// Labels to apply to this forwarding rule.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// Specifies the forwarding rule type.
    /// 
    /// Note that an empty string value (&#39;&amp;quot;&amp;quot;&#39;) is also supported for some use
    /// cases, for example PSC (private service connection) regional forwarding
    /// rules.
    /// 
    /// For more information about forwarding rules, refer to
    /// [Forwarding rule concepts](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts). Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string> LoadBalancingScheme
        => AsReference("load_balancing_scheme");

    /// <summary>
    /// This field is not used for external load balancing.
    /// 
    /// For Internal TCP/UDP Load Balancing, this field identifies the network that
    /// the load balanced IP should belong to for this Forwarding Rule.
    /// If the subnetwork is specified, the network of the subnetwork will be used.
    /// If neither subnetwork nor this field is specified, the default network will
    /// be used.
    /// 
    /// For Private Service Connect forwarding rules that forward traffic to Google
    /// APIs, a network must be provided.
    /// </summary>
    public TerraformValue<string> Network
        => AsReference("network");

    /// <summary>
    /// This signifies the networking tier used for configuring
    /// this load balancer and can only take the following values:
    /// &#39;PREMIUM&#39;, &#39;STANDARD&#39;.
    /// 
    /// For regional ForwardingRule, the valid values are &#39;PREMIUM&#39; and
    /// &#39;STANDARD&#39;. For GlobalForwardingRule, the valid value is
    /// &#39;PREMIUM&#39;.
    /// 
    /// If this field is not specified, it is assumed to be &#39;PREMIUM&#39;.
    /// If &#39;IPAddress&#39; is specified, this value must be equal to the
    /// networkTier of the Address. Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformValue<string> NetworkTier
        => AsReference("network_tier");

    /// <summary>
    /// This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.
    /// </summary>
    public TerraformValue<bool> NoAutomateDnsZone
        => AsReference("no_automate_dns_zone");

    /// <summary>
    /// The &#39;ports&#39;, &#39;portRange&#39;, and &#39;allPorts&#39; fields are mutually exclusive.
    /// Only packets addressed to ports in the specified range will be forwarded
    /// to the backends configured with this forwarding rule.
    /// 
    /// The &#39;portRange&#39; field has the following limitations:
    /// * It requires that the forwarding rule &#39;IPProtocol&#39; be TCP, UDP, or SCTP,
    /// and
    /// * It&#39;s applicable only to the following products: external passthrough
    /// Network Load Balancers, internal and external proxy Network Load
    /// Balancers, internal and external Application Load Balancers, external
    /// protocol forwarding, and Classic VPN.
    /// * Some products have restrictions on what ports can be used. See
    /// [port specifications](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts#port_specifications)
    /// for details.
    /// 
    /// For external forwarding rules, two or more forwarding rules cannot use the
    /// same &#39;[IPAddress, IPProtocol]&#39; pair, and cannot have overlapping
    /// &#39;portRange&#39;s.
    /// 
    /// For internal forwarding rules within the same VPC network, two or more
    /// forwarding rules cannot use the same &#39;[IPAddress, IPProtocol]&#39; pair, and
    /// cannot have overlapping &#39;portRange&#39;s.
    /// 
    /// @pattern: \d+(?:-\d+)?
    /// </summary>
    public TerraformValue<string> PortRange
        => AsReference("port_range");

    /// <summary>
    /// The &#39;ports&#39;, &#39;portRange&#39;, and &#39;allPorts&#39; fields are mutually exclusive.
    /// Only packets addressed to ports in the specified range will be forwarded
    /// to the backends configured with this forwarding rule.
    /// 
    /// The &#39;ports&#39; field has the following limitations:
    /// * It requires that the forwarding rule &#39;IPProtocol&#39; be TCP, UDP, or SCTP,
    /// and
    /// * It&#39;s applicable only to the following products: internal passthrough
    /// Network Load Balancers, backend service-based external passthrough Network
    /// Load Balancers, and internal protocol forwarding.
    /// * You can specify a list of up to five ports by number, separated by
    /// commas. The ports can be contiguous or discontiguous.
    /// 
    /// For external forwarding rules, two or more forwarding rules cannot use the
    /// same &#39;[IPAddress, IPProtocol]&#39; pair if they share at least one port
    /// number.
    /// 
    /// For internal forwarding rules within the same VPC network, two or more
    /// forwarding rules cannot use the same &#39;[IPAddress, IPProtocol]&#39; pair if
    /// they share at least one port number.
    /// 
    /// @pattern: \d+(?:-\d+)?
    /// </summary>
    public TerraformSet<string> Ports
        => AsReference("ports");

    /// <summary>
    /// The PSC connection id of the PSC Forwarding Rule.
    /// </summary>
    public TerraformValue<string> PscConnectionId
        => AsReference("psc_connection_id");

    /// <summary>
    /// The PSC connection status of the PSC Forwarding Rule. Possible values: &#39;STATUS_UNSPECIFIED&#39;, &#39;PENDING&#39;, &#39;ACCEPTED&#39;, &#39;REJECTED&#39;, &#39;CLOSED&#39;
    /// </summary>
    public TerraformValue<string> PscConnectionStatus
        => AsReference("psc_connection_status");

    /// <summary>
    /// This is used in PSC consumer ForwardingRule to make terraform recreate the ForwardingRule when the status is closed
    /// </summary>
    public TerraformValue<bool> RecreateClosedPsc
        => AsReference("recreate_closed_psc");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Service Directory resources to register this forwarding rule with.
    /// 
    /// Currently, only supports a single Service Directory resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceDirectoryRegistrations
        => AsReference("service_directory_registrations");

    /// <summary>
    /// An optional prefix to the service name for this Forwarding Rule.
    /// If specified, will be the first label of the fully qualified service
    /// name.
    /// 
    /// The label must be 1-63 characters long, and comply with RFC1035.
    /// Specifically, the label must be 1-63 characters long and match the
    /// regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters
    /// must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// 
    /// This field is only used for INTERNAL load balancing.
    /// </summary>
    public TerraformValue<string> ServiceLabel
        => AsReference("service_label");

    /// <summary>
    /// The internal fully qualified service name for this Forwarding Rule.
    /// 
    /// This field is only used for INTERNAL load balancing.
    /// </summary>
    public TerraformValue<string> ServiceName
        => AsReference("service_name");

    /// <summary>
    /// If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).
    /// </summary>
    public TerraformList<string> SourceIpRanges
        => AsReference("source_ip_ranges");

    /// <summary>
    /// This field identifies the subnetwork that the load balanced IP should
    /// belong to for this Forwarding Rule, used in internal load balancing and
    /// network load balancing with IPv6.
    /// 
    /// If the network specified is in auto subnet mode, this field is optional.
    /// However, a subnetwork must be specified if the network is in custom subnet
    /// mode or when creating external forwarding rule with IPv6.
    /// </summary>
    public TerraformValue<string> Subnetwork
        => AsReference("subnetwork");

    /// <summary>
    /// The URL of the target resource to receive the matched traffic.  For
    /// regional forwarding rules, this target must be in the same region as the
    /// forwarding rule. For global forwarding rules, this target must be a global
    /// load balancing resource.
    /// 
    /// The forwarded traffic must be of a type appropriate to the target object.
    /// *  For load balancers, see the &amp;quot;Target&amp;quot; column in [Port specifications](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts#ip_address_specifications).
    /// 
    /// For Private Service Connect forwarding rules that forward traffic to managed services, the target must be a service attachment.
    /// </summary>
    public TerraformValue<string> Target
        => AsReference("target");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

}
