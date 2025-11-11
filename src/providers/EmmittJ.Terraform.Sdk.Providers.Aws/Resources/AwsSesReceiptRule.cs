using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for add_header_action in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesReceiptRuleAddHeaderActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    [TerraformProperty("header_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HeaderName { get; set; }

    /// <summary>
    /// The header_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    [TerraformProperty("header_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HeaderValue { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformProperty("position")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Position { get; set; }

}

/// <summary>
/// Block type for bounce_action in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesReceiptRuleBounceActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Message is required")]
    [TerraformProperty("message")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Message { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformProperty("position")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sender is required")]
    [TerraformProperty("sender")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sender { get; set; }

    /// <summary>
    /// The smtp_reply_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmtpReplyCode is required")]
    [TerraformProperty("smtp_reply_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SmtpReplyCode { get; set; }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [TerraformProperty("status_code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StatusCode { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformProperty("topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for lambda_action in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesReceiptRuleLambdaActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    [TerraformProperty("function_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionArn { get; set; }

    /// <summary>
    /// The invocation_type attribute.
    /// </summary>
    [TerraformProperty("invocation_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InvocationType { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformProperty("position")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformProperty("topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for s3_action in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesReceiptRuleS3ActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("iam_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IamRoleArn { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The object_key_prefix attribute.
    /// </summary>
    [TerraformProperty("object_key_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ObjectKeyPrefix { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformProperty("position")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformProperty("topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for sns_action in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesReceiptRuleSnsActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    [TerraformProperty("encoding")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Encoding { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformProperty("position")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    [TerraformProperty("topic_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TopicArn { get; set; }

}

/// <summary>
/// Block type for stop_action in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesReceiptRuleStopActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformProperty("position")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformProperty("topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Block type for workmail_action in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesReceiptRuleWorkmailActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationArn is required")]
    [TerraformProperty("organization_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrganizationArn { get; set; }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    [TerraformProperty("position")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Position { get; set; }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [TerraformProperty("topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TopicArn { get; set; }

}

/// <summary>
/// Manages a aws_ses_receipt_rule resource.
/// </summary>
public partial class AwsSesReceiptRule : TerraformResource
{
    public AwsSesReceiptRule(string name) : base("aws_ses_receipt_rule", name)
    {
    }

    /// <summary>
    /// The after attribute.
    /// </summary>
    [TerraformProperty("after")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? After { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The recipients attribute.
    /// </summary>
    [TerraformProperty("recipients")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Recipients { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rule_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetName is required")]
    [TerraformProperty("rule_set_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuleSetName { get; set; }

    /// <summary>
    /// The scan_enabled attribute.
    /// </summary>
    [TerraformProperty("scan_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ScanEnabled { get; set; }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    [TerraformProperty("tls_policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TlsPolicy { get; set; }

    /// <summary>
    /// Block for add_header_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("add_header_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleAddHeaderActionBlock>>? AddHeaderAction { get; set; }

    /// <summary>
    /// Block for bounce_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("bounce_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleBounceActionBlock>>? BounceAction { get; set; }

    /// <summary>
    /// Block for lambda_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("lambda_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleLambdaActionBlock>>? LambdaAction { get; set; }

    /// <summary>
    /// Block for s3_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("s3_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleS3ActionBlock>>? S3Action { get; set; }

    /// <summary>
    /// Block for sns_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sns_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleSnsActionBlock>>? SnsAction { get; set; }

    /// <summary>
    /// Block for stop_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("stop_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleStopActionBlock>>? StopAction { get; set; }

    /// <summary>
    /// Block for workmail_action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("workmail_action")]
    public TerraformSet<TerraformBlock<AwsSesReceiptRuleWorkmailActionBlock>>? WorkmailAction { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
