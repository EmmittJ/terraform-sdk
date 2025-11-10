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
        set => SetProperty("agent_name", value);
    }

    /// <summary>
    /// The agent_status attribute.
    /// </summary>
    public TerraformProperty<string>? AgentStatus
    {
        set => SetProperty("agent_status", value);
    }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformProperty<string>? AgentVersion
    {
        set => SetProperty("agent_version", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformProperty<string>? CreatedAt
    {
        set => SetProperty("created_at", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformProperty<string>? UpdatedAt
    {
        set => SetProperty("updated_at", value);
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
        SetOutput("agent_id");
        SetOutput("region");
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformProperty<string> AgentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_id");
        set => SetProperty("agent_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for agent_version_summaries.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock>? AgentVersionSummaries
    {
        set => SetProperty("agent_version_summaries", value);
    }

}
