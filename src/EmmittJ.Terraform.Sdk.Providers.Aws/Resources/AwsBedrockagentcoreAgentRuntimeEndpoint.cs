using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_agent_runtime_endpoint resource.
/// </summary>
public class AwsBedrockagentcoreAgentRuntimeEndpoint : TerraformResource
{
    public AwsBedrockagentcoreAgentRuntimeEndpoint(string name) : base("aws_bedrockagentcore_agent_runtime_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("agent_runtime_arn");
        this.DeclareOutput("agent_runtime_endpoint_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The agent_runtime_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentRuntimeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_runtime_id");
        set => this.WithProperty("agent_runtime_id", value);
    }

    /// <summary>
    /// The agent_runtime_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AgentRuntimeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_runtime_version");
        set => this.WithProperty("agent_runtime_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The agent_runtime_arn attribute.
    /// </summary>
    public TerraformExpression AgentRuntimeArn => this["agent_runtime_arn"];

    /// <summary>
    /// The agent_runtime_endpoint_arn attribute.
    /// </summary>
    public TerraformExpression AgentRuntimeEndpointArn => this["agent_runtime_endpoint_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
