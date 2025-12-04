using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeInterconnectAttachment.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectAttachmentTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_interconnect_attachment Terraform resource.
/// Manages a google_compute_interconnect_attachment resource.
/// </summary>
public partial class GoogleComputeInterconnectAttachment(string name) : TerraformResource("google_compute_interconnect_attachment", name)
{
    /// <summary>
    /// Whether the VLAN attachment is enabled or disabled.  When using
    /// PARTNER type this will Pre-Activate the interconnect attachment
    /// </summary>
    public TerraformValue<bool>? AdminEnabled
    {
        get => GetArgument<TerraformValue<bool>>("admin_enabled");
        set => SetArgument("admin_enabled", value);
    }

    /// <summary>
    /// Provisioned bandwidth capacity for the interconnect attachment.
    /// For attachments of type DEDICATED, the user can set the bandwidth.
    /// For attachments of type PARTNER, the Google Partner that is operating the interconnect must set the bandwidth.
    /// Output only for PARTNER type, mutable for PARTNER_PROVIDER and DEDICATED,
    /// Defaults to BPS_10G Possible values: [&amp;quot;BPS_50M&amp;quot;, &amp;quot;BPS_100M&amp;quot;, &amp;quot;BPS_200M&amp;quot;, &amp;quot;BPS_300M&amp;quot;, &amp;quot;BPS_400M&amp;quot;, &amp;quot;BPS_500M&amp;quot;, &amp;quot;BPS_1G&amp;quot;, &amp;quot;BPS_2G&amp;quot;, &amp;quot;BPS_5G&amp;quot;, &amp;quot;BPS_10G&amp;quot;, &amp;quot;BPS_20G&amp;quot;, &amp;quot;BPS_50G&amp;quot;, &amp;quot;BPS_100G&amp;quot;]
    /// </summary>
    public TerraformValue<string> Bandwidth
    {
        get => GetArgument<TerraformValue<string>>("bandwidth") ?? AsReference("bandwidth");
        set => SetArgument("bandwidth", value);
    }

    /// <summary>
    /// Up to 16 candidate prefixes that can be used to restrict the allocation
    /// of cloudRouterIpAddress and customerRouterIpAddress for this attachment.
    /// All prefixes must be within link-local address space (169.254.0.0/16)
    /// and must be /29 or shorter (/28, /27, etc). Google will attempt to select
    /// an unused /29 from the supplied candidate prefix(es). The request will
    /// fail if all possible /29s are in use on Google&#39;s edge. If not supplied,
    /// Google will randomly select an unused /29 from all of link-local space.
    /// </summary>
    public TerraformList<string>? CandidateSubnets
    {
        get => GetArgument<TerraformList<string>>("candidate_subnets");
        set => SetArgument("candidate_subnets", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Desired availability domain for the attachment. Only available for type
    /// PARTNER, at creation time. For improved reliability, customers should
    /// configure a pair of attachments with one per availability domain. The
    /// selected availability domain will be provided to the Partner via the
    /// pairing key so that the provisioned circuit will lie in the specified
    /// domain. If not specified, the value will default to AVAILABILITY_DOMAIN_ANY.
    /// </summary>
    public TerraformValue<string> EdgeAvailabilityDomain
    {
        get => GetArgument<TerraformValue<string>>("edge_availability_domain") ?? AsReference("edge_availability_domain");
        set => SetArgument("edge_availability_domain", value);
    }

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
    public TerraformValue<string>? Encryption
    {
        get => GetArgument<TerraformValue<string>>("encryption");
        set => SetArgument("encryption", value);
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
    /// URL of the underlying Interconnect object that this attachment&#39;s
    /// traffic will traverse through. Required if type is DEDICATED, must not
    /// be set if type is PARTNER.
    /// </summary>
    public TerraformValue<string>? Interconnect
    {
        get => GetArgument<TerraformValue<string>>("interconnect");
        set => SetArgument("interconnect", value);
    }

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
    public TerraformList<string>? IpsecInternalAddresses
    {
        get => GetArgument<TerraformList<string>>("ipsec_internal_addresses");
        set => SetArgument("ipsec_internal_addresses", value);
    }

    /// <summary>
    /// Labels for this resource. These can only be added or modified by the setLabels
    /// method. Each label key/value pair must comply with RFC1035. Label values may be empty.
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
    /// Maximum Transmission Unit (MTU), in bytes, of packets passing through this interconnect attachment.
    /// Valid values are 1440, 1460, 1500, and 8896. If not specified, the value will default to 1440.
    /// </summary>
    public TerraformValue<string> Mtu
    {
        get => GetArgument<TerraformValue<string>>("mtu") ?? AsReference("mtu");
        set => SetArgument("mtu", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The
    /// name must be 1-63 characters long, and comply with RFC1035. Specifically, the
    /// name must be 1-63 characters long and match the regular expression
    /// &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first character must be a
    /// lowercase letter, and all following characters must be a dash, lowercase
    /// letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// Region where the regional interconnect attachment resides.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// URL of the cloud router to be used for dynamic routing. This router must be in
    /// the same region as this InterconnectAttachment. The InterconnectAttachment will
    /// automatically connect the Interconnect to the network &amp;amp; region within which the
    /// Cloud Router is configured.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Router is required")]
    public required TerraformValue<string> Router
    {
        get => GetRequiredArgument<TerraformValue<string>>("router");
        set => SetArgument("router", value);
    }

    /// <summary>
    /// The stack type for this interconnect attachment to identify whether the IPv6
    /// feature is enabled or not. If not specified, IPV4_ONLY will be used.
    /// This field can be both set at interconnect attachments creation and update
    /// interconnect attachment operations. Possible values: [&amp;quot;IPV4_IPV6&amp;quot;, &amp;quot;IPV4_ONLY&amp;quot;]
    /// </summary>
    public TerraformValue<string> StackType
    {
        get => GetArgument<TerraformValue<string>>("stack_type") ?? AsReference("stack_type");
        set => SetArgument("stack_type", value);
    }

    /// <summary>
    /// Length of the IPv4 subnet mask. Allowed values: 29 (default), 30. The default value is 29,
    /// except for Cross-Cloud Interconnect connections that use an InterconnectRemoteLocation with a
    /// constraints.subnetLengthRange.min equal to 30. For example, connections that use an Azure
    /// remote location fall into this category. In these cases, the default value is 30, and
    /// requesting 29 returns an error. Where both 29 and 30 are allowed, 29 is preferred, because it
    /// gives Google Cloud Support more debugging visibility.
    /// </summary>
    public TerraformValue<double>? SubnetLength
    {
        get => GetArgument<TerraformValue<double>>("subnet_length");
        set => SetArgument("subnet_length", value);
    }

    /// <summary>
    /// The type of InterconnectAttachment you wish to create. Defaults to
    /// DEDICATED. Possible values: [&amp;quot;DEDICATED&amp;quot;, &amp;quot;PARTNER&amp;quot;, &amp;quot;PARTNER_PROVIDER&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? AsReference("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The IEEE 802.1Q VLAN tag for this attachment, in the range 2-4094. When
    /// using PARTNER type this will be managed upstream.
    /// </summary>
    public TerraformValue<double> VlanTag8021q
    {
        get => GetArgument<TerraformValue<double>>("vlan_tag8021q") ?? AsReference("vlan_tag8021q");
        set => SetArgument("vlan_tag8021q", value);
    }

    /// <summary>
    /// URL of the AttachmentGroup that includes this Attachment.
    /// </summary>
    public TerraformValue<string> AttachmentGroup
        => AsReference("attachment_group");

    /// <summary>
    /// IPv4 address + prefix length to be configured on Cloud Router
    /// Interface for this interconnect attachment.
    /// </summary>
    public TerraformValue<string> CloudRouterIpAddress
        => AsReference("cloud_router_ip_address");

    /// <summary>
    /// IPv6 address + prefix length to be configured on Cloud Router
    /// Interface for this interconnect attachment.
    /// </summary>
    public TerraformValue<string> CloudRouterIpv6Address
        => AsReference("cloud_router_ipv6_address");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// IPv4 address + prefix length to be configured on the customer
    /// router subinterface for this interconnect attachment.
    /// </summary>
    public TerraformValue<string> CustomerRouterIpAddress
        => AsReference("customer_router_ip_address");

    /// <summary>
    /// IPv6 address + prefix length to be configured on the customer
    /// router subinterface for this interconnect attachment.
    /// </summary>
    public TerraformValue<string> CustomerRouterIpv6Address
        => AsReference("customer_router_ipv6_address");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Google reference ID, to be used when raising support tickets with
    /// Google or otherwise to debug backend connectivity issues.
    /// </summary>
    public TerraformValue<string> GoogleReferenceId
        => AsReference("google_reference_id");

    /// <summary>
    /// A fingerprint for the labels being applied to this Interconnect, which is essentially a hash
    /// of the labels set used for optimistic locking. The fingerprint is initially generated by
    /// Compute Engine and changes after every request to modify or update labels.
    /// You must always provide an up-to-date fingerprint hash in order to update or change labels,
    /// otherwise the request will fail with error 412 conditionNotMet.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => AsReference("label_fingerprint");

    /// <summary>
    /// [Output only for type PARTNER. Not present for DEDICATED]. The opaque
    /// identifier of an PARTNER attachment used to initiate provisioning with
    /// a selected partner. Of the form &amp;quot;XXXXX/region/domain&amp;quot;
    /// </summary>
    public TerraformValue<string> PairingKey
        => AsReference("pairing_key");

    /// <summary>
    /// [Output only for type PARTNER. Not present for DEDICATED]. Optional
    /// BGP ASN for the router that should be supplied by a layer 3 Partner if
    /// they configured BGP on behalf of the customer.
    /// </summary>
    public TerraformValue<string> PartnerAsn
        => AsReference("partner_asn");

    /// <summary>
    /// Information specific to an InterconnectAttachment. This property
    /// is populated if the interconnect that this is attached to is of type DEDICATED.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateInterconnectInfo
        => AsReference("private_interconnect_info");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// [Output Only] The current state of this attachment&#39;s functionality.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInterconnectAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInterconnectAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
