using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_global_forwarding_rule.
/// </summary>
public class GoogleComputeGlobalForwardingRuleDataSource : TerraformDataSource
{
    public GoogleComputeGlobalForwardingRuleDataSource(string name) : base("google_compute_global_forwarding_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// [Output Only] The URL for the corresponding base Forwarding Rule. By base Forwarding Rule, we mean the Forwarding Rule that has the same IP address, protocol, and port settings with the current Forwarding Rule, but without sourceIPRanges specified. Always empty if the current Forwarding Rule does not have sourceIPRanges specified.
    /// </summary>
    [TerraformPropertyName("base_forwarding_rule")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BaseForwardingRule => new TerraformReference(this, "base_forwarding_rule");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Specifies the canary migration state for the backend buckets attached to this forwarding rule.
    /// Possible values are PREPARE, TEST_BY_PERCENTAGE, and TEST_ALL_TRAFFIC.
    /// 
    /// To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to
    /// PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be
    /// changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate
    /// traffic to backend buckets attached to this forwarding rule by percentage using
    /// externalManagedBackendBucketMigrationTestingPercentage.
    /// 
    /// Rolling back a migration requires the states to be set in reverse order. So changing the
    /// scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at
    /// the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic
    /// back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL. Possible values: [&amp;quot;PREPARE&amp;quot;, &amp;quot;TEST_BY_PERCENTAGE&amp;quot;, &amp;quot;TEST_ALL_TRAFFIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("external_managed_backend_bucket_migration_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExternalManagedBackendBucketMigrationState => new TerraformReference(this, "external_managed_backend_bucket_migration_state");

    /// <summary>
    /// Determines the fraction of requests to backend buckets that should be processed by the Global
    /// external Application Load Balancer.
    /// 
    /// The value of this field must be in the range [0, 100].
    /// 
    /// This value can only be set if the loadBalancingScheme in the forwarding rule is set to
    /// EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.
    /// </summary>
    [TerraformPropertyName("external_managed_backend_bucket_migration_testing_percentage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ExternalManagedBackendBucketMigrationTestingPercentage => new TerraformReference(this, "external_managed_backend_bucket_migration_testing_percentage");

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("forwarding_rule_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ForwardingRuleId => new TerraformReference(this, "forwarding_rule_id");

    /// <summary>
    /// IP address for which this forwarding rule accepts traffic. When a client
    /// sends traffic to this IP address, the forwarding rule directs the traffic
    /// to the referenced &#39;target&#39;.
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
    /// The forwarding rule&#39;s &#39;target&#39;,
    /// and in most cases, also the &#39;loadBalancingScheme&#39;, determine the
    /// type of IP address that you can use. For detailed information, see
    /// [IP address
    /// specifications](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts#ip_address_specifications).
    /// 
    /// When reading an &#39;IPAddress&#39;, the API always returns the IP
    /// address number.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddress => new TerraformReference(this, "ip_address");

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
    /// features](https://cloud.google.com/load-balancing/docs/features#protocols_from_the_load_balancer_to_the_backends). Possible values: [&amp;quot;TCP&amp;quot;, &amp;quot;UDP&amp;quot;, &amp;quot;ESP&amp;quot;, &amp;quot;AH&amp;quot;, &amp;quot;SCTP&amp;quot;, &amp;quot;ICMP&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ip_protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpProtocol => new TerraformReference(this, "ip_protocol");

    /// <summary>
    /// The IP Version that will be used by this global forwarding rule. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ip_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpVersion => new TerraformReference(this, "ip_version");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// Labels to apply to this forwarding rule.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// Specifies the forwarding rule type.
    /// 
    /// For more information about forwarding rules, refer to
    /// [Forwarding rule concepts](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts). Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL_SELF_MANAGED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("load_balancing_scheme")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoadBalancingScheme => new TerraformReference(this, "load_balancing_scheme");

    /// <summary>
    /// Opaque filter criteria used by Loadbalancer to restrict routing
    /// configuration to a limited set xDS compliant clients. In their xDS
    /// requests to Loadbalancer, xDS clients present node metadata. If a
    /// match takes place, the relevant routing configuration is made available
    /// to those proxies.
    /// 
    /// For each metadataFilter in this list, if its filterMatchCriteria is set
    /// to MATCH_ANY, at least one of the filterLabels must match the
    /// corresponding label provided in the metadata. If its filterMatchCriteria
    /// is set to MATCH_ALL, then all of its filterLabels must match with
    /// corresponding labels in the provided metadata.
    /// 
    /// metadataFilters specified here can be overridden by those specified in
    /// the UrlMap that this ForwardingRule references.
    /// 
    /// metadataFilters only applies to Loadbalancers that have their
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// </summary>
    [TerraformPropertyName("metadata_filters")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MetadataFilters => new TerraformReference(this, "metadata_filters");

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
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Network => new TerraformReference(this, "network");

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
    [TerraformPropertyName("network_tier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkTier => new TerraformReference(this, "network_tier");

    /// <summary>
    /// This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.
    /// </summary>
    [TerraformPropertyName("no_automate_dns_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> NoAutomateDnsZone => new TerraformReference(this, "no_automate_dns_zone");

    /// <summary>
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
    [TerraformPropertyName("port_range")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortRange => new TerraformReference(this, "port_range");

    /// <summary>
    /// The PSC connection id of the PSC Forwarding Rule.
    /// </summary>
    [TerraformPropertyName("psc_connection_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PscConnectionId => new TerraformReference(this, "psc_connection_id");

    /// <summary>
    /// The PSC connection status of the PSC Forwarding Rule. Possible values: &#39;STATUS_UNSPECIFIED&#39;, &#39;PENDING&#39;, &#39;ACCEPTED&#39;, &#39;REJECTED&#39;, &#39;CLOSED&#39;
    /// </summary>
    [TerraformPropertyName("psc_connection_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PscConnectionStatus => new TerraformReference(this, "psc_connection_status");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Service Directory resources to register this forwarding rule with.
    /// 
    /// Currently, only supports a single Service Directory resource.
    /// </summary>
    [TerraformPropertyName("service_directory_registrations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServiceDirectoryRegistrations => new TerraformReference(this, "service_directory_registrations");

    /// <summary>
    /// If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).
    /// </summary>
    [TerraformPropertyName("source_ip_ranges")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SourceIpRanges => new TerraformReference(this, "source_ip_ranges");

    /// <summary>
    /// This field identifies the subnetwork that the load balanced IP should
    /// belong to for this Forwarding Rule, used in internal load balancing and
    /// network load balancing with IPv6.
    /// 
    /// If the network specified is in auto subnet mode, this field is optional.
    /// However, a subnetwork must be specified if the network is in custom subnet
    /// mode or when creating external forwarding rule with IPv6.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Subnetwork => new TerraformReference(this, "subnetwork");

    /// <summary>
    /// The URL of the target resource to receive the matched traffic.  For
    /// regional forwarding rules, this target must be in the same region as the
    /// forwarding rule. For global forwarding rules, this target must be a global
    /// load balancing resource.
    /// 
    /// The forwarded traffic must be of a type appropriate to the target object.
    /// *  For load balancers, see the &amp;quot;Target&amp;quot; column in [Port specifications](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts#ip_address_specifications).
    /// *  For Private Service Connect forwarding rules that forward traffic to Google APIs, provide the name of a supported Google API bundle:
    ///   *  &#39;vpc-sc&#39; - [ APIs that support VPC Service Controls](https://cloud.google.com/vpc-service-controls/docs/supported-products).
    ///   *  &#39;all-apis&#39; - [All supported Google APIs](https://cloud.google.com/vpc/docs/private-service-connect#supported-apis).
    /// 
    /// For Private Service Connect forwarding rules that forward traffic to managed services, the target must be a service attachment.
    /// </summary>
    [TerraformPropertyName("target")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Target => new TerraformReference(this, "target");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
