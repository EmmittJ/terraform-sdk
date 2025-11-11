using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_runtime_artifact in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock
{
}

/// <summary>
/// Block type for authorizer_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock
{
    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkMode is required")]
    [TerraformPropertyName("network_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NetworkMode { get; set; }

}

/// <summary>
/// Block type for protocol_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock
{
    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    [TerraformPropertyName("server_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerProtocol { get; set; }

}

/// <summary>
/// Block type for request_header_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock
{
    /// <summary>
    /// The request_header_allowlist attribute.
    /// </summary>
    [TerraformPropertyName("request_header_allowlist")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? RequestHeaderAllowlist { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagentcore_agent_runtime resource.
/// </summary>
public class AwsBedrockagentcoreAgentRuntime : TerraformResource
{
    public AwsBedrockagentcoreAgentRuntime(string name) : base("aws_bedrockagentcore_agent_runtime", name)
    {
    }

    /// <summary>
    /// The agent_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentRuntimeName is required")]
    [TerraformPropertyName("agent_runtime_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AgentRuntimeName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The lifecycle_configuration attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_configuration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> LifecycleConfiguration { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for agent_runtime_artifact.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("agent_runtime_artifact")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock>>? AgentRuntimeArtifact { get; set; }

    /// <summary>
    /// Block for authorizer_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("authorizer_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock>>? AuthorizerConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for protocol_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("protocol_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock>>? ProtocolConfiguration { get; set; }

    /// <summary>
    /// Block for request_header_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("request_header_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock>>? RequestHeaderConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentcoreAgentRuntimeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The agent_runtime_arn attribute.
    /// </summary>
    [TerraformPropertyName("agent_runtime_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentRuntimeArn => new TerraformReference(this, "agent_runtime_arn");

    /// <summary>
    /// The agent_runtime_id attribute.
    /// </summary>
    [TerraformPropertyName("agent_runtime_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentRuntimeId => new TerraformReference(this, "agent_runtime_id");

    /// <summary>
    /// The agent_runtime_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_runtime_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentRuntimeVersion => new TerraformReference(this, "agent_runtime_version");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    [TerraformPropertyName("workload_identity_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WorkloadIdentityDetails => new TerraformReference(this, "workload_identity_details");

}
