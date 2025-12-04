using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for evaluation_mode in AwsConfigConfigRule.
/// Nesting mode: set
/// </summary>
public class AwsConfigConfigRuleEvaluationModeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "evaluation_mode";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for scope in AwsConfigConfigRule.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// The compliance_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? ComplianceResourceId
    {
        get => GetArgument<TerraformValue<string>>("compliance_resource_id");
        set => SetArgument("compliance_resource_id", value);
    }

    /// <summary>
    /// The compliance_resource_types attribute.
    /// </summary>
    public TerraformSet<string>? ComplianceResourceTypes
    {
        get => GetArgument<TerraformSet<string>>("compliance_resource_types");
        set => SetArgument("compliance_resource_types", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public TerraformValue<string>? TagKey
    {
        get => GetArgument<TerraformValue<string>>("tag_key");
        set => SetArgument("tag_key", value);
    }

    /// <summary>
    /// The tag_value attribute.
    /// </summary>
    public TerraformValue<string>? TagValue
    {
        get => GetArgument<TerraformValue<string>>("tag_value");
        set => SetArgument("tag_value", value);
    }

}


/// <summary>
/// Block type for source in AwsConfigConfigRule.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => GetArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// The source_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SourceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("source_identifier");
        set => SetArgument("source_identifier", value);
    }

    /// <summary>
    /// CustomPolicyDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPolicyDetails block(s) allowed")]
    public TerraformList<AwsConfigConfigRuleSourceBlockCustomPolicyDetailsBlock>? CustomPolicyDetails
    {
        get => GetArgument<TerraformList<AwsConfigConfigRuleSourceBlockCustomPolicyDetailsBlock>>("custom_policy_details");
        set => SetArgument("custom_policy_details", value);
    }

    /// <summary>
    /// SourceDetail block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 SourceDetail block(s) allowed")]
    public TerraformSet<AwsConfigConfigRuleSourceBlockSourceDetailBlock>? SourceDetail
    {
        get => GetArgument<TerraformSet<AwsConfigConfigRuleSourceBlockSourceDetailBlock>>("source_detail");
        set => SetArgument("source_detail", value);
    }

}

/// <summary>
/// Block type for custom_policy_details in AwsConfigConfigRuleSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigRuleSourceBlockCustomPolicyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_policy_details";

    /// <summary>
    /// The enable_debug_log_delivery attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDebugLogDelivery
    {
        get => GetArgument<TerraformValue<bool>>("enable_debug_log_delivery");
        set => SetArgument("enable_debug_log_delivery", value);
    }

    /// <summary>
    /// The policy_runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyRuntime is required")]
    public required TerraformValue<string> PolicyRuntime
    {
        get => GetArgument<TerraformValue<string>>("policy_runtime");
        set => SetArgument("policy_runtime", value);
    }

    /// <summary>
    /// The policy_text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyText is required")]
    public required TerraformValue<string> PolicyText
    {
        get => GetArgument<TerraformValue<string>>("policy_text");
        set => SetArgument("policy_text", value);
    }

}

/// <summary>
/// Block type for source_detail in AwsConfigConfigRuleSourceBlock.
/// Nesting mode: set
/// </summary>
public class AwsConfigConfigRuleSourceBlockSourceDetailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_detail";

    /// <summary>
    /// The event_source attribute.
    /// </summary>
    public TerraformValue<string>? EventSource
    {
        get => GetArgument<TerraformValue<string>>("event_source");
        set => SetArgument("event_source", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformValue<string>? MaximumExecutionFrequency
    {
        get => GetArgument<TerraformValue<string>>("maximum_execution_frequency");
        set => SetArgument("maximum_execution_frequency", value);
    }

    /// <summary>
    /// The message_type attribute.
    /// </summary>
    public TerraformValue<string>? MessageType
    {
        get => GetArgument<TerraformValue<string>>("message_type");
        set => SetArgument("message_type", value);
    }

}


/// <summary>
/// Represents a aws_config_config_rule Terraform resource.
/// Manages a aws_config_config_rule resource.
/// </summary>
public partial class AwsConfigConfigRule(string name) : TerraformResource("aws_config_config_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The input_parameters attribute.
    /// </summary>
    public TerraformValue<string>? InputParameters
    {
        get => GetArgument<TerraformValue<string>>("input_parameters");
        set => SetArgument("input_parameters", value);
    }

    /// <summary>
    /// The maximum_execution_frequency attribute.
    /// </summary>
    public TerraformValue<string>? MaximumExecutionFrequency
    {
        get => GetArgument<TerraformValue<string>>("maximum_execution_frequency");
        set => SetArgument("maximum_execution_frequency", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    public TerraformValue<string> RuleId
        => AsReference("rule_id");

    /// <summary>
    /// EvaluationMode block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsConfigConfigRuleEvaluationModeBlock>? EvaluationMode
    {
        get => GetArgument<TerraformSet<AwsConfigConfigRuleEvaluationModeBlock>>("evaluation_mode");
        set => SetArgument("evaluation_mode", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public TerraformList<AwsConfigConfigRuleScopeBlock>? Scope
    {
        get => GetArgument<TerraformList<AwsConfigConfigRuleScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AwsConfigConfigRuleSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AwsConfigConfigRuleSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}
