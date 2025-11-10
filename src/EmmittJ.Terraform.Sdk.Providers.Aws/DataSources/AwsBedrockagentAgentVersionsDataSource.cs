using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_version_summaries in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock : TerraformBlock
{
    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    public TerraformProperty<string>? AgentName
    {
        get => GetProperty<TerraformProperty<string>>("agent_name");
        set => WithProperty("agent_name", value);
    }

    /// <summary>
    /// The agent_status attribute.
    /// </summary>
    public TerraformProperty<string>? AgentStatus
    {
        get => GetProperty<TerraformProperty<string>>("agent_status");
        set => WithProperty("agent_status", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformProperty<string>? AgentVersion
    {
        get => GetProperty<TerraformProperty<string>>("agent_version");
        set => WithProperty("agent_version", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformProperty<string>? CreatedAt
    {
        get => GetProperty<TerraformProperty<string>>("created_at");
        set => WithProperty("created_at", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformProperty<string>? UpdatedAt
    {
        get => GetProperty<TerraformProperty<string>>("updated_at");
        set => WithProperty("updated_at", value);
    }

}

/// <summary>
/// Retrieves information about a aws_bedrockagent_agent_versions.
/// </summary>
public class AwsBedrockagentAgentVersionsDataSource : TerraformDataSource
{
    public AwsBedrockagentAgentVersionsDataSource(string name) : base("aws_bedrockagent_agent_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformProperty<string> AgentId
    {
        get => GetProperty<TerraformProperty<string>>("agent_id");
        set => this.WithProperty("agent_id", value);
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
    /// Block for agent_version_summaries.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock>? AgentVersionSummaries
    {
        get => GetProperty<List<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock>>("agent_version_summaries");
        set => this.WithProperty("agent_version_summaries", value);
    }

}
