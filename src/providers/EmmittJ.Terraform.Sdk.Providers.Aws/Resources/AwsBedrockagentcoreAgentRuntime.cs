using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_runtime_artifact in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock : TerraformBlock
{
}

/// <summary>
/// Block type for authorizer_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkMode is required")]
    public required TerraformProperty<string> NetworkMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network_mode");
        set => WithProperty("network_mode", value);
    }

}

/// <summary>
/// Block type for protocol_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ServerProtocol
    {
        get => GetProperty<TerraformProperty<string>>("server_protocol");
        set => WithProperty("server_protocol", value);
    }

}

/// <summary>
/// Block type for request_header_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The request_header_allowlist attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RequestHeaderAllowlist
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("request_header_allowlist");
        set => WithProperty("request_header_allowlist", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_bedrockagentcore_agent_runtime resource.
/// </summary>
public class AwsBedrockagentcoreAgentRuntime : TerraformResource
{
    public AwsBedrockagentcoreAgentRuntime(string name) : base("aws_bedrockagentcore_agent_runtime", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("agent_runtime_arn");
        this.DeclareOutput("agent_runtime_id");
        this.DeclareOutput("agent_runtime_version");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("workload_identity_details");
    }

    /// <summary>
    /// The agent_runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentRuntimeName is required")]
    public required TerraformProperty<string> AgentRuntimeName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("agent_runtime_name");
        set => this.WithProperty("agent_runtime_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The lifecycle_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>>? LifecycleConfiguration
    {
        get => GetProperty<List<TerraformProperty<object>>>("lifecycle_configuration");
        set => this.WithProperty("lifecycle_configuration", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for agent_runtime_artifact.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock>? AgentRuntimeArtifact
    {
        get => GetProperty<List<AwsBedrockagentcoreAgentRuntimeAgentRuntimeArtifactBlock>>("agent_runtime_artifact");
        set => this.WithProperty("agent_runtime_artifact", value);
    }

    /// <summary>
    /// Block for authorizer_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock>? AuthorizerConfiguration
    {
        get => GetProperty<List<AwsBedrockagentcoreAgentRuntimeAuthorizerConfigurationBlock>>("authorizer_configuration");
        set => this.WithProperty("authorizer_configuration", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetProperty<List<AwsBedrockagentcoreAgentRuntimeNetworkConfigurationBlock>>("network_configuration");
        set => this.WithProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for protocol_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock>? ProtocolConfiguration
    {
        get => GetProperty<List<AwsBedrockagentcoreAgentRuntimeProtocolConfigurationBlock>>("protocol_configuration");
        set => this.WithProperty("protocol_configuration", value);
    }

    /// <summary>
    /// Block for request_header_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock>? RequestHeaderConfiguration
    {
        get => GetProperty<List<AwsBedrockagentcoreAgentRuntimeRequestHeaderConfigurationBlock>>("request_header_configuration");
        set => this.WithProperty("request_header_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentcoreAgentRuntimeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockagentcoreAgentRuntimeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The agent_runtime_arn attribute.
    /// </summary>
    public TerraformExpression AgentRuntimeArn => this["agent_runtime_arn"];

    /// <summary>
    /// The agent_runtime_id attribute.
    /// </summary>
    public TerraformExpression AgentRuntimeId => this["agent_runtime_id"];

    /// <summary>
    /// The agent_runtime_version attribute.
    /// </summary>
    public TerraformExpression AgentRuntimeVersion => this["agent_runtime_version"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    public TerraformExpression WorkloadIdentityDetails => this["workload_identity_details"];

}
