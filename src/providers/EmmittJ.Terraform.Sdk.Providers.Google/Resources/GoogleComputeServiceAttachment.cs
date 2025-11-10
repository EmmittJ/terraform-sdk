using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for consumer_accept_lists in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeServiceAttachmentConsumerAcceptListsBlock : ITerraformBlock
{
    /// <summary>
    /// The number of consumer forwarding rules the consumer project can
    /// create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLimit is required")]
    [TerraformPropertyName("connection_limit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ConnectionLimit { get; set; }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [TerraformPropertyName("network_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkUrl { get; set; }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    [TerraformPropertyName("project_id_or_num")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProjectIdOrNum { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeServiceAttachmentTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_service_attachment resource.
/// </summary>
public class GoogleComputeServiceAttachment : TerraformResource
{
    public GoogleComputeServiceAttachment(string name) : base("google_compute_service_attachment", name)
    {
    }

    /// <summary>
    /// The connection preference to use for this service attachment. Valid
    /// values include &amp;quot;ACCEPT_AUTOMATIC&amp;quot;, &amp;quot;ACCEPT_MANUAL&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPreference is required")]
    [TerraformPropertyName("connection_preference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionPreference { get; set; }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    [TerraformPropertyName("consumer_reject_lists")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ConsumerRejectLists { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &amp;quot;p.mycompany.com.&amp;quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    [TerraformPropertyName("domain_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DomainNames { get; set; }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableProxyProtocol is required")]
    [TerraformPropertyName("enable_proxy_protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnableProxyProtocol { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// An array of subnets that is provided for NAT in this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatSubnets is required")]
    [TerraformPropertyName("nat_subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? NatSubnets { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The number of consumer spokes that connected Private Service Connect endpoints can be propagated to through Network Connectivity Center.
    /// This limit lets the service producer limit how many propagated Private Service Connect connections can be established to this service attachment from a single consumer.
    /// 
    /// If the connection preference of the service attachment is ACCEPT_MANUAL, the limit applies to each project or network that is listed in the consumer accept list.
    /// If the connection preference of the service attachment is ACCEPT_AUTOMATIC, the limit applies to each project that contains a connected endpoint.
    /// 
    /// If unspecified, the default propagated connection limit is 250. To explicitly send a zero value, set &#39;send_propagated_connection_limit_if_zero = true&#39;.
    /// </summary>
    [TerraformPropertyName("propagated_connection_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PropagatedConnectionLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "propagated_connection_limit");

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// 
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    [TerraformPropertyName("reconcile_connections")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ReconcileConnections { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconcile_connections");

    /// <summary>
    /// URL of the region where the resource resides.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&#39;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    [TerraformPropertyName("send_propagated_connection_limit_if_zero")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SendPropagatedConnectionLimitIfZero { get; set; }

    /// <summary>
    /// The URL of a service serving the endpoint identified by this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetService is required")]
    [TerraformPropertyName("target_service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetService { get; set; }

    /// <summary>
    /// Block for consumer_accept_lists.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("consumer_accept_lists")]
    public TerraformSet<TerraformBlock<GoogleComputeServiceAttachmentConsumerAcceptListsBlock>>? ConsumerAcceptLists { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeServiceAttachmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// An array of the consumer forwarding rules connected to this service
    /// attachment.
    /// </summary>
    [TerraformPropertyName("connected_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectedEndpoints => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connected_endpoints");

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// An 128-bit global unique ID of the PSC service attachment.
    /// </summary>
    [TerraformPropertyName("psc_service_attachment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PscServiceAttachmentId => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "psc_service_attachment_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
