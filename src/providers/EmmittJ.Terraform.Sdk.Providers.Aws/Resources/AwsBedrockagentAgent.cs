using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentAgentTimeoutsBlock : TerraformBlock
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
        this.WithOutput("agent_arn");
        this.WithOutput("agent_id");
        this.WithOutput("agent_version");
        this.WithOutput("id");
        this.WithOutput("prepared_at");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The agent_collaboration attribute.
    /// </summary>
    public TerraformProperty<string>? AgentCollaboration
    {
        get => GetProperty<TerraformProperty<string>>("agent_collaboration");
        set => this.WithProperty("agent_collaboration", value);
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentName is required")]
    public required TerraformProperty<string> AgentName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("agent_name");
        set => this.WithProperty("agent_name", value);
    }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentResourceRoleArn is required")]
    public required TerraformProperty<string> AgentResourceRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("agent_resource_role_arn");
        set => this.WithProperty("agent_resource_role_arn", value);
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerEncryptionKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("customer_encryption_key_arn");
        set => this.WithProperty("customer_encryption_key_arn", value);
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
    /// The foundation_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FoundationModel is required")]
    public required TerraformProperty<string> FoundationModel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("foundation_model");
        set => this.WithProperty("foundation_model", value);
    }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>>? GuardrailConfiguration
    {
        get => GetProperty<List<TerraformProperty<object>>>("guardrail_configuration");
        set => this.WithProperty("guardrail_configuration", value);
    }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IdleSessionTtlInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("idle_session_ttl_in_seconds");
        set => this.WithProperty("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    public TerraformProperty<string>? Instruction
    {
        get => GetProperty<TerraformProperty<string>>("instruction");
        set => this.WithProperty("instruction", value);
    }

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>>? MemoryConfiguration
    {
        get => GetProperty<List<TerraformProperty<object>>>("memory_configuration");
        set => this.WithProperty("memory_configuration", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? PrepareAgent
    {
        get => GetProperty<TerraformProperty<bool>>("prepare_agent");
        set => this.WithProperty("prepare_agent", value);
    }

    /// <summary>
    /// The prompt_override_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>>? PromptOverrideConfiguration
    {
        get => GetProperty<List<TerraformProperty<object>>>("prompt_override_configuration");
        set => this.WithProperty("prompt_override_configuration", value);
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
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipResourceInUseCheck
    {
        get => GetProperty<TerraformProperty<bool>>("skip_resource_in_use_check");
        set => this.WithProperty("skip_resource_in_use_check", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentAgentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockagentAgentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
