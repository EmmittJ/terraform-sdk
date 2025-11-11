using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSubnetworkLogConfigBlock
{
    /// <summary>
    /// Can only be specified if VPC flow logging for this subnetwork is enabled.
    /// Toggles the aggregation interval for collecting flow logs. Increasing the
    /// interval time will reduce the amount of generated flow logs for long
    /// lasting connections. Default is an interval of 5 seconds per connection. Default value: &amp;quot;INTERVAL_5_SEC&amp;quot; Possible values: [&amp;quot;INTERVAL_5_SEC&amp;quot;, &amp;quot;INTERVAL_30_SEC&amp;quot;, &amp;quot;INTERVAL_1_MIN&amp;quot;, &amp;quot;INTERVAL_5_MIN&amp;quot;, &amp;quot;INTERVAL_10_MIN&amp;quot;, &amp;quot;INTERVAL_15_MIN&amp;quot;]
    /// </summary>
    [TerraformPropertyName("aggregation_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AggregationInterval { get; set; }

    /// <summary>
    /// Export filter used to define which VPC flow logs should be logged, as as CEL expression. See
    /// https://cloud.google.com/vpc/docs/flow-logs#filtering for details on how to format this field.
    /// The default value is &#39;true&#39;, which evaluates to include everything.
    /// </summary>
    [TerraformPropertyName("filter_expr")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FilterExpr { get; set; }

    /// <summary>
    /// Can only be specified if VPC flow logging for this subnetwork is enabled.
    /// The value of the field must be in [0, 1]. Set the sampling rate of VPC
    /// flow logs within the subnetwork where 1.0 means all collected logs are
    /// reported and 0.0 means no logs are reported. Default is 0.5 which means
    /// half of all collected logs are reported.
    /// </summary>
    [TerraformPropertyName("flow_sampling")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FlowSampling { get; set; }

    /// <summary>
    /// Can only be specified if VPC flow logging for this subnetwork is enabled.
    /// Configures whether metadata fields should be added to the reported VPC
    /// flow logs. Default value: &amp;quot;INCLUDE_ALL_METADATA&amp;quot; Possible values: [&amp;quot;EXCLUDE_ALL_METADATA&amp;quot;, &amp;quot;INCLUDE_ALL_METADATA&amp;quot;, &amp;quot;CUSTOM_METADATA&amp;quot;]
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Metadata { get; set; }

    /// <summary>
    /// List of metadata fields that should be added to reported logs.
    /// Can only be specified if VPC flow logs for this subnetwork is enabled and &amp;quot;metadata&amp;quot; is set to CUSTOM_METADATA.
    /// </summary>
    [TerraformPropertyName("metadata_fields")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? MetadataFields { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSubnetworkParamsBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the subnetwork. Tag keys and values have the
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
/// Block type for secondary_ip_range in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeSubnetworkSecondaryIpRangeBlock
{
    /// <summary>
    /// The range of IP addresses belonging to this subnetwork secondary
    /// range. Provide this property when you create the subnetwork.
    /// Ranges must be unique and non-overlapping with all primary and
    /// secondary IP ranges within a network. Only IPv4 is supported.
    /// Field is optional when &#39;reserved_internal_range&#39; is defined, otherwise required.
    /// </summary>
    [TerraformPropertyName("ip_cidr_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpCidrRange { get; set; } = default!;

    /// <summary>
    /// The name associated with this subnetwork secondary range, used
    /// when adding an alias IP range to a VM instance. The name must
    /// be 1-63 characters long, and comply with RFC1035. The name
    /// must be unique within the subnetwork.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RangeName is required")]
    [TerraformPropertyName("range_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RangeName { get; set; }

    /// <summary>
    /// The ID of the reserved internal range. Must be prefixed with &#39;networkconnectivity.googleapis.com&#39;
    /// E.g. &#39;networkconnectivity.googleapis.com/projects/{project}/locations/global/internalRanges/{rangeId}&#39;
    /// </summary>
    [TerraformPropertyName("reserved_internal_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReservedInternalRange { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeSubnetworkTimeoutsBlock
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
/// Manages a google_compute_subnetwork resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeSubnetwork : TerraformResource
{
    public GoogleComputeSubnetwork(string name) : base("google_compute_subnetwork", name)
    {
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource. This field can be set only at resource
    /// creation time.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The range of external IPv6 addresses that are owned by this subnetwork.
    /// </summary>
    [TerraformPropertyName("external_ipv6_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExternalIpv6Prefix { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The range of internal addresses that are owned by this subnetwork.
    /// Provide this property when you create the subnetwork. For example,
    /// 10.0.0.0/8 or 192.168.0.0/16. Ranges must be unique and
    /// non-overlapping within a network. Only IPv4 is supported.
    /// Field is optional when &#39;reserved_internal_range&#39; is defined, otherwise required.
    /// </summary>
    [TerraformPropertyName("ip_cidr_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpCidrRange { get; set; } = default!;

    /// <summary>
    /// Resource reference of a PublicDelegatedPrefix. The PDP must be a sub-PDP
    /// in EXTERNAL_IPV6_SUBNETWORK_CREATION mode.
    /// Use one of the following formats to specify a sub-PDP when creating an
    /// IPv6 NetLB forwarding rule using BYOIP:
    /// Full resource URL, as in:
    ///   * &#39;https://www.googleapis.com/compute/v1/projects/{{projectId}}/regions/{{region}}/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    /// Partial URL, as in:
    ///   * &#39;projects/{{projectId}}/regions/region/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    ///   * &#39;regions/{{region}}/publicDelegatedPrefixes/{{sub-pdp-name}}&#39;
    /// </summary>
    [TerraformPropertyName("ip_collection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpCollection { get; set; }

    /// <summary>
    /// The access type of IPv6 address this subnet holds. It&#39;s immutable and can only be specified during creation
    /// or the first time the subnet is updated into IPV4_IPV6 dual stack. If the ipv6_type is EXTERNAL then this subnet
    /// cannot enable direct path. Possible values: [&amp;quot;EXTERNAL&amp;quot;, &amp;quot;INTERNAL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ipv6_access_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv6AccessType { get; set; }

    /// <summary>
    /// The name of the resource, provided by the client when initially
    /// creating the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which
    /// means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network this subnet belongs to.
    /// Only networks that are in the distributed mode can have subnetworks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// When enabled, VMs in this subnetwork without external IP addresses can
    /// access Google APIs and services by using Private Google Access.
    /// </summary>
    [TerraformPropertyName("private_ip_google_access")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> PrivateIpGoogleAccess { get; set; } = default!;

    /// <summary>
    /// The private IPv6 google access type for the VMs in this subnet.
    /// </summary>
    [TerraformPropertyName("private_ipv6_google_access")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateIpv6GoogleAccess { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The purpose of the resource. This field can be either &#39;PRIVATE&#39;, &#39;REGIONAL_MANAGED_PROXY&#39;, &#39;GLOBAL_MANAGED_PROXY&#39;, &#39;PRIVATE_SERVICE_CONNECT&#39;, &#39;PEER_MIGRATION&#39; or &#39;PRIVATE_NAT&#39;([Beta](https://terraform.io/docs/providers/google/guides/provider_versions.html)).
    /// A subnet with purpose set to &#39;REGIONAL_MANAGED_PROXY&#39; is a user-created subnetwork that is reserved for regional Envoy-based load balancers.
    /// A subnetwork in a given region with purpose set to &#39;GLOBAL_MANAGED_PROXY&#39; is a proxy-only subnet and is shared between all the cross-regional Envoy-based load balancers.
    /// A subnetwork with purpose set to &#39;PRIVATE_SERVICE_CONNECT&#39; reserves the subnet for hosting a Private Service Connect published service.
    /// A subnetwork with purpose set to &#39;PEER_MIGRATION&#39; is a user created subnetwork that is reserved for migrating resources from one peered network to another.
    /// A subnetwork with purpose set to &#39;PRIVATE_NAT&#39; is used as source range for Private NAT gateways.
    /// Note that &#39;REGIONAL_MANAGED_PROXY&#39; is the preferred setting for all regional Envoy load balancers.
    /// If unspecified, the purpose defaults to &#39;PRIVATE&#39;.
    /// </summary>
    [TerraformPropertyName("purpose")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Purpose { get; set; } = default!;

    /// <summary>
    /// The GCP region for this subnetwork.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The ID of the reserved internal range. Must be prefixed with &#39;networkconnectivity.googleapis.com&#39;
    /// E.g. &#39;networkconnectivity.googleapis.com/projects/{project}/locations/global/internalRanges/{rangeId}&#39;
    /// </summary>
    [TerraformPropertyName("reserved_internal_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReservedInternalRange { get; set; }

    /// <summary>
    /// The role of subnetwork.
    /// Currently, this field is only used when &#39;purpose&#39; is &#39;REGIONAL_MANAGED_PROXY&#39;.
    /// The value can be set to &#39;ACTIVE&#39; or &#39;BACKUP&#39;.
    /// An &#39;ACTIVE&#39; subnetwork is one that is currently being used for Envoy-based load balancers in a region.
    /// A &#39;BACKUP&#39; subnetwork is one that is ready to be promoted to &#39;ACTIVE&#39; or is currently draining. Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;BACKUP&amp;quot;]
    /// </summary>
    [TerraformPropertyName("role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Role { get; set; }

    /// <summary>
    /// Controls the removal behavior of secondary_ip_range.
    /// When false, removing secondary_ip_range from config will not produce a diff as
    /// the provider will default to the API&#39;s value.
    /// When true, the provider will treat removing secondary_ip_range as sending an
    /// empty list of secondary IP ranges to the API.
    /// Defaults to false.
    /// </summary>
    [TerraformPropertyName("send_secondary_ip_range_if_empty")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SendSecondaryIpRangeIfEmpty { get; set; }

    /// <summary>
    /// The stack type for this subnet to identify whether the IPv6 feature is enabled or not.
    /// If not specified IPV4_ONLY will be used. Possible values: [&amp;quot;IPV4_ONLY&amp;quot;, &amp;quot;IPV4_IPV6&amp;quot;, &amp;quot;IPV6_ONLY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("stack_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StackType { get; set; } = default!;

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    [TerraformPropertyName("log_config")]
    public TerraformList<TerraformBlock<GoogleComputeSubnetworkLogConfigBlock>>? LogConfig { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeSubnetworkParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for secondary_ip_range.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("secondary_ip_range")]
    public TerraformList<TerraformBlock<GoogleComputeSubnetworkSecondaryIpRangeBlock>>? SecondaryIpRange { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeSubnetworkTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during updates of this resource.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fingerprint => new TerraformReference(this, "fingerprint");

    /// <summary>
    /// The gateway address for default routes to reach destination addresses
    /// outside this subnetwork.
    /// </summary>
    [TerraformPropertyName("gateway_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayAddress => new TerraformReference(this, "gateway_address");

    /// <summary>
    /// The internal IPv6 address range that is assigned to this subnetwork.
    /// </summary>
    [TerraformPropertyName("internal_ipv6_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InternalIpv6Prefix => new TerraformReference(this, "internal_ipv6_prefix");

    /// <summary>
    /// The range of internal IPv6 addresses that are owned by this subnetwork.
    /// </summary>
    [TerraformPropertyName("ipv6_cidr_range")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6CidrRange => new TerraformReference(this, "ipv6_cidr_range");

    /// <summary>
    /// Possible endpoints of this subnetwork. It can be one of the following:
    ///   * VM_ONLY: The subnetwork can be used for creating instances and IPv6 addresses with VM endpoint type. Such a subnetwork
    ///   gets external IPv6 ranges from a public delegated prefix and cannot be used to create NetLb.
    ///   * VM_AND_FR: The subnetwork can be used for creating both VM instances and Forwarding Rules. It can also be used to reserve
    ///   IPv6 addresses with both VM and FR endpoint types. Such a subnetwork gets its IPv6 range from Google IP Pool directly.
    /// </summary>
    [TerraformPropertyName("ipv6_gce_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ipv6GceEndpoint => new TerraformReference(this, "ipv6_gce_endpoint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// &#39;The state of the subnetwork, which can be one of the following values:
    ///  READY: Subnetwork is created and ready to use DRAINING: only applicable to subnetworks that have the purpose
    ///  set to INTERNAL_HTTPS_LOAD_BALANCER and indicates that connections to the load balancer are being drained.
    ///  A subnetwork that is draining cannot be used or modified until it reaches a status of READY&#39;
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("subnetwork_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SubnetworkId => new TerraformReference(this, "subnetwork_id");

}
