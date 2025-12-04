using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_version_summaries in AwsBedrockagentAgentVersionsDataSource.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "agent_version_summaries";

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    public TerraformValue<string> AgentName
        => AsReference("agent_name");

    /// <summary>
    /// The agent_status attribute.
    /// </summary>
    public TerraformValue<string> AgentStatus
        => AsReference("agent_status");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformValue<string> AgentVersion
        => AsReference("agent_version");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// GuardrailConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlockGuardrailConfigurationBlock>? GuardrailConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlockGuardrailConfigurationBlock>>("guardrail_configuration");
        set => SetArgument("guardrail_configuration", value);
    }

}

/// <summary>
/// Block type for guardrail_configuration in AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlockGuardrailConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "guardrail_configuration";

    /// <summary>
    /// The guardrail_identifier attribute.
    /// </summary>
    public TerraformValue<string> GuardrailIdentifier
        => AsReference("guardrail_identifier");

    /// <summary>
    /// The guardrail_version attribute.
    /// </summary>
    public TerraformValue<string> GuardrailVersion
        => AsReference("guardrail_version");

}


/// <summary>
/// Represents a aws_bedrockagent_agent_versions Terraform data source.
/// Retrieves information about a aws_bedrockagent_agent_versions.
/// </summary>
public partial class AwsBedrockagentAgentVersionsDataSource(string name) : TerraformDataSource("aws_bedrockagent_agent_versions", name)
{
    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    public required TerraformValue<string> AgentId
    {
        get => GetArgument<TerraformValue<string>>("agent_id");
        set => SetArgument("agent_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// AgentVersionSummaries block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock>? AgentVersionSummaries
    {
        get => GetArgument<TerraformList<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock>>("agent_version_summaries");
        set => SetArgument("agent_version_summaries", value);
    }

}
