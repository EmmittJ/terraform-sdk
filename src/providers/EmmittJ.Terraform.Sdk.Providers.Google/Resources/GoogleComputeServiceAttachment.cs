using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for consumer_accept_lists in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeServiceAttachmentConsumerAcceptListsBlock : TerraformBlock
{
    /// <summary>
    /// The number of consumer forwarding rules the consumer project can
    /// create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLimit is required")]
    public required TerraformProperty<double> ConnectionLimit
    {
        get => GetRequiredProperty<TerraformProperty<double>>("connection_limit");
        set => WithProperty("connection_limit", value);
    }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    public TerraformProperty<string>? NetworkUrl
    {
        get => GetProperty<TerraformProperty<string>>("network_url");
        set => WithProperty("network_url", value);
    }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    public TerraformProperty<string>? ProjectIdOrNum
    {
        get => GetProperty<TerraformProperty<string>>("project_id_or_num");
        set => WithProperty("project_id_or_num", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeServiceAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_service_attachment resource.
/// </summary>
public class GoogleComputeServiceAttachment : TerraformResource
{
    public GoogleComputeServiceAttachment(string name) : base("google_compute_service_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connected_endpoints");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("psc_service_attachment_id");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// The connection preference to use for this service attachment. Valid
    /// values include &amp;quot;ACCEPT_AUTOMATIC&amp;quot;, &amp;quot;ACCEPT_MANUAL&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPreference is required")]
    public required TerraformProperty<string> ConnectionPreference
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_preference");
        set => this.WithProperty("connection_preference", value);
    }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    public List<TerraformProperty<string>>? ConsumerRejectLists
    {
        get => GetProperty<List<TerraformProperty<string>>>("consumer_reject_lists");
        set => this.WithProperty("consumer_reject_lists", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &amp;quot;p.mycompany.com.&amp;quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    public List<TerraformProperty<string>>? DomainNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("domain_names");
        set => this.WithProperty("domain_names", value);
    }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableProxyProtocol is required")]
    public required TerraformProperty<bool> EnableProxyProtocol
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enable_proxy_protocol");
        set => this.WithProperty("enable_proxy_protocol", value);
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
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// An array of subnets that is provided for NAT in this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatSubnets is required")]
    public List<TerraformProperty<string>>? NatSubnets
    {
        get => GetProperty<List<TerraformProperty<string>>>("nat_subnets");
        set => this.WithProperty("nat_subnets", value);
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
    /// The number of consumer spokes that connected Private Service Connect endpoints can be propagated to through Network Connectivity Center.
    /// This limit lets the service producer limit how many propagated Private Service Connect connections can be established to this service attachment from a single consumer.
    /// 
    /// If the connection preference of the service attachment is ACCEPT_MANUAL, the limit applies to each project or network that is listed in the consumer accept list.
    /// If the connection preference of the service attachment is ACCEPT_AUTOMATIC, the limit applies to each project that contains a connected endpoint.
    /// 
    /// If unspecified, the default propagated connection limit is 250. To explicitly send a zero value, set &#39;send_propagated_connection_limit_if_zero = true&#39;.
    /// </summary>
    public TerraformProperty<double>? PropagatedConnectionLimit
    {
        get => GetProperty<TerraformProperty<double>>("propagated_connection_limit");
        set => this.WithProperty("propagated_connection_limit", value);
    }

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// 
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    public TerraformProperty<bool>? ReconcileConnections
    {
        get => GetProperty<TerraformProperty<bool>>("reconcile_connections");
        set => this.WithProperty("reconcile_connections", value);
    }

    /// <summary>
    /// URL of the region where the resource resides.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&#39;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? SendPropagatedConnectionLimitIfZero
    {
        get => GetProperty<TerraformProperty<bool>>("send_propagated_connection_limit_if_zero");
        set => this.WithProperty("send_propagated_connection_limit_if_zero", value);
    }

    /// <summary>
    /// The URL of a service serving the endpoint identified by this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetService is required")]
    public required TerraformProperty<string> TargetService
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_service");
        set => this.WithProperty("target_service", value);
    }

    /// <summary>
    /// Block for consumer_accept_lists.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeServiceAttachmentConsumerAcceptListsBlock>? ConsumerAcceptLists
    {
        get => GetProperty<HashSet<GoogleComputeServiceAttachmentConsumerAcceptListsBlock>>("consumer_accept_lists");
        set => this.WithProperty("consumer_accept_lists", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeServiceAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeServiceAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// An array of the consumer forwarding rules connected to this service
    /// attachment.
    /// </summary>
    public TerraformExpression ConnectedEndpoints => this["connected_endpoints"];

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// An 128-bit global unique ID of the PSC service attachment.
    /// </summary>
    public TerraformExpression PscServiceAttachmentId => this["psc_service_attachment_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
