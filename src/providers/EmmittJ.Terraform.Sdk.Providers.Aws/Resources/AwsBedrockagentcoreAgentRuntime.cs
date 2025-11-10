using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_runtime_artifact in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for authorizer_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkMode is required")]
    [TerraformPropertyName("network_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkMode { get; set; }

}

/// <summary>
/// Block type for protocol_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    [TerraformPropertyName("server_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServerProtocol { get; set; }

}

/// <summary>
/// Block type for request_header_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The request_header_allowlist attribute.
    /// </summary>
    [TerraformPropertyName("request_header_allowlist")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RequestHeaderAllowlist { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AgentRuntimeName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The lifecycle_configuration attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_configuration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> LifecycleConfiguration { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "lifecycle_configuration");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for agent_runtime_artifact.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("agent_runtime_artifact")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock>>? AgentRuntimeArtifact { get; set; } = new();

    /// <summary>
    /// Block for authorizer_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("authorizer_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock>>? AuthorizerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock>>? NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for protocol_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("protocol_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock>>? ProtocolConfiguration { get; set; } = new();

    /// <summary>
    /// Block for request_header_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("request_header_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock>>? RequestHeaderConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentcoreAgentRuntimeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The agent_runtime_arn attribute.
    /// </summary>
    [TerraformPropertyName("agent_runtime_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentRuntimeArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_runtime_arn");

    /// <summary>
    /// The agent_runtime_id attribute.
    /// </summary>
    [TerraformPropertyName("agent_runtime_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentRuntimeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_runtime_id");

    /// <summary>
    /// The agent_runtime_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_runtime_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentRuntimeVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_runtime_version");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    [TerraformPropertyName("workload_identity_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WorkloadIdentityDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "workload_identity_details");

}
