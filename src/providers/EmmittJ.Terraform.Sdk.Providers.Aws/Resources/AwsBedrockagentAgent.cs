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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("agent_arn");
        SetOutput("agent_id");
        SetOutput("agent_version");
        SetOutput("id");
        SetOutput("prepared_at");
        SetOutput("tags_all");
        SetOutput("agent_collaboration");
        SetOutput("agent_name");
        SetOutput("agent_resource_role_arn");
        SetOutput("customer_encryption_key_arn");
        SetOutput("description");
        SetOutput("foundation_model");
        SetOutput("guardrail_configuration");
        SetOutput("idle_session_ttl_in_seconds");
        SetOutput("instruction");
        SetOutput("memory_configuration");
        SetOutput("prepare_agent");
        SetOutput("prompt_override_configuration");
        SetOutput("region");
        SetOutput("skip_resource_in_use_check");
        SetOutput("tags");
    }

    /// <summary>
    /// The agent_collaboration attribute.
    /// </summary>
    public TerraformProperty<string> AgentCollaboration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_collaboration");
        set => SetProperty("agent_collaboration", value);
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentName is required")]
    public required TerraformProperty<string> AgentName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_name");
        set => SetProperty("agent_name", value);
    }

    /// <summary>
    /// The agent_resource_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentResourceRoleArn is required")]
    public required TerraformProperty<string> AgentResourceRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("agent_resource_role_arn");
        set => SetProperty("agent_resource_role_arn", value);
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> CustomerEncryptionKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_encryption_key_arn");
        set => SetProperty("customer_encryption_key_arn", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The foundation_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FoundationModel is required")]
    public required TerraformProperty<string> FoundationModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("foundation_model");
        set => SetProperty("foundation_model", value);
    }

    /// <summary>
    /// The guardrail_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>> GuardrailConfiguration
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("guardrail_configuration");
        set => SetProperty("guardrail_configuration", value);
    }

    /// <summary>
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> IdleSessionTtlInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_session_ttl_in_seconds");
        set => SetProperty("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The instruction attribute.
    /// </summary>
    public TerraformProperty<string> Instruction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instruction");
        set => SetProperty("instruction", value);
    }

    /// <summary>
    /// The memory_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>> MemoryConfiguration
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("memory_configuration");
        set => SetProperty("memory_configuration", value);
    }

    /// <summary>
    /// The prepare_agent attribute.
    /// </summary>
    public TerraformProperty<bool> PrepareAgent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("prepare_agent");
        set => SetProperty("prepare_agent", value);
    }

    /// <summary>
    /// The prompt_override_configuration attribute.
    /// </summary>
    public List<TerraformProperty<object>> PromptOverrideConfiguration
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("prompt_override_configuration");
        set => SetProperty("prompt_override_configuration", value);
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
    /// The skip_resource_in_use_check attribute.
    /// </summary>
    public TerraformProperty<bool> SkipResourceInUseCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_resource_in_use_check");
        set => SetProperty("skip_resource_in_use_check", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockagentAgentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
