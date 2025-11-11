using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeAddressTimeoutsBlock
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
/// Manages a google_compute_address resource.
/// </summary>
public class GoogleComputeAddress : TerraformResource
{
    public GoogleComputeAddress(string name) : base("google_compute_address", name)
    {
    }

    /// <summary>
    /// The static external IP address represented by this resource.
    /// The IP address must be inside the specified subnetwork,
    /// if any. Set by the API if undefined.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Address { get; set; } = default!;

    /// <summary>
    /// The type of address to reserve.
    /// Note: if you set this argument&#39;s value as &#39;INTERNAL&#39; you need to leave the &#39;network_tier&#39; argument unset in that resource block. Default value: &amp;quot;EXTERNAL&amp;quot; Possible values: [&amp;quot;INTERNAL&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("address_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AddressType { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The IP Version that will be used by this address. The default value is &#39;IPV4&#39;. Possible values: [&amp;quot;IPV4&amp;quot;, &amp;quot;IPV6&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ip_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpVersion { get; set; }

    /// <summary>
    /// The endpoint type of this address, which should be VM or NETLB. This is
    /// used for deciding which type of endpoint this address can be used after
    /// the external IPv6 address reservation. Possible values: [&amp;quot;VM&amp;quot;, &amp;quot;NETLB&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ipv6_endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv6EndpointType { get; set; }

    /// <summary>
    /// Labels to apply to this address.  A list of key-&amp;gt;value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The URL of the network in which to reserve the address. This field
    /// can only be used with INTERNAL type with the VPC_PEERING and
    /// IPSEC_INTERCONNECT purposes.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The networking tier used for configuring this address. If this field is not
    /// specified, it is assumed to be PREMIUM.
    /// This argument should not be used when configuring Internal addresses, because [network tier cannot be set for internal traffic; it&#39;s always Premium](https://cloud.google.com/network-tiers/docs/overview). Possible values: [&amp;quot;PREMIUM&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformPropertyName("network_tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkTier { get; set; } = default!;

    /// <summary>
    /// The prefix length if the resource represents an IP range.
    /// </summary>
    [TerraformPropertyName("prefix_length")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PrefixLength { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The purpose of this resource, which can be one of the following values.
    /// 
    /// * GCE_ENDPOINT for addresses that are used by VM instances, alias IP
    /// ranges, load balancers, and similar resources.
    /// 
    /// * SHARED_LOADBALANCER_VIP for an address that can be used by multiple
    /// internal load balancers.
    /// 
    /// * VPC_PEERING for addresses that are reserved for VPC peer networks.
    /// 
    /// * IPSEC_INTERCONNECT for addresses created from a private IP range that
    /// are reserved for a VLAN attachment in an HA VPN over Cloud Interconnect
    /// configuration. These addresses are regional resources.
    /// 
    /// * PRIVATE_SERVICE_CONNECT for a private network address that is used to
    /// configure Private Service Connect. Only global internal addresses can use
    /// this purpose.
    /// 
    /// This should only be set when using an Internal address.
    /// </summary>
    [TerraformPropertyName("purpose")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Purpose { get; set; } = default!;

    /// <summary>
    /// The Region in which the created address should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The URL of the subnetwork in which to reserve the address. If an IP
    /// address is specified, it must be within the subnetwork&#39;s IP range.
    /// This field can only be used with INTERNAL type with
    /// GCE_ENDPOINT/DNS_RESOLVER purposes.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Subnetwork { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeAddressTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The URLs of the resources that are using this address.
    /// </summary>
    [TerraformPropertyName("users")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Users => new TerraformReference(this, "users");

}
