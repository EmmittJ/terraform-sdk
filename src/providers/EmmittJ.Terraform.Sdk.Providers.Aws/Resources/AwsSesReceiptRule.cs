using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for add_header_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleAddHeaderActionBlock
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    [TerraformPropertyName("header_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HeaderName { get; set; }

    /// <summary>
    /// The header_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    [TerraformPropertyName("header_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HeaderValue { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformPropertyName("position")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Position { get; set; }

}

/// <summary>
/// Block type for bounce_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleBounceActionBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Message is required")]
    [TerraformPropertyName("message")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Message { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformPropertyName("position")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sender is required")]
    [TerraformPropertyName("sender")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Sender { get; set; }

    /// <summary>
    /// The smtp_reply_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmtpReplyCode is required")]
    [TerraformPropertyName("smtp_reply_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SmtpReplyCode { get; set; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [TerraformPropertyName("status_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StatusCode { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for lambda_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleLambdaActionBlock
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    [TerraformPropertyName("function_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FunctionArn { get; set; }

    /// <summary>
    /// The invocation_type attribute.
    /// </summary>
    [TerraformPropertyName("invocation_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InvocationType { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformPropertyName("position")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for s3_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleS3ActionBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IamRoleArn { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The object_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("object_key_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectKeyPrefix { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformPropertyName("position")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for sns_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleSnsActionBlock
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [TerraformPropertyName("encoding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformPropertyName("position")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformPropertyName("topic_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TopicArn { get; set; }

}

/// <summary>
/// Block type for stop_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleStopActionBlock
{
    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformPropertyName("position")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for workmail_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleWorkmailActionBlock
{
    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationArn is required")]
    [TerraformPropertyName("organization_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrganizationArn { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformPropertyName("position")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_ses_receipt_rule resource.
/// </summary>
public class AwsSesReceiptRule : TerraformResource
{
    public AwsSesReceiptRule(string name) : base("aws_ses_receipt_rule", name)
    {
    }

    /// <summary>
    /// The after attribute.
    /// </summary>
    [TerraformPropertyName("after")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? After { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recipients attribute.
    /// </summary>
    [TerraformPropertyName("recipients")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Recipients { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The rule_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetName is required")]
    [TerraformPropertyName("rule_set_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuleSetName { get; set; }

    /// <summary>
    /// The scan_enabled attribute.
    /// </summary>
    [TerraformPropertyName("scan_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ScanEnabled { get; set; }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    [TerraformPropertyName("tls_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TlsPolicy { get; set; } = default!;

    /// <summary>
    /// Block for add_header_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("add_header_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleAddHeaderActionBlock>>? AddHeaderAction { get; set; }

    /// <summary>
    /// Block for bounce_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("bounce_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleBounceActionBlock>>? BounceAction { get; set; }

    /// <summary>
    /// Block for lambda_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("lambda_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleLambdaActionBlock>>? LambdaAction { get; set; }

    /// <summary>
    /// Block for s3_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("s3_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleS3ActionBlock>>? S3Action { get; set; }

    /// <summary>
    /// Block for sns_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sns_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleSnsActionBlock>>? SnsAction { get; set; }

    /// <summary>
    /// Block for stop_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("stop_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleStopActionBlock>>? StopAction { get; set; }

    /// <summary>
    /// Block for workmail_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("workmail_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleWorkmailActionBlock>>? WorkmailAction { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
