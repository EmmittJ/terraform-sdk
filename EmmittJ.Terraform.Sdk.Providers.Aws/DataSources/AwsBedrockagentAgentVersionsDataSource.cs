using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? AgentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_id")?.Value;
        set => this.WithProperty("agent_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
