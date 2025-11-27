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
        get => new TerraformReference<double>(this, "connection_limit");
        set => SetArgument("connection_limit", value);
    }

    /// <summary>
    /// The network that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    public TerraformValue<string>? NetworkUrl
    {
        get => new TerraformReference<string>(this, "network_url");
        set => SetArgument("network_url", value);
    }

    /// <summary>
    /// A project that is allowed to connect to this service attachment.
    /// Only one of project_id_or_num and network_url may be set.
    /// </summary>
    public TerraformValue<string>? ProjectIdOrNum
    {
        get => new TerraformReference<string>(this, "project_id_or_num");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "connection_preference");
        set => SetArgument("connection_preference", value);
    }

    /// <summary>
    /// An array of projects that are not allowed to connect to this service
    /// attachment.
    /// </summary>
    public TerraformList<string>? ConsumerRejectLists
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "consumer_reject_lists").ResolveNodes(ctx));
        set => SetArgument("consumer_reject_lists", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domain_names").ResolveNodes(ctx));
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
        get => new TerraformReference<bool>(this, "enable_proxy_protocol");
        set => SetArgument("enable_proxy_protocol", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// An array of subnets that is provided for NAT in this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NatSubnets is required")]
    public TerraformList<string>? NatSubnets
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "nat_subnets").ResolveNodes(ctx));
        set => SetArgument("nat_subnets", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
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
        get => new TerraformReference<double>(this, "propagated_connection_limit");
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
        get => new TerraformReference<bool>(this, "reconcile_connections");
        set => SetArgument("reconcile_connections", value);
    }

    /// <summary>
    /// URL of the region where the resource resides.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
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
        get => new TerraformReference<bool>(this, "send_propagated_connection_limit_if_zero");
        set => SetArgument("send_propagated_connection_limit_if_zero", value);
    }

    /// <summary>
    /// The URL of a service serving the endpoint identified by this service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetService is required")]
    public required TerraformValue<string> TargetService
    {
        get => new TerraformReference<string>(this, "target_service");
        set => SetArgument("target_service", value);
    }

    /// <summary>
    /// An array of the consumer forwarding rules connected to this service
    /// attachment.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectedEndpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connected_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// An 128-bit global unique ID of the PSC service attachment.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscServiceAttachmentId
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_service_attachment_id").ResolveNodes(ctx));
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

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
