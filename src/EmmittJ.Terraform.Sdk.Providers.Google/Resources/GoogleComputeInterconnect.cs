using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_interconnect resource.
/// </summary>
public class GoogleComputeInterconnect : TerraformResource
{
    public GoogleComputeInterconnect(string name) : base("google_compute_interconnect", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("available_features");
        this.DeclareOutput("circuit_infos");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("expected_outages");
        this.DeclareOutput("google_ip_address");
        this.DeclareOutput("google_reference_id");
        this.DeclareOutput("interconnect_attachments");
        this.DeclareOutput("interconnect_groups");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("operational_status");
        this.DeclareOutput("peer_ip_address");
        this.DeclareOutput("provisioned_link_count");
        this.DeclareOutput("satisfies_pzs");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Administrative status of the interconnect. When this is set to true, the Interconnect is
    /// functional and can carry traffic. When set to false, no packets can be carried over the
    /// interconnect and no BGP routes are exchanged over it. By default, the status is set to true.
    /// </summary>
    public TerraformProperty<bool>? AdminEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("admin_enabled");
        set => this.WithProperty("admin_enabled", value);
    }

    /// <summary>
    /// Customer name, to put in the Letter of Authorization as the party authorized to request a
    /// crossconnect. This field is required for Dedicated and Partner Interconnect, should not be specified
    /// for cross-cloud interconnect.
    /// </summary>
    public TerraformProperty<string>? CustomerName
    {
        get => GetProperty<TerraformProperty<string>>("customer_name");
        set => this.WithProperty("customer_name", value);
    }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Type of interconnect. Note that a value IT_PRIVATE has been deprecated in favor of DEDICATED.
    /// Can take one of the following values:
    ///   - PARTNER: A partner-managed interconnection shared between customers though a partner.
    ///   - DEDICATED: A dedicated physical interconnection with the customer. Possible values: [&amp;quot;DEDICATED&amp;quot;, &amp;quot;PARTNER&amp;quot;, &amp;quot;IT_PRIVATE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? InterconnectType
    {
        get => GetProperty<TerraformProperty<string>>("interconnect_type");
        set => this.WithProperty("interconnect_type", value);
    }

    /// <summary>
    /// Labels for this resource. These can only be added or modified by the setLabels
    /// method. Each label key/value pair must comply with RFC1035. Label values may be empty.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Type of link requested. Note that this field indicates the speed of each of the links in the
    /// bundle, not the speed of the entire bundle. Can take one of the following values:
    ///   - LINK_TYPE_ETHERNET_10G_LR: A 10G Ethernet with LR optics.
    ///   - LINK_TYPE_ETHERNET_100G_LR: A 100G Ethernet with LR optics.
    ///   - LINK_TYPE_ETHERNET_400G_LR4: A 400G Ethernet with LR4 optics Possible values: [&amp;quot;LINK_TYPE_ETHERNET_10G_LR&amp;quot;, &amp;quot;LINK_TYPE_ETHERNET_100G_LR&amp;quot;, &amp;quot;LINK_TYPE_ETHERNET_400G_LR4&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LinkType
    {
        get => GetProperty<TerraformProperty<string>>("link_type");
        set => this.WithProperty("link_type", value);
    }

    /// <summary>
    /// URL of the InterconnectLocation object that represents where this connection is to be provisioned.
    /// Specifies the location inside Google&#39;s Networks.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Enable or disable MACsec on this Interconnect connection.
    /// MACsec enablement fails if the MACsec object is not specified.
    /// </summary>
    public TerraformProperty<bool>? MacsecEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("macsec_enabled");
        set => this.WithProperty("macsec_enabled", value);
    }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created. The name must be
    /// 1-63 characters long, and comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the first
    /// character must be a lowercase letter, and all following characters must be a dash,
    /// lowercase letter, or digit, except the last character, which cannot be a dash.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Email address to contact the customer NOC for operations and maintenance notifications
    /// regarding this Interconnect. If specified, this will be used for notifications in addition to
    /// all other forms described, such as Cloud Monitoring logs alerting and Cloud Notifications.
    /// This field is required for users who sign up for Cloud Interconnect using workforce identity
    /// federation.
    /// </summary>
    public TerraformProperty<string>? NocContactEmail
    {
        get => GetProperty<TerraformProperty<string>>("noc_contact_email");
        set => this.WithProperty("noc_contact_email", value);
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
    /// Indicates that this is a Cross-Cloud Interconnect. This field specifies the location outside
    /// of Google&#39;s network that the interconnect is connected to.
    /// </summary>
    public TerraformProperty<string>? RemoteLocation
    {
        get => GetProperty<TerraformProperty<string>>("remote_location");
        set => this.WithProperty("remote_location", value);
    }

    /// <summary>
    /// interconnects.list of features requested for this Interconnect connection. Options: IF_MACSEC (
    /// If specified then the connection is created on MACsec capable hardware ports. If not
    /// specified, the default value is false, which allocates non-MACsec capable ports first if
    /// available). Note that MACSEC is still technically allowed for compatibility reasons, but it
    /// does not work with the API, and will be removed in an upcoming major version. Possible values: [&amp;quot;MACSEC&amp;quot;, &amp;quot;CROSS_SITE_NETWORK&amp;quot;, &amp;quot;IF_MACSEC&amp;quot;]
    /// </summary>
    public TerraformProperty<List<string>>? RequestedFeatures
    {
        get => GetProperty<TerraformProperty<List<string>>>("requested_features");
        set => this.WithProperty("requested_features", value);
    }

    /// <summary>
    /// Target number of physical links in the link bundle, as requested by the customer.
    /// </summary>
    public TerraformProperty<double>? RequestedLinkCount
    {
        get => GetProperty<TerraformProperty<double>>("requested_link_count");
        set => this.WithProperty("requested_link_count", value);
    }

    /// <summary>
    /// interconnects.list of features available for this Interconnect connection. Can take the value:
    /// MACSEC. If present then the Interconnect connection is provisioned on MACsec capable hardware
    /// ports. If not present then the Interconnect connection is provisioned on non-MACsec capable
    /// ports and MACsec isn&#39;t supported and enabling MACsec fails).
    /// </summary>
    public TerraformExpression AvailableFeatures => this["available_features"];

    /// <summary>
    /// A list of CircuitInfo objects, that describe the individual circuits in this LAG.
    /// </summary>
    public TerraformExpression CircuitInfos => this["circuit_infos"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A list of outages expected for this Interconnect.
    /// </summary>
    public TerraformExpression ExpectedOutages => this["expected_outages"];

    /// <summary>
    /// IP address configured on the Google side of the Interconnect link.
    /// This can be used only for ping tests.
    /// </summary>
    public TerraformExpression GoogleIpAddress => this["google_ip_address"];

    /// <summary>
    /// Google reference ID to be used when raising support tickets with Google or otherwise to debug
    /// backend connectivity issues.
    /// </summary>
    public TerraformExpression GoogleReferenceId => this["google_reference_id"];

    /// <summary>
    /// A list of the URLs of all InterconnectAttachments configured to use this Interconnect.
    /// </summary>
    public TerraformExpression InterconnectAttachments => this["interconnect_attachments"];

    /// <summary>
    /// URLs of InterconnectGroups that include this Interconnect.
    /// Order is arbitrary and items are unique.
    /// </summary>
    public TerraformExpression InterconnectGroups => this["interconnect_groups"];

    /// <summary>
    /// A fingerprint for the labels being applied to this Interconnect, which is essentially a hash
    /// of the labels set used for optimistic locking. The fingerprint is initially generated by
    /// Compute Engine and changes after every request to modify or update labels.
    /// You must always provide an up-to-date fingerprint hash in order to update or change labels,
    /// otherwise the request will fail with error 412 conditionNotMet.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// The current status of this Interconnect&#39;s functionality, which can take one of the following:
    ///   - OS_ACTIVE: A valid Interconnect, which is turned up and is ready to use. Attachments may
    ///   be provisioned on this Interconnect.
    ///   - OS_UNPROVISIONED: An Interconnect that has not completed turnup. No attachments may be
    ///   provisioned on this Interconnect.
    ///   - OS_UNDER_MAINTENANCE: An Interconnect that is undergoing internal maintenance. No
    ///   attachments may be provisioned or updated on this Interconnect.
    /// </summary>
    public TerraformExpression OperationalStatus => this["operational_status"];

    /// <summary>
    /// IP address configured on the customer side of the Interconnect link.
    /// The customer should configure this IP address during turnup when prompted by Google NOC.
    /// This can be used only for ping tests.
    /// </summary>
    public TerraformExpression PeerIpAddress => this["peer_ip_address"];

    /// <summary>
    /// Number of links actually provisioned in this interconnect.
    /// </summary>
    public TerraformExpression ProvisionedLinkCount => this["provisioned_link_count"];

    /// <summary>
    /// Reserved for future use.
    /// </summary>
    public TerraformExpression SatisfiesPzs => this["satisfies_pzs"];

    /// <summary>
    /// The current state of Interconnect functionality, which can take one of the following values:
    ///   - ACTIVE: The Interconnect is valid, turned up and ready to use.
    ///   Attachments may be provisioned on this Interconnect.
    ///   - UNPROVISIONED: The Interconnect has not completed turnup. No attachments may b
    ///    provisioned on this Interconnect.
    ///   - UNDER_MAINTENANCE: The Interconnect is undergoing internal maintenance. No attachments may
    ///    be provisioned or updated on this Interconnect.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
