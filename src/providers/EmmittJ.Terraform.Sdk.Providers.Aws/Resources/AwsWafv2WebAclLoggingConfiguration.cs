using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_filter in AwsWafv2WebAclLoggingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_filter";

    /// <summary>
    /// The default_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultBehavior is required")]
    public required TerraformValue<string> DefaultBehavior
    {
        get => GetRequiredArgument<TerraformValue<string>>("default_behavior");
        set => SetArgument("default_behavior", value);
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    public required TerraformSet<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformSet<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock.
/// Nesting mode: set
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Behavior is required")]
    public required TerraformValue<string> Behavior
    {
        get => GetRequiredArgument<TerraformValue<string>>("behavior");
        set => SetArgument("behavior", value);
    }

    /// <summary>
    /// The requirement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Requirement is required")]
    public required TerraformValue<string> Requirement
    {
        get => GetRequiredArgument<TerraformValue<string>>("requirement");
        set => SetArgument("requirement", value);
    }

    /// <summary>
    /// Condition block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Condition block(s) required")]
    public required TerraformSet<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlock> Condition
    {
        get => GetRequiredArgument<TerraformSet<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for condition in AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlock.
/// Nesting mode: set
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// ActionCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionCondition block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlockActionConditionBlock>? ActionCondition
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlockActionConditionBlock>>("action_condition");
        set => SetArgument("action_condition", value);
    }

    /// <summary>
    /// LabelNameCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LabelNameCondition block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlockLabelNameConditionBlock>? LabelNameCondition
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlockLabelNameConditionBlock>>("label_name_condition");
        set => SetArgument("label_name_condition", value);
    }

}

/// <summary>
/// Block type for action_condition in AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlockActionConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_condition";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

}

/// <summary>
/// Block type for label_name_condition in AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlockFilterBlockConditionBlockLabelNameConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "label_name_condition";

    /// <summary>
    /// The label_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabelName is required")]
    public required TerraformValue<string> LabelName
    {
        get => GetRequiredArgument<TerraformValue<string>>("label_name");
        set => SetArgument("label_name", value);
    }

}


/// <summary>
/// Block type for redacted_fields in AwsWafv2WebAclLoggingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redacted_fields";

    /// <summary>
    /// Method block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Method block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockMethodBlock>? Method
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockMethodBlock>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// QueryString block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryString block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockQueryStringBlock>? QueryString
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockQueryStringBlock>>("query_string");
        set => SetArgument("query_string", value);
    }

    /// <summary>
    /// SingleHeader block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleHeader block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockSingleHeaderBlock>? SingleHeader
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockSingleHeaderBlock>>("single_header");
        set => SetArgument("single_header", value);
    }

    /// <summary>
    /// UriPath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UriPath block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockUriPathBlock>? UriPath
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockUriPathBlock>>("uri_path");
        set => SetArgument("uri_path", value);
    }

}

/// <summary>
/// Block type for method in AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockMethodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "method";

}

/// <summary>
/// Block type for query_string in AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockQueryStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_string";

}

/// <summary>
/// Block type for single_header in AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockSingleHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_header";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for uri_path in AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock.
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlockUriPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "uri_path";

}


/// <summary>
/// Represents a aws_wafv2_web_acl_logging_configuration Terraform resource.
/// Manages a aws_wafv2_web_acl_logging_configuration resource.
/// </summary>
public partial class AwsWafv2WebAclLoggingConfiguration(string name) : TerraformResource("aws_wafv2_web_acl_logging_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// AWS Kinesis Firehose Delivery Stream ARNs
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestinationConfigs is required")]
    public required TerraformSet<string> LogDestinationConfigs
    {
        get => GetRequiredArgument<TerraformSet<string>>("log_destination_configs");
        set => SetArgument("log_destination_configs", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// AWS WebACL ARN
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// LoggingFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingFilter block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock>? LoggingFilter
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock>>("logging_filter");
        set => SetArgument("logging_filter", value);
    }

    /// <summary>
    /// RedactedFields block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 RedactedFields block(s) allowed")]
    public TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock>? RedactedFields
    {
        get => GetArgument<TerraformList<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock>>("redacted_fields");
        set => SetArgument("redacted_fields", value);
    }

}
