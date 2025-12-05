using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for macsec in GoogleComputeInterconnect.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectMacsecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "macsec";

    /// <summary>
    /// If set to true, the Interconnect connection is configured with a should-secure
    /// MACsec security policy, that allows the Google router to fallback to cleartext
    /// traffic if the MKA session cannot be established. By default, the Interconnect
    /// connection is configured with a must-secure security policy that drops all traffic
    /// if the MKA session cannot be established with your router.
    /// </summary>
    public TerraformValue<bool>? FailOpen
    {
        get => GetArgument<TerraformValue<bool>>("fail_open");
        set => SetArgument("fail_open", value);
    }

    /// <summary>
    /// PreSharedKeys block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreSharedKeys is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PreSharedKeys block(s) required")]
    public required TerraformList<GoogleComputeInterconnectMacsecBlockPreSharedKeysBlock> PreSharedKeys
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeInterconnectMacsecBlockPreSharedKeysBlock>>("pre_shared_keys");
        set => SetArgument("pre_shared_keys", value);
    }

}

/// <summary>
/// Block type for pre_shared_keys in GoogleComputeInterconnectMacsecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInterconnectMacsecBlockPreSharedKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_shared_keys";

    /// <summary>
    /// If set to true, the Interconnect connection is configured with a should-secure
    /// MACsec security policy, that allows the Google router to fallback to cleartext
    /// traffic if the MKA session cannot be established. By default, the Interconnect
    /// connection is configured with a must-secure security policy that drops all traffic
    /// if the MKA session cannot be established with your router.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? FailOpen
    {
        get => GetArgument<TerraformValue<bool>>("fail_open");
        set => SetArgument("fail_open", value);
    }

    /// <summary>
    /// A name for this pre-shared key. The name must be 1-63 characters long, and
    ///  comply with RFC1035. Specifically, the name must be 1-63 characters long and match
    ///  the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first character
    ///  must be a lowercase letter, and all following characters must be a dash, lowercase
    ///  letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A RFC3339 timestamp on or after which the key is valid. startTime can be in the
    /// future. If the keychain has a single key, startTime can be omitted. If the keychain
    /// has multiple keys, startTime is mandatory for each key. The start times of keys must
    /// be in increasing order. The start times of two consecutive keys must be at least 6
    /// hours apart.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeInterconnect.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInterconnectTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_interconnect Terraform resource.
/// Manages a google_compute_interconnect resource.
/// </summary>
public partial class GoogleComputeInterconnect(string name) : TerraformResource("google_compute_interconnect", name)
{
    /// <summary>
    /// Administrative status of the interconnect. When this is set to true, the Interconnect is
    /// functional and can carry traffic. When set to false, no packets can be carried over the
    /// interconnect and no BGP routes are exchanged over it. By default, the status is set to true.
    /// </summary>
    public TerraformValue<bool>? AdminEnabled
    {
        get => GetArgument<TerraformValue<bool>>("admin_enabled");
        set => SetArgument("admin_enabled", value);
    }

    /// <summary>
    /// Customer name, to put in the Letter of Authorization as the party authorized to request a
    /// crossconnect. This field is required for Dedicated and Partner Interconnect, should not be specified
    /// for cross-cloud interconnect.
    /// </summary>
    public TerraformValue<string>? CustomerName
    {
        get => GetArgument<TerraformValue<string>>("customer_name");
        set => SetArgument("customer_name", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Type of interconnect. Note that a value IT_PRIVATE has been deprecated in favor of DEDICATED.
    /// Can take one of the following values:
    ///   - PARTNER: A partner-managed interconnection shared between customers though a partner.
    ///   - DEDICATED: A dedicated physical interconnection with the customer. Possible values: [&amp;quot;DEDICATED&amp;quot;, &amp;quot;PARTNER&amp;quot;, &amp;quot;IT_PRIVATE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterconnectType is required")]
    public required TerraformValue<string> InterconnectType
    {
        get => GetRequiredArgument<TerraformValue<string>>("interconnect_type");
        set => SetArgument("interconnect_type", value);
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
    /// Type of link requested. Note that this field indicates the speed of each of the links in the
    /// bundle, not the speed of the entire bundle. Can take one of the following values:
    ///   - LINK_TYPE_ETHERNET_10G_LR: A 10G Ethernet with LR optics.
    ///   - LINK_TYPE_ETHERNET_100G_LR: A 100G Ethernet with LR optics.
    ///   - LINK_TYPE_ETHERNET_400G_LR4: A 400G Ethernet with LR4 optics Possible values: [&amp;quot;LINK_TYPE_ETHERNET_10G_LR&amp;quot;, &amp;quot;LINK_TYPE_ETHERNET_100G_LR&amp;quot;, &amp;quot;LINK_TYPE_ETHERNET_400G_LR4&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkType is required")]
    public required TerraformValue<string> LinkType
    {
        get => GetRequiredArgument<TerraformValue<string>>("link_type");
        set => SetArgument("link_type", value);
    }

    /// <summary>
    /// URL of the InterconnectLocation object that represents where this connection is to be provisioned.
    /// Specifies the location inside Google&#39;s Networks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Enable or disable MACsec on this Interconnect connection.
    /// MACsec enablement fails if the MACsec object is not specified.
    /// </summary>
    public TerraformValue<bool>? MacsecEnabled
    {
        get => GetArgument<TerraformValue<bool>>("macsec_enabled");
        set => SetArgument("macsec_enabled", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Email address to contact the customer NOC for operations and maintenance notifications
    /// regarding this Interconnect. If specified, this will be used for notifications in addition to
    /// all other forms described, such as Cloud Monitoring logs alerting and Cloud Notifications.
    /// This field is required for users who sign up for Cloud Interconnect using workforce identity
    /// federation.
    /// </summary>
    public TerraformValue<string>? NocContactEmail
    {
        get => GetArgument<TerraformValue<string>>("noc_contact_email");
        set => SetArgument("noc_contact_email", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Indicates that this is a Cross-Cloud Interconnect. This field specifies the location outside
    /// of Google&#39;s network that the interconnect is connected to.
    /// </summary>
    public TerraformValue<string>? RemoteLocation
    {
        get => GetArgument<TerraformValue<string>>("remote_location");
        set => SetArgument("remote_location", value);
    }

    /// <summary>
    /// interconnects.list of features requested for this Interconnect connection. Options: IF_MACSEC (
    /// If specified then the connection is created on MACsec capable hardware ports. If not
    /// specified, the default value is false, which allocates non-MACsec capable ports first if
    /// available). Note that MACSEC is still technically allowed for compatibility reasons, but it
    /// does not work with the API, and will be removed in an upcoming major version. Possible values: [&amp;quot;MACSEC&amp;quot;, &amp;quot;CROSS_SITE_NETWORK&amp;quot;, &amp;quot;IF_MACSEC&amp;quot;]
    /// </summary>
    public TerraformList<string>? RequestedFeatures
    {
        get => GetArgument<TerraformList<string>>("requested_features");
        set => SetArgument("requested_features", value);
    }

    /// <summary>
    /// Target number of physical links in the link bundle, as requested by the customer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequestedLinkCount is required")]
    public required TerraformValue<double> RequestedLinkCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("requested_link_count");
        set => SetArgument("requested_link_count", value);
    }

    /// <summary>
    /// interconnects.list of features available for this Interconnect connection. Can take the value:
    /// MACSEC. If present then the Interconnect connection is provisioned on MACsec capable hardware
    /// ports. If not present then the Interconnect connection is provisioned on non-MACsec capable
    /// ports and MACsec isn&#39;t supported and enabling MACsec fails).
    /// </summary>
    public TerraformList<string> AvailableFeatures
        => CreateReference("available_features");

    /// <summary>
    /// A list of CircuitInfo objects, that describe the individual circuits in this LAG.
    /// </summary>
    public TerraformList<TerraformMap<object>> CircuitInfos
        => CreateReference("circuit_infos");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// A list of outages expected for this Interconnect.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExpectedOutages
        => CreateReference("expected_outages");

    /// <summary>
    /// IP address configured on the Google side of the Interconnect link.
    /// This can be used only for ping tests.
    /// </summary>
    public TerraformValue<string> GoogleIpAddress
        => CreateReference("google_ip_address");

    /// <summary>
    /// Google reference ID to be used when raising support tickets with Google or otherwise to debug
    /// backend connectivity issues.
    /// </summary>
    public TerraformValue<string> GoogleReferenceId
        => CreateReference("google_reference_id");

    /// <summary>
    /// A list of the URLs of all InterconnectAttachments configured to use this Interconnect.
    /// </summary>
    public TerraformList<string> InterconnectAttachments
        => CreateReference("interconnect_attachments");

    /// <summary>
    /// URLs of InterconnectGroups that include this Interconnect.
    /// Order is arbitrary and items are unique.
    /// </summary>
    public TerraformSet<string> InterconnectGroups
        => CreateReference("interconnect_groups");

    /// <summary>
    /// A fingerprint for the labels being applied to this Interconnect, which is essentially a hash
    /// of the labels set used for optimistic locking. The fingerprint is initially generated by
    /// Compute Engine and changes after every request to modify or update labels.
    /// You must always provide an up-to-date fingerprint hash in order to update or change labels,
    /// otherwise the request will fail with error 412 conditionNotMet.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
        => CreateReference("label_fingerprint");

    /// <summary>
    /// The current status of this Interconnect&#39;s functionality, which can take one of the following:
    ///   - OS_ACTIVE: A valid Interconnect, which is turned up and is ready to use. Attachments may
    ///   be provisioned on this Interconnect.
    ///   - OS_UNPROVISIONED: An Interconnect that has not completed turnup. No attachments may be
    ///   provisioned on this Interconnect.
    ///   - OS_UNDER_MAINTENANCE: An Interconnect that is undergoing internal maintenance. No
    ///   attachments may be provisioned or updated on this Interconnect.
    /// </summary>
    public TerraformValue<string> OperationalStatus
        => CreateReference("operational_status");

    /// <summary>
    /// IP address configured on the customer side of the Interconnect link.
    /// The customer should configure this IP address during turnup when prompted by Google NOC.
    /// This can be used only for ping tests.
    /// </summary>
    public TerraformValue<string> PeerIpAddress
        => CreateReference("peer_ip_address");

    /// <summary>
    /// Number of links actually provisioned in this interconnect.
    /// </summary>
    public TerraformValue<double> ProvisionedLinkCount
        => CreateReference("provisioned_link_count");

    /// <summary>
    /// Reserved for future use.
    /// </summary>
    public TerraformValue<bool> SatisfiesPzs
        => CreateReference("satisfies_pzs");

    /// <summary>
    /// The current state of Interconnect functionality, which can take one of the following values:
    ///   - ACTIVE: The Interconnect is valid, turned up and ready to use.
    ///   Attachments may be provisioned on this Interconnect.
    ///   - UNPROVISIONED: The Interconnect has not completed turnup. No attachments may b
    ///    provisioned on this Interconnect.
    ///   - UNDER_MAINTENANCE: The Interconnect is undergoing internal maintenance. No attachments may
    ///    be provisioned or updated on this Interconnect.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Macsec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Macsec block(s) allowed")]
    public TerraformList<GoogleComputeInterconnectMacsecBlock>? Macsec
    {
        get => GetArgument<TerraformList<GoogleComputeInterconnectMacsecBlock>>("macsec");
        set => SetArgument("macsec", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInterconnectTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInterconnectTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
