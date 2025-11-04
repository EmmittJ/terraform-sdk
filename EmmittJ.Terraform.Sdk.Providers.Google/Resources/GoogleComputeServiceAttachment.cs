using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? ConnectionPreference
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_preference")?.Value;
        set => this.WithProperty("connection_preference", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    public List<string>? ConsumerRejectLists
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("consumer_reject_lists")?.Value;
        set => this.WithProperty("consumer_reject_lists", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &amp;quot;p.mycompany.com.&amp;quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    public List<string>? DomainNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("domain_names")?.Value;
        set => this.WithProperty("domain_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    public bool? EnableProxyProtocol
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_proxy_protocol")?.Value;
        set => this.WithProperty("enable_proxy_protocol", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An array of subnets that is provided for NAT in this service attachment.
    /// </summary>
    public List<string>? NatSubnets
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("nat_subnets")?.Value;
        set => this.WithProperty("nat_subnets", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public double? PropagatedConnectionLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("propagated_connection_limit")?.Value;
        set => this.WithProperty("propagated_connection_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// 
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    public bool? ReconcileConnections
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("reconcile_connections")?.Value;
        set => this.WithProperty("reconcile_connections", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// URL of the region where the resource resides.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&#39;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    public bool? SendPropagatedConnectionLimitIfZero
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("send_propagated_connection_limit_if_zero")?.Value;
        set => this.WithProperty("send_propagated_connection_limit_if_zero", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The URL of a service serving the endpoint identified by this service attachment.
    /// </summary>
    public string? TargetService
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_service")?.Value;
        set => this.WithProperty("target_service", value == null ? null : new TerraformLiteralProperty<string>(value));
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
