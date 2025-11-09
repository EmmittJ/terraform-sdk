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
    public TerraformProperty<string>? AgentRuntimeName
    {
        get => GetProperty<TerraformProperty<string>>("agent_runtime_name");
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
    public TerraformMapProperty<string>? EnvironmentVariables
    {
        get => GetProperty<TerraformMapProperty<string>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The lifecycle_configuration attribute.
    /// </summary>
    public TerraformProperty<List<object>>? LifecycleConfiguration
    {
        get => GetProperty<TerraformProperty<List<object>>>("lifecycle_configuration");
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
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
