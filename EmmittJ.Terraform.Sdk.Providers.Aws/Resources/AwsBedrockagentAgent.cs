using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagent_agent resource.
/// </summary>
public class AwsBedrockagentAgent : TerraformResource
{
    public AwsBedrockagentAgent(string name) : base("aws_bedrockagent_agent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("agent_arn");
        this.DeclareOutput("agent_id");
        this.DeclareOutput("agent_version");
        this.DeclareOutput("id");
        this.DeclareOutput("prepared_at");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The agent_collaboration attribute.
    /// </summary>
    public string? AgentCollaboration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_collaboration")?.Value;
        set => this.WithProperty("agent_collaboration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    public string? AgentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_name")?.Value;
        set => this.WithProperty("agent_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    public string? AgentResourceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("agent_resource_role_arn")?.Value;
        set => this.WithProperty("agent_resource_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public string? CustomerEncryptionKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_encryption_key_arn")?.Value;
        set => this.WithProperty("customer_encryption_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The foundation_model attribute.
    /// </summary>
    public string? FoundationModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("foundation_model")?.Value;
        set => this.WithProperty("foundation_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    public List<object>? GuardrailConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("guardrail_configuration")?.Value;
        set => this.WithProperty("guardrail_configuration", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public double? IdleSessionTtlInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_session_ttl_in_seconds")?.Value;
        set => this.WithProperty("idle_session_ttl_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    public string? Instruction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instruction")?.Value;
        set => this.WithProperty("instruction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    public List<object>? MemoryConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("memory_configuration")?.Value;
        set => this.WithProperty("memory_configuration", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public bool? PrepareAgent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("prepare_agent")?.Value;
        set => this.WithProperty("prepare_agent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The prompt_override_configuration attribute.
    /// </summary>
    public List<object>? PromptOverrideConfiguration
    {
        get => GetProperty<TerraformLiteralProperty<List<object>>>("prompt_override_configuration")?.Value;
        set => this.WithProperty("prompt_override_configuration", value == null ? null : new TerraformLiteralProperty<List<object>>(value));
    }

    /// <summary>
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public bool? SkipResourceInUseCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_resource_in_use_check")?.Value;
        set => this.WithProperty("skip_resource_in_use_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The agent_arn attribute.
    /// </summary>
    public TerraformExpression AgentArn => this["agent_arn"];

    /// <summary>
    /// The agent_id attribute.
    /// </summary>
    public TerraformExpression AgentId => this["agent_id"];

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    public TerraformExpression AgentVersion => this["agent_version"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The prepared_at attribute.
    /// </summary>
    public TerraformExpression PreparedAt => this["prepared_at"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
