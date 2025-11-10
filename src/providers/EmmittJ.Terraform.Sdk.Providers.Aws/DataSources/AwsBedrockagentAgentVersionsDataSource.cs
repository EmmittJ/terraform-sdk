using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for agent_version_summaries in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock : ITerraformBlock
{
    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [TerraformPropertyName("agent_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentName => new TerraformReferenceProperty<TerraformProperty<string>>("", "agent_name");

    /// <summary>
    /// The agent_status attribute.
    /// </summary>
    [TerraformPropertyName("agent_status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentStatus => new TerraformReferenceProperty<TerraformProperty<string>>("", "agent_status");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "agent_version");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>("", "created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>("", "description");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>("", "updated_at");

}

/// <summary>
/// Retrieves information about a aws_bedrockagent_agent_versions.
/// </summary>
public class AwsBedrockagentAgentVersionsDataSource : TerraformDataSource
{
    public AwsBedrockagentAgentVersionsDataSource(string name) : base("aws_bedrockagent_agent_versions", name)
    {
    }

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentId is required")]
    [TerraformPropertyName("agent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for agent_version_summaries.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("agent_version_summaries")]
    public TerraformList<TerraformBlock<AwsBedrockagentAgentVersionsDataSourceAgentVersionSummariesBlock>>? AgentVersionSummaries { get; set; } = new();

}
