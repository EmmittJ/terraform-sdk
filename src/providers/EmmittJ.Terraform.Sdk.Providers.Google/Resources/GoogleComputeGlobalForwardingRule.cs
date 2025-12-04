using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for metadata_filters in GoogleComputeGlobalForwardingRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeGlobalForwardingRuleMetadataFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_filters";

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of
    /// filterLabels contribute towards the overall metadataFilter match.
    /// 
    /// MATCH_ANY - At least one of the filterLabels must have a matching
    /// label in the provided metadata.
    /// MATCH_ALL - All filterLabels must have matching labels in the
    /// provided metadata. Possible values: [&amp;quot;MATCH_ANY&amp;quot;, &amp;quot;MATCH_ALL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterMatchCriteria is required")]
    public required TerraformValue<string> FilterMatchCriteria
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter_match_criteria");
        set => SetArgument("filter_match_criteria", value);
    }

    /// <summary>
    /// FilterLabels block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterLabels is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FilterLabels block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 FilterLabels block(s) allowed")]
    public required TerraformList<GoogleComputeGlobalForwardingRuleMetadataFiltersBlockFilterLabelsBlock> FilterLabels
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeGlobalForwardingRuleMetadataFiltersBlockFilterLabelsBlock>>("filter_labels");
        set => SetArgument("filter_labels", value);
    }

}

/// <summary>
/// Block type for filter_labels in GoogleComputeGlobalForwardingRuleMetadataFiltersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeGlobalForwardingRuleMetadataFiltersBlockFilterLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_labels";

    /// <summary>
    /// Name of the metadata label. The length must be between
    /// 1 and 1024 characters, inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value that the label must match. The value has a maximum
    /// length of 1024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for service_directory_registrations in GoogleComputeGlobalForwardingRule.
/// Nesting mode: list
/// </summary>
public class GoogleComputeGlobalForwardingRuleServiceDirectoryRegistrationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_directory_registrations";

    /// <summary>
    /// Service Directory namespace to register the forwarding rule under.
    /// </summary>
    public TerraformValue<string> NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace") ?? AsReference("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// [Optional] Service Directory region to register this global forwarding rule under.
    /// Default to &amp;quot;us-central1&amp;quot;. Only used for PSC for Google APIs. All PSC for
    /// Google APIs Forwarding Rules on the same network should use the same Service
    /// Directory region.
    /// </summary>
    public TerraformValue<string>? ServiceDirectoryRegion
    {
        get => GetArgument<TerraformValue<string>>("service_directory_region");
        set => SetArgument("service_directory_region", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeGlobalForwardingRule.
/// Nesting mode: single
/// </summary>
public class GoogleComputeGlobalForwardingRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_global_forwarding_rule Terraform resource.
/// Manages a google_compute_global_forwarding_rule resource.
/// </summary>
public partial class GoogleComputeGlobalForwardingRule(string name) : TerraformResource("google_compute_global_forwarding_rule", name)
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
    public TerraformValue<string>? ExternalManagedBackendBucketMigrationState
    {
        get => GetArgument<TerraformValue<string>>("external_managed_backend_bucket_migration_state");
        set => SetArgument("external_managed_backend_bucket_migration_state", value);
    }

    /// <summary>
    /// Determines the fraction of requests to backend buckets that should be processed by the Global
    /// external Application Load Balancer.
    /// 
    /// The value of this field must be in the range [0, 100].
    /// 
    /// This value can only be set if the loadBalancingScheme in the forwarding rule is set to
    /// EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.
    /// </summary>
    public TerraformValue<double>? ExternalManagedBackendBucketMigrationTestingPercentage
    {
        get => GetArgument<TerraformValue<double>>("external_managed_backend_bucket_migration_testing_percentage");
        set => SetArgument("external_managed_backend_bucket_migration_testing_percentage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

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
    public TerraformValue<string> IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address") ?? AsReference("ip_address");
        set => SetArgument("ip_address", value);
    }

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
    public TerraformValue<string> IpProtocol
    {
        get => GetArgument<TerraformValue<string>>("ip_protocol") ?? AsReference("ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The IP Version that will be used by this global forwarding rule. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IpVersion
    {
        get => GetArgument<TerraformValue<string>>("ip_version");
        set => SetArgument("ip_version", value);
    }

    /// <summary>
    /// Labels to apply to this forwarding rule.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Specifies the forwarding rule type.
    /// 
    /// For more information about forwarding rules, refer to
    /// [Forwarding rule concepts](https://cloud.google.com/load-balancing/docs/forwarding-rule-concepts). Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL_SELF_MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LoadBalancingScheme
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_scheme");
        set => SetArgument("load_balancing_scheme", value);
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

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
    {
        get => GetArgument<TerraformValue<string>>("network") ?? AsReference("network");
        set => SetArgument("network", value);
    }

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
    {
        get => GetArgument<TerraformValue<string>>("network_tier") ?? AsReference("network_tier");
        set => SetArgument("network_tier", value);
    }

    /// <summary>
    /// This is used in PSC consumer ForwardingRule to control whether it should try to auto-generate a DNS zone or not. Non-PSC forwarding rules do not use this field.
    /// </summary>
    public TerraformValue<bool>? NoAutomateDnsZone
    {
        get => GetArgument<TerraformValue<bool>>("no_automate_dns_zone");
        set => SetArgument("no_automate_dns_zone", value);
    }

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
    public TerraformValue<string>? PortRange
    {
        get => GetArgument<TerraformValue<string>>("port_range");
        set => SetArgument("port_range", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// If not empty, this Forwarding Rule will only forward the traffic when the source IP address matches one of the IP addresses or CIDR ranges set here. Note that a Forwarding Rule can only have up to 64 source IP ranges, and this field can only be used with a regional Forwarding Rule whose scheme is EXTERNAL. Each sourceIpRange entry should be either an IP address (for example, 1.2.3.4) or a CIDR range (for example, 1.2.3.0/24).
    /// </summary>
    public TerraformList<string>? SourceIpRanges
    {
        get => GetArgument<TerraformList<string>>("source_ip_ranges");
        set => SetArgument("source_ip_ranges", value);
    }

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
    {
        get => GetArgument<TerraformValue<string>>("subnetwork") ?? AsReference("subnetwork");
        set => SetArgument("subnetwork", value);
    }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => GetRequiredArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// [Output Only] The URL for the corresponding base Forwarding Rule. By base Forwarding Rule, we mean the Forwarding Rule that has the same IP address, protocol, and port settings with the current Forwarding Rule, but without sourceIPRanges specified. Always empty if the current Forwarding Rule does not have sourceIPRanges specified.
    /// </summary>
    public TerraformValue<string> BaseForwardingRule
        => AsReference("base_forwarding_rule");

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
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

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
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// MetadataFilters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeGlobalForwardingRuleMetadataFiltersBlock>? MetadataFilters
    {
        get => GetArgument<TerraformList<GoogleComputeGlobalForwardingRuleMetadataFiltersBlock>>("metadata_filters");
        set => SetArgument("metadata_filters", value);
    }

    /// <summary>
    /// ServiceDirectoryRegistrations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDirectoryRegistrations block(s) allowed")]
    public TerraformList<GoogleComputeGlobalForwardingRuleServiceDirectoryRegistrationsBlock>? ServiceDirectoryRegistrations
    {
        get => GetArgument<TerraformList<GoogleComputeGlobalForwardingRuleServiceDirectoryRegistrationsBlock>>("service_directory_registrations");
        set => SetArgument("service_directory_registrations", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeGlobalForwardingRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeGlobalForwardingRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
