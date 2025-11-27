using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_action in AwsWafWebAcl.
/// Nesting mode: list
/// </summary>
public class AwsWafWebAclDefaultActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_action";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logging_configuration in AwsWafWebAcl.
/// Nesting mode: list
/// </summary>
public class AwsWafWebAclLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_configuration";

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestination is required")]
    public required TerraformValue<string> LogDestination
    {
        get => new TerraformReference<string>(this, "log_destination");
        set => SetArgument("log_destination", value);
    }

    /// <summary>
    /// RedactedFields block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedactedFields block(s) allowed")]
    public TerraformList<AwsWafWebAclLoggingConfigurationBlockRedactedFieldsBlock>? RedactedFields
    {
        get => GetArgument<TerraformList<AwsWafWebAclLoggingConfigurationBlockRedactedFieldsBlock>>("redacted_fields");
        set => SetArgument("redacted_fields", value);
    }

}

/// <summary>
/// Block type for redacted_fields in AwsWafWebAclLoggingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafWebAclLoggingConfigurationBlockRedactedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redacted_fields";

    /// <summary>
    /// FieldToMatch block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldToMatch is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldToMatch block(s) required")]
    public required TerraformSet<AwsWafWebAclLoggingConfigurationBlockRedactedFieldsBlockFieldToMatchBlock> FieldToMatch
    {
        get => GetRequiredArgument<TerraformSet<AwsWafWebAclLoggingConfigurationBlockRedactedFieldsBlockFieldToMatchBlock>>("field_to_match");
        set => SetArgument("field_to_match", value);
    }

}

/// <summary>
/// Block type for field_to_match in AwsWafWebAclLoggingConfigurationBlockRedactedFieldsBlock.
/// Nesting mode: set
/// </summary>
public class AwsWafWebAclLoggingConfigurationBlockRedactedFieldsBlockFieldToMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_to_match";

    /// <summary>
    /// The data attribute.
    /// </summary>
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for rules in AwsWafWebAcl.
/// Nesting mode: set
/// </summary>
public class AwsWafWebAclRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The rule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformValue<string> RuleId
    {
        get => new TerraformReference<string>(this, "rule_id");
        set => SetArgument("rule_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public TerraformList<AwsWafWebAclRulesBlockActionBlock>? Action
    {
        get => GetArgument<TerraformList<AwsWafWebAclRulesBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// OverrideAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideAction block(s) allowed")]
    public TerraformList<AwsWafWebAclRulesBlockOverrideActionBlock>? OverrideAction
    {
        get => GetArgument<TerraformList<AwsWafWebAclRulesBlockOverrideActionBlock>>("override_action");
        set => SetArgument("override_action", value);
    }

}

/// <summary>
/// Block type for action in AwsWafWebAclRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafWebAclRulesBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for override_action in AwsWafWebAclRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafWebAclRulesBlockOverrideActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "override_action";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_waf_web_acl Terraform resource.
/// Manages a aws_waf_web_acl resource.
/// </summary>
public partial class AwsWafWebAcl(string name) : TerraformResource("aws_waf_web_acl", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// DefaultAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DefaultAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultAction block(s) allowed")]
    public required TerraformList<AwsWafWebAclDefaultActionBlock> DefaultAction
    {
        get => GetRequiredArgument<TerraformList<AwsWafWebAclDefaultActionBlock>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// LoggingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public TerraformList<AwsWafWebAclLoggingConfigurationBlock>? LoggingConfiguration
    {
        get => GetArgument<TerraformList<AwsWafWebAclLoggingConfigurationBlock>>("logging_configuration");
        set => SetArgument("logging_configuration", value);
    }

    /// <summary>
    /// Rules block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsWafWebAclRulesBlock>? Rules
    {
        get => GetArgument<TerraformSet<AwsWafWebAclRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}
