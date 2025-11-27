using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_runtime_artifact in AwsBedrockagentcoreAgentRuntime.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent_runtime_artifact";

    /// <summary>
    /// ContainerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlockContainerConfigurationBlock>? ContainerConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlockContainerConfigurationBlock>>("container_configuration");
        set => SetArgument("container_configuration", value);
    }

}

/// <summary>
/// Block type for container_configuration in AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlockContainerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_configuration";

    /// <summary>
    /// The container_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerUri is required")]
    public required TerraformValue<string> ContainerUri
    {
        get => new TerraformReference<string>(this, "container_uri");
        set => SetArgument("container_uri", value);
    }

}


/// <summary>
/// Block type for authorizer_configuration in AwsBedrockagentcoreAgentRuntime.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorizer_configuration";

    /// <summary>
    /// CustomJwtAuthorizer block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlockCustomJwtAuthorizerBlock>? CustomJwtAuthorizer
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlockCustomJwtAuthorizerBlock>>("custom_jwt_authorizer");
        set => SetArgument("custom_jwt_authorizer", value);
    }

}

/// <summary>
/// Block type for custom_jwt_authorizer in AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlockCustomJwtAuthorizerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_jwt_authorizer";

    /// <summary>
    /// The allowed_audience attribute.
    /// </summary>
    public TerraformSet<string>? AllowedAudience
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_audience").ResolveNodes(ctx));
        set => SetArgument("allowed_audience", value);
    }

    /// <summary>
    /// The allowed_clients attribute.
    /// </summary>
    public TerraformSet<string>? AllowedClients
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_clients").ResolveNodes(ctx));
        set => SetArgument("allowed_clients", value);
    }

    /// <summary>
    /// The discovery_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiscoveryUrl is required")]
    public required TerraformValue<string> DiscoveryUrl
    {
        get => new TerraformReference<string>(this, "discovery_url");
        set => SetArgument("discovery_url", value);
    }

}


/// <summary>
/// Block type for network_configuration in AwsBedrockagentcoreAgentRuntime.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkMode is required")]
    public required TerraformValue<string> NetworkMode
    {
        get => new TerraformReference<string>(this, "network_mode");
        set => SetArgument("network_mode", value);
    }

    /// <summary>
    /// NetworkModeConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlockNetworkModeConfigBlock>? NetworkModeConfig
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlockNetworkModeConfigBlock>>("network_mode_config");
        set => SetArgument("network_mode_config", value);
    }

}

/// <summary>
/// Block type for network_mode_config in AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlockNetworkModeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_mode_config";

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroups is required")]
    public required TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Block type for protocol_configuration in AwsBedrockagentcoreAgentRuntime.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protocol_configuration";

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ServerProtocol
    {
        get => new TerraformReference<string>(this, "server_protocol");
        set => SetArgument("server_protocol", value);
    }

}


/// <summary>
/// Block type for request_header_configuration in AwsBedrockagentcoreAgentRuntime.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_header_configuration";

    /// <summary>
    /// The request_header_allowlist attribute.
    /// </summary>
    public TerraformSet<string>? RequestHeaderAllowlist
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "request_header_allowlist").ResolveNodes(ctx));
        set => SetArgument("request_header_allowlist", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentcoreAgentRuntime.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagentcore_agent_runtime Terraform resource.
/// Manages a aws_bedrockagentcore_agent_runtime resource.
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntime(string name) : TerraformResource("aws_bedrockagentcore_agent_runtime", name)
{
    /// <summary>
    /// The agent_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentRuntimeName is required")]
    public required TerraformValue<string> AgentRuntimeName
    {
        get => new TerraformReference<string>(this, "agent_runtime_name");
        set => SetArgument("agent_runtime_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The lifecycle_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LifecycleConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "lifecycle_configuration").ResolveNodes(ctx));
        set => SetArgument("lifecycle_configuration", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The agent_runtime_arn attribute.
    /// </summary>
    public TerraformValue<string> AgentRuntimeArn
    {
        get => new TerraformReference<string>(this, "agent_runtime_arn");
    }

    /// <summary>
    /// The agent_runtime_id attribute.
    /// </summary>
    public TerraformValue<string> AgentRuntimeId
    {
        get => new TerraformReference<string>(this, "agent_runtime_id");
    }

    /// <summary>
    /// The agent_runtime_version attribute.
    /// </summary>
    public TerraformValue<string> AgentRuntimeVersion
    {
        get => new TerraformReference<string>(this, "agent_runtime_version");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WorkloadIdentityDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "workload_identity_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// AgentRuntimeArtifact block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock>? AgentRuntimeArtifact
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock>>("agent_runtime_artifact");
        set => SetArgument("agent_runtime_artifact", value);
    }

    /// <summary>
    /// AuthorizerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock>? AuthorizerConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock>>("authorizer_configuration");
        set => SetArgument("authorizer_configuration", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// ProtocolConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock>? ProtocolConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock>>("protocol_configuration");
        set => SetArgument("protocol_configuration", value);
    }

    /// <summary>
    /// RequestHeaderConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock>? RequestHeaderConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock>>("request_header_configuration");
        set => SetArgument("request_header_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentcoreAgentRuntimeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentcoreAgentRuntimeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
