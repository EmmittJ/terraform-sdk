using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for consumer_accept_lists in GoogleComputeServiceAttachment.
/// Nesting mode: set
/// </summary>
public class GoogleComputeServiceAttachmentConsumerAcceptListsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consumer_accept_lists";

    /// <summary>
    /// The number of consumer forwarding rules the consumer project can
    /// create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionLimit is required")]
    public required TerraformValue<double> ConnectionLimit
    {
        get => GetRequiredArgument<TerraformValue<double>>("connection_limit");
        set => SetArgument("connection_limit", value);
    }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    public TerraformValue<string>? NetworkUrl
    {
        get => GetArgument<TerraformValue<string>>("network_url");
        set => SetArgument("network_url", value);
    }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    public TerraformValue<string>? ProjectIdOrNum
    {
        get => GetArgument<TerraformValue<string>>("project_id_or_num");
        set => SetArgument("project_id_or_num", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeServiceAttachment.
/// Nesting mode: single
/// </summary>
public class GoogleComputeServiceAttachmentTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_service_attachment Terraform resource.
/// Manages a google_compute_service_attachment resource.
/// </summary>
public partial class GoogleComputeServiceAttachment(string name) : TerraformResource("google_compute_service_attachment", name)
{
    /// <summary>
    /// The connection preference to use for this service attachment. Valid
    /// values include &amp;quot;ACCEPT_AUTOMATIC&amp;quot;, &amp;quot;ACCEPT_MANUAL&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPreference is required")]
    public required TerraformValue<string> ConnectionPreference
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_preference");
        set => SetArgument("connection_preference", value);
    }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    public TerraformList<string>? ConsumerRejectLists
    {
        get => GetArgument<TerraformList<string>>("consumer_reject_lists");
        set => SetArgument("consumer_reject_lists", value);
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
    /// If specified, the domain name will be used during the integration between
    /// the PSC connected endpoints and the Cloud DNS. For example, this is a
    /// valid domain name: &amp;quot;p.mycompany.com.&amp;quot;. Current max number of domain names
    /// supported is 1.
    /// </summary>
    public TerraformList<string>? DomainNames
    {
        get => GetArgument<TerraformList<string>>("domain_names");
        set => SetArgument("domain_names", value);
    }

    /// <summary>
    /// If true, enable the proxy protocol which is for supplying client TCP/IP
    /// address data in TCP connections that traverse proxies on their way to
    /// destination servers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableProxyProtocol is required")]
    public required TerraformValue<bool> EnableProxyProtocol
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_proxy_protocol");
        set => SetArgument("enable_proxy_protocol", value);
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
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// An array of subnets that is provided for NAT in this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatSubnets is required")]
    public TerraformList<string>? NatSubnets
    {
        get => GetArgument<TerraformList<string>>("nat_subnets");
        set => SetArgument("nat_subnets", value);
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
    /// The number of consumer spokes that connected Private Service Connect endpoints can be propagated to through Network Connectivity Center.
    /// This limit lets the service producer limit how many propagated Private Service Connect connections can be established to this service attachment from a single consumer.
    /// 
    /// If the connection preference of the service attachment is ACCEPT_MANUAL, the limit applies to each project or network that is listed in the consumer accept list.
    /// If the connection preference of the service attachment is ACCEPT_AUTOMATIC, the limit applies to each project that contains a connected endpoint.
    /// 
    /// If unspecified, the default propagated connection limit is 250. To explicitly send a zero value, set &#39;send_propagated_connection_limit_if_zero = true&#39;.
    /// </summary>
    public TerraformValue<double> PropagatedConnectionLimit
    {
        get => GetArgument<TerraformValue<double>>("propagated_connection_limit") ?? AsReference("propagated_connection_limit");
        set => SetArgument("propagated_connection_limit", value);
    }

    /// <summary>
    /// This flag determines whether a consumer accept/reject list change can reconcile the statuses of existing ACCEPTED or REJECTED PSC endpoints.
    /// 
    /// If false, connection policy update will only affect existing PENDING PSC endpoints. Existing ACCEPTED/REJECTED endpoints will remain untouched regardless how the connection policy is modified .
    /// If true, update will affect both PENDING and ACCEPTED/REJECTED PSC endpoints. For example, an ACCEPTED PSC endpoint will be moved to REJECTED if its project is added to the reject list.
    /// </summary>
    public TerraformValue<bool> ReconcileConnections
    {
        get => GetArgument<TerraformValue<bool>>("reconcile_connections") ?? AsReference("reconcile_connections");
        set => SetArgument("reconcile_connections", value);
    }

    /// <summary>
    /// URL of the region where the resource resides.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Controls the behavior of propagated_connection_limit.
    /// When false, setting propagated_connection_limit to zero causes the provider to use to the API&#39;s default value.
    /// When true, the provider will set propagated_connection_limit to zero.
    /// Defaults to false.
    /// </summary>
    public TerraformValue<bool>? SendPropagatedConnectionLimitIfZero
    {
        get => GetArgument<TerraformValue<bool>>("send_propagated_connection_limit_if_zero");
        set => SetArgument("send_propagated_connection_limit_if_zero", value);
    }

    /// <summary>
    /// The URL of a service serving the endpoint identified by this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetService is required")]
    public required TerraformValue<string> TargetService
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_service");
        set => SetArgument("target_service", value);
    }

    /// <summary>
    /// An array of the consumer forwarding rules connected to this service
    /// attachment.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectedEndpoints
        => AsReference("connected_endpoints");

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// An 128-bit global unique ID of the PSC service attachment.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscServiceAttachmentId
        => AsReference("psc_service_attachment_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// ConsumerAcceptLists block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeServiceAttachmentConsumerAcceptListsBlock>? ConsumerAcceptLists
    {
        get => GetArgument<TerraformSet<GoogleComputeServiceAttachmentConsumerAcceptListsBlock>>("consumer_accept_lists");
        set => SetArgument("consumer_accept_lists", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeServiceAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeServiceAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
