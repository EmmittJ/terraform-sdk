using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_runtime_artifact in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for authorizer_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkMode is required")]
    [TerraformProperty("network_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkMode { get; set; }

}

/// <summary>
/// Block type for protocol_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    [TerraformProperty("server_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerProtocol { get; set; }

}

/// <summary>
/// Block type for request_header_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The request_header_allowlist attribute.
    /// </summary>
    [TerraformProperty("request_header_allowlist")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RequestHeaderAllowlist { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntimeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagentcore_agent_runtime resource.
/// </summary>
public partial class AwsBedrockagentcoreAgentRuntime : TerraformResource
{
    public AwsBedrockagentcoreAgentRuntime(string name) : base("aws_bedrockagentcore_agent_runtime", name)
    {
    }

    /// <summary>
    /// The agent_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentRuntimeName is required")]
    [TerraformProperty("agent_runtime_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgentRuntimeName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The lifecycle_configuration attribute.
    /// </summary>
    [TerraformProperty("lifecycle_configuration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> LifecycleConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for agent_runtime_artifact.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("agent_runtime_artifact")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock>>? AgentRuntimeArtifact { get; set; }

    /// <summary>
    /// Block for authorizer_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("authorizer_configuration")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock>>? AuthorizerConfiguration { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_configuration")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for protocol_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("protocol_configuration")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock>>? ProtocolConfiguration { get; set; }

    /// <summary>
    /// Block for request_header_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("request_header_configuration")]
    public partial TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock>>? RequestHeaderConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsBedrockagentcoreAgentRuntimeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The agent_runtime_arn attribute.
    /// </summary>
    [TerraformProperty("agent_runtime_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentRuntimeArn { get; }

    /// <summary>
    /// The agent_runtime_id attribute.
    /// </summary>
    [TerraformProperty("agent_runtime_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentRuntimeId { get; }

    /// <summary>
    /// The agent_runtime_version attribute.
    /// </summary>
    [TerraformProperty("agent_runtime_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentRuntimeVersion { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    [TerraformProperty("workload_identity_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WorkloadIdentityDetails { get; }

}
