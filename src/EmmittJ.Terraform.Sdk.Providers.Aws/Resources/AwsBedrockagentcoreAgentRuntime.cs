using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? AgentRuntimeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_runtime_name")?.Value;
        set => this.WithProperty("agent_runtime_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, string>? EnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("environment_variables")?.Value;
        set => this.WithProperty("environment_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The lifecycle_configuration attribute.
    /// </summary>
    public List<object>? LifecycleConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("lifecycle_configuration")?.Value;
        set => this.WithProperty("lifecycle_configuration", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
