using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for add_header_action in AwsSesReceiptRule.
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleAddHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "add_header_action";

    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformValue<string> HeaderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_name");
        set => SetArgument("header_name", value);
    }

    /// <summary>
    /// The header_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformValue<string> HeaderValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("header_value");
        set => SetArgument("header_value", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformValue<double> Position
    {
        get => GetRequiredArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

}


/// <summary>
/// Block type for bounce_action in AwsSesReceiptRule.
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleBounceActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bounce_action";

    /// <summary>
    /// The message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Message is required")]
    public required TerraformValue<string> Message
    {
        get => GetRequiredArgument<TerraformValue<string>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformValue<double> Position
    {
        get => GetRequiredArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sender is required")]
    public required TerraformValue<string> Sender
    {
        get => GetRequiredArgument<TerraformValue<string>>("sender");
        set => SetArgument("sender", value);
    }

    /// <summary>
    /// The smtp_reply_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmtpReplyCode is required")]
    public required TerraformValue<string> SmtpReplyCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("smtp_reply_code");
        set => SetArgument("smtp_reply_code", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformValue<string>? StatusCode
    {
        get => GetArgument<TerraformValue<string>>("status_code");
        set => SetArgument("status_code", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Block type for lambda_action in AwsSesReceiptRule.
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleLambdaActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_action";

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_arn");
        set => SetArgument("function_arn", value);
    }

    /// <summary>
    /// The invocation_type attribute.
    /// </summary>
    public TerraformValue<string>? InvocationType
    {
        get => GetArgument<TerraformValue<string>>("invocation_type");
        set => SetArgument("invocation_type", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformValue<double> Position
    {
        get => GetRequiredArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Block type for s3_action in AwsSesReceiptRule.
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleS3ActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_action";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The object_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ObjectKeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("object_key_prefix");
        set => SetArgument("object_key_prefix", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformValue<double> Position
    {
        get => GetRequiredArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Block type for sns_action in AwsSesReceiptRule.
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleSnsActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns_action";

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformValue<double> Position
    {
        get => GetRequiredArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Block type for stop_action in AwsSesReceiptRule.
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleStopActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stop_action";

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformValue<double> Position
    {
        get => GetRequiredArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Block type for workmail_action in AwsSesReceiptRule.
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleWorkmailActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workmail_action";

    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationArn is required")]
    public required TerraformValue<string> OrganizationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("organization_arn");
        set => SetArgument("organization_arn", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformValue<double> Position
    {
        get => GetRequiredArgument<TerraformValue<double>>("position");
        set => SetArgument("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

}


/// <summary>
/// Represents a aws_ses_receipt_rule Terraform resource.
/// Manages a aws_ses_receipt_rule resource.
/// </summary>
public partial class AwsSesReceiptRule(string name) : TerraformResource("aws_ses_receipt_rule", name)
{
    /// <summary>
    /// The after attribute.
    /// </summary>
    public TerraformValue<string>? After
    {
        get => GetArgument<TerraformValue<string>>("after");
        set => SetArgument("after", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recipients attribute.
    /// </summary>
    public TerraformSet<string>? Recipients
    {
        get => GetArgument<TerraformSet<string>>("recipients");
        set => SetArgument("recipients", value);
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
    /// The rule_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetName is required")]
    public required TerraformValue<string> RuleSetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_set_name");
        set => SetArgument("rule_set_name", value);
    }

    /// <summary>
    /// The scan_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ScanEnabled
    {
        get => GetArgument<TerraformValue<bool>>("scan_enabled");
        set => SetArgument("scan_enabled", value);
    }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformValue<string> TlsPolicy
    {
        get => GetArgument<TerraformValue<string>>("tls_policy") ?? AsReference("tls_policy");
        set => SetArgument("tls_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// AddHeaderAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesReceiptRuleAddHeaderActionBlock>? AddHeaderAction
    {
        get => GetArgument<TerraformSet<AwsSesReceiptRuleAddHeaderActionBlock>>("add_header_action");
        set => SetArgument("add_header_action", value);
    }

    /// <summary>
    /// BounceAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesReceiptRuleBounceActionBlock>? BounceAction
    {
        get => GetArgument<TerraformSet<AwsSesReceiptRuleBounceActionBlock>>("bounce_action");
        set => SetArgument("bounce_action", value);
    }

    /// <summary>
    /// LambdaAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesReceiptRuleLambdaActionBlock>? LambdaAction
    {
        get => GetArgument<TerraformSet<AwsSesReceiptRuleLambdaActionBlock>>("lambda_action");
        set => SetArgument("lambda_action", value);
    }

    /// <summary>
    /// S3Action block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesReceiptRuleS3ActionBlock>? S3Action
    {
        get => GetArgument<TerraformSet<AwsSesReceiptRuleS3ActionBlock>>("s3_action");
        set => SetArgument("s3_action", value);
    }

    /// <summary>
    /// SnsAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesReceiptRuleSnsActionBlock>? SnsAction
    {
        get => GetArgument<TerraformSet<AwsSesReceiptRuleSnsActionBlock>>("sns_action");
        set => SetArgument("sns_action", value);
    }

    /// <summary>
    /// StopAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesReceiptRuleStopActionBlock>? StopAction
    {
        get => GetArgument<TerraformSet<AwsSesReceiptRuleStopActionBlock>>("stop_action");
        set => SetArgument("stop_action", value);
    }

    /// <summary>
    /// WorkmailAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesReceiptRuleWorkmailActionBlock>? WorkmailAction
    {
        get => GetArgument<TerraformSet<AwsSesReceiptRuleWorkmailActionBlock>>("workmail_action");
        set => SetArgument("workmail_action", value);
    }

}
