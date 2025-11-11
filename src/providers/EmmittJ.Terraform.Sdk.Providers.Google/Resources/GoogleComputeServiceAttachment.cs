using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for consumer_accept_lists in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeServiceAttachmentConsumerAcceptListsBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of consumer forwarding rules the consumer project can
    /// create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLimit is required")]
    [TerraformProperty("connection_limit")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ConnectionLimit { get; set; }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [TerraformProperty("network_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkUrl { get; set; }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [TerraformProperty("project_id_or_num")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProjectIdOrNum { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeServiceAttachmentTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_compute_service_attachment resource.
/// </summary>
public partial class GoogleComputeServiceAttachment : TerraformResource
{
    public GoogleComputeServiceAttachment(string name) : base("google_compute_service_attachment", name)
    {
    }

    /// <summary>
    /// The connection preference to use for this service attachment. Valid
    /// values include &amp;quot;ACCEPT_AUTOMATIC&amp;quot;, &amp;quot;ACCEPT_MANUAL&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPreference is required")]
    [TerraformProperty("connection_preference")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionPreference { get; set; }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    [TerraformProperty("consumer_reject_lists")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ConsumerRejectLists { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &amp;quot;p.mycompany.com.&amp;quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    [TerraformProperty("domain_names")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DomainNames { get; set; }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableProxyProtocol is required")]
    [TerraformProperty("enable_proxy_protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> EnableProxyProtocol { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// An array of subnets that is provided for NAT in this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatSubnets is required")]
    [TerraformProperty("nat_subnets")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? NatSubnets { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The number of consumer spokes that connected Private Service Connect endpoints can be propagated to through Network Connectivity Center.
    /// This limit lets the service producer limit how many propagated Private Service Connect connections can be established to this service attachment from a single consumer.
    /// 
    /// If the connection preference of the service attachment is ACCEPT_MANUAL, the limit applies to each project or network that is listed in the consumer accept list.
    /// If the connection preference of the service attachment is ACCEPT_AUTOMATIC, the limit applies to each project that contains a connected endpoint.
    /// 
    /// If unspecified, the default propagated connection limit is 250. To explicitly send a zero value, set &#39;send_propagated_connection_limit_if_zero = true&#39;.
    /// </summary>
    [TerraformProperty("propagated_connection_limit")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> PropagatedConnectionLimit { get; set; }

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// 
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    [TerraformProperty("reconcile_connections")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ReconcileConnections { get; set; }

    /// <summary>
    /// URL of the region where the resource resides.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&#39;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    [TerraformProperty("send_propagated_connection_limit_if_zero")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SendPropagatedConnectionLimitIfZero { get; set; }

    /// <summary>
    /// The URL of a service serving the endpoint identified by this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetService is required")]
    [TerraformProperty("target_service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetService { get; set; }

    /// <summary>
    /// Block for consumer_accept_lists.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("consumer_accept_lists")]
    public TerraformSet<TerraformBlock<GoogleComputeServiceAttachmentConsumerAcceptListsBlock>>? ConsumerAcceptLists { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeServiceAttachmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// An array of the consumer forwarding rules connected to this service
    /// attachment.
    /// </summary>
    [TerraformProperty("connected_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConnectedEndpoints { get; }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// An 128-bit global unique ID of the PSC service attachment.
    /// </summary>
    [TerraformProperty("psc_service_attachment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PscServiceAttachmentId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

}
