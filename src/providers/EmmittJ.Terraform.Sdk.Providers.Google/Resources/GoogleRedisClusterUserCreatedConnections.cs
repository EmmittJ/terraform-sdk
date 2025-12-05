using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cluster_endpoints in GoogleRedisClusterUserCreatedConnections.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_endpoints";

    /// <summary>
    /// Connections block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlockConnectionsBlock>? Connections
    {
        get => GetArgument<TerraformList<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlockConnectionsBlock>>("connections");
        set => SetArgument("connections", value);
    }

}

/// <summary>
/// Block type for connections in GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlockConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connections";

    /// <summary>
    /// PscConnection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConnection block(s) allowed")]
    public TerraformList<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlockConnectionsBlockPscConnectionBlock>? PscConnection
    {
        get => GetArgument<TerraformList<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlockConnectionsBlockPscConnectionBlock>>("psc_connection");
        set => SetArgument("psc_connection", value);
    }

}

/// <summary>
/// Block type for psc_connection in GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlockConnectionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlockConnectionsBlockPscConnectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_connection";

    /// <summary>
    /// The IP allocated on the consumer network for the PSC forwarding rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetRequiredArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// Output Only. Type of a PSC Connection. 
    ///  Possible values:
    ///  CONNECTION_TYPE_DISCOVERY 
    ///  CONNECTION_TYPE_PRIMARY 
    ///  CONNECTION_TYPE_READER
    /// </summary>
    public TerraformValue<string> ConnectionType
        => CreateReference("connection_type");

    /// <summary>
    /// The URI of the consumer side forwarding rule.
    /// Format:
    /// projects/{project}/regions/{region}/forwardingRules/{forwarding_rule}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRule is required")]
    public required TerraformValue<string> ForwardingRule
    {
        get => GetRequiredArgument<TerraformValue<string>>("forwarding_rule");
        set => SetArgument("forwarding_rule", value);
    }

    /// <summary>
    /// The consumer network where the IP address resides, in the form of
    /// projects/{project_id}/global/networks/{network_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The consumer project_id where the forwarding rule is created from.
    /// </summary>
    public TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id") ?? CreateReference("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The PSC connection id of the forwarding rule connected to the
    /// service attachment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PscConnectionId is required")]
    public required TerraformValue<string> PscConnectionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("psc_connection_id");
        set => SetArgument("psc_connection_id", value);
    }

    /// <summary>
    /// Output Only. The status of the PSC connection: whether a connection exists and ACTIVE or it no longer exists. 
    ///  Possible values:
    ///  ACTIVE 
    ///  NOT_FOUND
    /// </summary>
    public TerraformValue<string> PscConnectionStatus
        => CreateReference("psc_connection_status");

    /// <summary>
    /// The service attachment which is the target of the PSC connection, in the form of projects/{project-id}/regions/{region}/serviceAttachments/{service-attachment-id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAttachment is required")]
    public required TerraformValue<string> ServiceAttachment
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_attachment");
        set => SetArgument("service_attachment", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleRedisClusterUserCreatedConnections.
/// Nesting mode: single
/// </summary>
public class GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock : TerraformBlock
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
/// Represents a google_redis_cluster_user_created_connections Terraform resource.
/// Manages a google_redis_cluster_user_created_connections resource.
/// </summary>
public partial class GoogleRedisClusterUserCreatedConnections(string name) : TerraformResource("google_redis_cluster_user_created_connections", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Redis cluster these endpoints should be added to.
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
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the region of the Redis cluster these endpoints should be added to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetRequiredArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// ClusterEndpoints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock>? ClusterEndpoints
    {
        get => GetArgument<TerraformList<GoogleRedisClusterUserCreatedConnectionsClusterEndpointsBlock>>("cluster_endpoints");
        set => SetArgument("cluster_endpoints", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleRedisClusterUserCreatedConnectionsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
