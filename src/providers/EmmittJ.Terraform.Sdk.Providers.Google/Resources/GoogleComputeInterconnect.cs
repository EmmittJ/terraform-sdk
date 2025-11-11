using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for macsec in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectMacsecBlock
{
    /// <summary>
    /// If set to true, the Interconnect connection is configured with a should-secure
    /// MACsec security policy, that allows the Google router to fallback to cleartext
    /// traffic if the MKA session cannot be established. By default, the Interconnect
    /// connection is configured with a must-secure security policy that drops all traffic
    /// if the MKA session cannot be established with your router.
    /// </summary>
    [TerraformPropertyName("fail_open")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FailOpen { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectTimeoutsBlock
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
/// Manages a google_compute_interconnect resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInterconnect : TerraformResource
{
    public GoogleComputeInterconnect(string name) : base("google_compute_interconnect", name)
    {
    }

    /// <summary>
    /// Administrative status of the interconnect. When this is set to true, the Interconnect is
    /// functional and can carry traffic. When set to false, no packets can be carried over the
    /// interconnect and no BGP routes are exchanged over it. By default, the status is set to true.
    /// </summary>
    [TerraformPropertyName("admin_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AdminEnabled { get; set; }

    /// <summary>
    /// Customer name, to put in the Letter of Authorization as the party authorized to request a
    /// crossconnect. This field is required for Dedicated and Partner Interconnect, should not be specified
    /// for cross-cloud interconnect.
    /// </summary>
    [TerraformPropertyName("customer_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerName { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
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
    /// Type of interconnect. Note that a value IT_PRIVATE has been deprecated in favor of DEDICATED.
    /// Can take one of the following values:
    ///   - PARTNER: A partner-managed interconnection shared between customers though a partner.
    ///   - DEDICATED: A dedicated physical interconnection with the customer. Possible values: [&amp;quot;DEDICATED&amp;quot;, &amp;quot;PARTNER&amp;quot;, &amp;quot;IT_PRIVATE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterconnectType is required")]
    [TerraformPropertyName("interconnect_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InterconnectType { get; set; }

    /// <summary>
    /// Labels for this resource. These can only be added or modified by the setLabels
    /// method. Each label key/value pair must comply with RFC1035. Label values may be empty.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Type of link requested. Note that this field indicates the speed of each of the links in the
    /// bundle, not the speed of the entire bundle. Can take one of the following values:
    ///   - LINK_TYPE_ETHERNET_10G_LR: A 10G Ethernet with LR optics.
    ///   - LINK_TYPE_ETHERNET_100G_LR: A 100G Ethernet with LR optics.
    ///   - LINK_TYPE_ETHERNET_400G_LR4: A 400G Ethernet with LR4 optics Possible values: [&amp;quot;LINK_TYPE_ETHERNET_10G_LR&amp;quot;, &amp;quot;LINK_TYPE_ETHERNET_100G_LR&amp;quot;, &amp;quot;LINK_TYPE_ETHERNET_400G_LR4&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkType is required")]
    [TerraformPropertyName("link_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LinkType { get; set; }

    /// <summary>
    /// URL of the InterconnectLocation object that represents where this connection is to be provisioned.
    /// Specifies the location inside Google&#39;s Networks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Enable or disable MACsec on this Interconnect connection.
    /// MACsec enablement fails if the MACsec object is not specified.
    /// </summary>
    [TerraformPropertyName("macsec_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MacsecEnabled { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Email address to contact the customer NOC for operations and maintenance notifications
    /// regarding this Interconnect. If specified, this will be used for notifications in addition to
    /// all other forms described, such as Cloud Monitoring logs alerting and Cloud Notifications.
    /// This field is required for users who sign up for Cloud Interconnect using workforce identity
    /// federation.
    /// </summary>
    [TerraformPropertyName("noc_contact_email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NocContactEmail { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Indicates that this is a Cross-Cloud Interconnect. This field specifies the location outside
    /// of Google&#39;s network that the interconnect is connected to.
    /// </summary>
    [TerraformPropertyName("remote_location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RemoteLocation { get; set; }

    /// <summary>
    /// interconnects.list of features requested for this Interconnect connection. Options: IF_MACSEC (
    /// If specified then the connection is created on MACsec capable hardware ports. If not
    /// specified, the default value is false, which allocates non-MACsec capable ports first if
    /// available). Note that MACSEC is still technically allowed for compatibility reasons, but it
    /// does not work with the API, and will be removed in an upcoming major version. Possible values: [&amp;quot;MACSEC&amp;quot;, &amp;quot;CROSS_SITE_NETWORK&amp;quot;, &amp;quot;IF_MACSEC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("requested_features")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? RequestedFeatures { get; set; }

    /// <summary>
    /// Target number of physical links in the link bundle, as requested by the customer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestedLinkCount is required")]
    [TerraformPropertyName("requested_link_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RequestedLinkCount { get; set; }

    /// <summary>
    /// Block for macsec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Macsec block(s) allowed")]
    [TerraformPropertyName("macsec")]
    public TerraformList<TerraformBlock<GoogleComputeInterconnectMacsecBlock>>? Macsec { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeInterconnectTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// interconnects.list of features available for this Interconnect connection. Can take the value:
    /// MACSEC. If present then the Interconnect connection is provisioned on MACsec capable hardware
    /// ports. If not present then the Interconnect connection is provisioned on non-MACsec capable
    /// ports and MACsec isn&#39;t supported and enabling MACsec fails).
    /// </summary>
    [TerraformPropertyName("available_features")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AvailableFeatures => new TerraformReference(this, "available_features");

    /// <summary>
    /// A list of CircuitInfo objects, that describe the individual circuits in this LAG.
    /// </summary>
    [TerraformPropertyName("circuit_infos")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CircuitInfos => new TerraformReference(this, "circuit_infos");

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
    /// A list of outages expected for this Interconnect.
    /// </summary>
    [TerraformPropertyName("expected_outages")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExpectedOutages => new TerraformReference(this, "expected_outages");

    /// <summary>
    /// IP address configured on the Google side of the Interconnect link.
    /// This can be used only for ping tests.
    /// </summary>
    [TerraformPropertyName("google_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GoogleIpAddress => new TerraformReference(this, "google_ip_address");

    /// <summary>
    /// Google reference ID to be used when raising support tickets with Google or otherwise to debug
    /// backend connectivity issues.
    /// </summary>
    [TerraformPropertyName("google_reference_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GoogleReferenceId => new TerraformReference(this, "google_reference_id");

    /// <summary>
    /// A list of the URLs of all InterconnectAttachments configured to use this Interconnect.
    /// </summary>
    [TerraformPropertyName("interconnect_attachments")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InterconnectAttachments => new TerraformReference(this, "interconnect_attachments");

    /// <summary>
    /// URLs of InterconnectGroups that include this Interconnect.
    /// Order is arbitrary and items are unique.
    /// </summary>
    [TerraformPropertyName("interconnect_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> InterconnectGroups => new TerraformReference(this, "interconnect_groups");

    /// <summary>
    /// A fingerprint for the labels being applied to this Interconnect, which is essentially a hash
    /// of the labels set used for optimistic locking. The fingerprint is initially generated by
    /// Compute Engine and changes after every request to modify or update labels.
    /// You must always provide an up-to-date fingerprint hash in order to update or change labels,
    /// otherwise the request will fail with error 412 conditionNotMet.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// The current status of this Interconnect&#39;s functionality, which can take one of the following:
    ///   - OS_ACTIVE: A valid Interconnect, which is turned up and is ready to use. Attachments may
    ///   be provisioned on this Interconnect.
    ///   - OS_UNPROVISIONED: An Interconnect that has not completed turnup. No attachments may be
    ///   provisioned on this Interconnect.
    ///   - OS_UNDER_MAINTENANCE: An Interconnect that is undergoing internal maintenance. No
    ///   attachments may be provisioned or updated on this Interconnect.
    /// </summary>
    [TerraformPropertyName("operational_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OperationalStatus => new TerraformReference(this, "operational_status");

    /// <summary>
    /// IP address configured on the customer side of the Interconnect link.
    /// The customer should configure this IP address during turnup when prompted by Google NOC.
    /// This can be used only for ping tests.
    /// </summary>
    [TerraformPropertyName("peer_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerIpAddress => new TerraformReference(this, "peer_ip_address");

    /// <summary>
    /// Number of links actually provisioned in this interconnect.
    /// </summary>
    [TerraformPropertyName("provisioned_link_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProvisionedLinkCount => new TerraformReference(this, "provisioned_link_count");

    /// <summary>
    /// Reserved for future use.
    /// </summary>
    [TerraformPropertyName("satisfies_pzs")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SatisfiesPzs => new TerraformReference(this, "satisfies_pzs");

    /// <summary>
    /// The current state of Interconnect functionality, which can take one of the following values:
    ///   - ACTIVE: The Interconnect is valid, turned up and ready to use.
    ///   Attachments may be provisioned on this Interconnect.
    ///   - UNPROVISIONED: The Interconnect has not completed turnup. No attachments may b
    ///    provisioned on this Interconnect.
    ///   - UNDER_MAINTENANCE: The Interconnect is undergoing internal maintenance. No attachments may
    ///    be provisioned or updated on this Interconnect.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
