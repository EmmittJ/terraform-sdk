using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeInterconnectAttachmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_interconnect_attachment resource.
/// </summary>
public partial class GoogleComputeInterconnectAttachment : TerraformResource
{
    public GoogleComputeInterconnectAttachment(string name) : base("google_compute_interconnect_attachment", name)
    {
    }

    /// <summary>
    /// Whether the VLAN attachment is enabled or disabled.  When using
    /// PARTNER type this will Pre-Activate the interconnect attachment
    /// </summary>
    [TerraformProperty("admin_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AdminEnabled { get; set; }

    /// <summary>
    /// Provisioned bandwidth capacity for the interconnect attachment.
    /// For attachments of type DEDICATED, the user can set the bandwidth.
    /// For attachments of type PARTNER, the Google Partner that is operating the interconnect must set the bandwidth.
    /// Output only for PARTNER type, mutable for PARTNER_PROVIDER and DEDICATED,
    /// Defaults to BPS_10G Possible values: [&amp;quot;BPS_50M&amp;quot;, &amp;quot;BPS_100M&amp;quot;, &amp;quot;BPS_200M&amp;quot;, &amp;quot;BPS_300M&amp;quot;, &amp;quot;BPS_400M&amp;quot;, &amp;quot;BPS_500M&amp;quot;, &amp;quot;BPS_1G&amp;quot;, &amp;quot;BPS_2G&amp;quot;, &amp;quot;BPS_5G&amp;quot;, &amp;quot;BPS_10G&amp;quot;, &amp;quot;BPS_20G&amp;quot;, &amp;quot;BPS_50G&amp;quot;, &amp;quot;BPS_100G&amp;quot;]
    /// </summary>
    [TerraformProperty("bandwidth")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Bandwidth { get; set; }

    /// <summary>
    /// Up to 16 candidate prefixes that can be used to restrict the allocation
    /// of cloudRouterIpAddress and customerRouterIpAddress for this attachment.
    /// All prefixes must be within link-local address space (169.254.0.0/16)
    /// and must be /29 or shorter (/28, /27, etc). Google will attempt to select
    /// an unused /29 from the supplied candidate prefix(es). The request will
    /// fail if all possible /29s are in use on Google&#39;s edge. If not supplied,
    /// Google will randomly select an unused /29 from all of link-local space.
    /// </summary>
    [TerraformProperty("candidate_subnets")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? CandidateSubnets { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Desired availability domain for the attachment. Only available for type
    /// PARTNER, at creation time. For improved reliability, customers should
    /// configure a pair of attachments with one per availability domain. The
    /// selected availability domain will be provided to the Partner via the
    /// pairing key so that the provisioned circuit will lie in the specified
    /// domain. If not specified, the value will default to AVAILABILITY_DOMAIN_ANY.
    /// </summary>
    [TerraformProperty("edge_availability_domain")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EdgeAvailabilityDomain { get; set; }

    /// <summary>
    /// Indicates the user-supplied encryption option of this interconnect
    /// attachment. Can only be specified at attachment creation for PARTNER or
    /// DEDICATED attachments.
    /// * NONE - This is the default value, which means that the VLAN attachment
    /// carries unencrypted traffic. VMs are able to send traffic to, or receive
    /// traffic from, such a VLAN attachment.
    /// * IPSEC - The VLAN attachment carries only encrypted traffic that is
    /// encrypted by an IPsec device, such as an HA VPN gateway or third-party
    /// IPsec VPN. VMs cannot directly send traffic to, or receive traffic from,
    /// such a VLAN attachment. To use HA VPN over Cloud Interconnect, the VLAN
    /// attachment must be created with this option. Default value: &amp;quot;NONE&amp;quot; Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;IPSEC&amp;quot;]
    /// </summary>
    [TerraformProperty("encryption")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Encryption { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// URL of the underlying Interconnect object that this attachment&#39;s
    /// traffic will traverse through. Required if type is DEDICATED, must not
    /// be set if type is PARTNER.
    /// </summary>
    [TerraformProperty("interconnect")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Interconnect { get; set; }

    /// <summary>
    /// URL of addresses that have been reserved for the interconnect attachment,
    /// Used only for interconnect attachment that has the encryption option as
    /// IPSEC.
    /// The addresses must be RFC 1918 IP address ranges. When creating HA VPN
    /// gateway over the interconnect attachment, if the attachment is configured
    /// to use an RFC 1918 IP address, then the VPN gateway&#39;s IP address will be
    /// allocated from the IP address range specified here.
    /// For example, if the HA VPN gateway&#39;s interface 0 is paired to this
    /// interconnect attachment, then an RFC 1918 IP address for the VPN gateway
    /// interface 0 will be allocated from the IP address specified for this
    /// interconnect attachment.
    /// If this field is not specified for interconnect attachment that has
    /// encryption option as IPSEC, later on when creating HA VPN gateway on this
    /// interconnect attachment, the HA VPN gateway&#39;s IP address will be
    /// allocated from regional external IP address pool.
    /// </summary>
    [TerraformProperty("ipsec_internal_addresses")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? IpsecInternalAddresses { get; set; }

    /// <summary>
    /// Labels for this resource. These can only be added or modified by the setLabels
    /// method. Each label key/value pair must comply with RFC1035. Label values may be empty.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Maximum Transmission Unit (MTU), in bytes, of packets passing through this interconnect attachment.
    /// Valid values are 1440, 1460, 1500, and 8896. If not specified, the value will default to 1440.
    /// </summary>
    [TerraformProperty("mtu")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Mtu { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The
    /// name must be 1-63 characters long, and comply with RFC1035. Specifically, the
    /// name must be 1-63 characters long and match the regular expression
    /// &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first character must be a
    /// lowercase letter, and all following characters must be a dash, lowercase
    /// letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where the regional interconnect attachment resides.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// URL of the cloud router to be used for dynamic routing. This router must be in
    /// the same region as this InterconnectAttachment. The InterconnectAttachment will
    /// automatically connect the Interconnect to the network &amp;amp; region within which the
    /// Cloud Router is configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    [TerraformProperty("router")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Router { get; set; }

    /// <summary>
    /// The stack type for this interconnect attachment to identify whether the IPv6
    /// feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// This field can be both set at interconnect attachments creation and update
    /// interconnect attachment operations. Possible values: [&amp;quot;IPV4_IPV6&amp;quot;, &amp;quot;IPV4_ONLY&amp;quot;]
    /// </summary>
    [TerraformProperty("stack_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StackType { get; set; }

    /// <summary>
    /// Length of the IPv4 subnet mask. Allowed values: 29 (default), 30. The default value is 29,
    /// except for Cross-Cloud Interconnect connections that use an InterconnectRemoteLocation with a
    /// constraints.subnetLengthRange.min equal to 30. For example, connections that use an Azure
    /// remote location fall into this category. In these cases, the default value is 30, and
    /// requesting 29 returns an error. Where both 29 and 30 are allowed, 29 is preferred, because it
    /// gives Google Cloud Support more debugging visibility.
    /// </summary>
    [TerraformProperty("subnet_length")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SubnetLength { get; set; }

    /// <summary>
    /// The type of InterconnectAttachment you wish to create. Defaults to
    /// DEDICATED. Possible values: [&amp;quot;DEDICATED&amp;quot;, &amp;quot;PARTNER&amp;quot;, &amp;quot;PARTNER_PROVIDER&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The IEEE 802.1Q VLAN tag for this attachment, in the range 2-4094. When
    /// using PARTNER type this will be managed upstream.
    /// </summary>
    [TerraformProperty("vlan_tag8021q")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> VlanTag8021q { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeInterconnectAttachmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// URL of the AttachmentGroup that includes this Attachment.
    /// </summary>
    [TerraformProperty("attachment_group")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AttachmentGroup { get; }

    /// <summary>
    /// IPv4 address + prefix length to be configured on Cloud Router
    /// Interface for this interconnect attachment.
    /// </summary>
    [TerraformProperty("cloud_router_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudRouterIpAddress { get; }

    /// <summary>
    /// IPv6 address + prefix length to be configured on Cloud Router
    /// Interface for this interconnect attachment.
    /// </summary>
    [TerraformProperty("cloud_router_ipv6_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudRouterIpv6Address { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// IPv4 address + prefix length to be configured on the customer
    /// router subinterface for this interconnect attachment.
    /// </summary>
    [TerraformProperty("customer_router_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerRouterIpAddress { get; }

    /// <summary>
    /// IPv6 address + prefix length to be configured on the customer
    /// router subinterface for this interconnect attachment.
    /// </summary>
    [TerraformProperty("customer_router_ipv6_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerRouterIpv6Address { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Google reference ID, to be used when raising support tickets with
    /// Google or otherwise to debug backend connectivity issues.
    /// </summary>
    [TerraformProperty("google_reference_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GoogleReferenceId { get; }

    /// <summary>
    /// A fingerprint for the labels being applied to this Interconnect, which is essentially a hash
    /// of the labels set used for optimistic locking. The fingerprint is initially generated by
    /// Compute Engine and changes after every request to modify or update labels.
    /// You must always provide an up-to-date fingerprint hash in order to update or change labels,
    /// otherwise the request will fail with error 412 conditionNotMet.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// [Output only for type PARTNER. Not present for DEDICATED]. The opaque
    /// identifier of an PARTNER attachment used to initiate provisioning with
    /// a selected partner. Of the form &amp;quot;XXXXX/region/domain&amp;quot;
    /// </summary>
    [TerraformProperty("pairing_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PairingKey { get; }

    /// <summary>
    /// [Output only for type PARTNER. Not present for DEDICATED]. Optional
    /// BGP ASN for the router that should be supplied by a layer 3 Partner if
    /// they configured BGP on behalf of the customer.
    /// </summary>
    [TerraformProperty("partner_asn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PartnerAsn { get; }

    /// <summary>
    /// Information specific to an InterconnectAttachment. This property
    /// is populated if the interconnect that this is attached to is of type DEDICATED.
    /// </summary>
    [TerraformProperty("private_interconnect_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PrivateInterconnectInfo { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// [Output Only] The current state of this attachment&#39;s functionality.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
