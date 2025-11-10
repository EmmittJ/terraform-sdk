using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for add_header_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleAddHeaderActionBlock : TerraformBlock
{
    /// <summary>
    /// The header_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderName is required")]
    public required TerraformProperty<string> HeaderName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("header_name");
        set => WithProperty("header_name", value);
    }

    /// <summary>
    /// The header_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformProperty<string> HeaderValue
    {
        get => GetRequiredProperty<TerraformProperty<string>>("header_value");
        set => WithProperty("header_value", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        get => GetRequiredProperty<TerraformProperty<double>>("position");
        set => WithProperty("position", value);
    }

}

/// <summary>
/// Block type for bounce_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleBounceActionBlock : TerraformBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Message is required")]
    public required TerraformProperty<string> Message
    {
        get => GetRequiredProperty<TerraformProperty<string>>("message");
        set => WithProperty("message", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        get => GetRequiredProperty<TerraformProperty<double>>("position");
        set => WithProperty("position", value);
    }

    /// <summary>
    /// The sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sender is required")]
    public required TerraformProperty<string> Sender
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sender");
        set => WithProperty("sender", value);
    }

    /// <summary>
    /// The smtp_reply_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmtpReplyCode is required")]
    public required TerraformProperty<string> SmtpReplyCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("smtp_reply_code");
        set => WithProperty("smtp_reply_code", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformProperty<string>? StatusCode
    {
        get => GetProperty<TerraformProperty<string>>("status_code");
        set => WithProperty("status_code", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Block type for lambda_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleLambdaActionBlock : TerraformBlock
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformProperty<string> FunctionArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_arn");
        set => WithProperty("function_arn", value);
    }

    /// <summary>
    /// The invocation_type attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationType
    {
        get => GetProperty<TerraformProperty<string>>("invocation_type");
        set => WithProperty("invocation_type", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        get => GetRequiredProperty<TerraformProperty<double>>("position");
        set => WithProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Block type for s3_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleS3ActionBlock : TerraformBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket_name");
        set => WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The object_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectKeyPrefix
    {
        get => GetProperty<TerraformProperty<string>>("object_key_prefix");
        set => WithProperty("object_key_prefix", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        get => GetRequiredProperty<TerraformProperty<double>>("position");
        set => WithProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Block type for sns_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleSnsActionBlock : TerraformBlock
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => WithProperty("encoding", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        get => GetRequiredProperty<TerraformProperty<double>>("position");
        set => WithProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Block type for stop_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleStopActionBlock : TerraformBlock
{
    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        get => GetRequiredProperty<TerraformProperty<double>>("position");
        set => WithProperty("position", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Block type for workmail_action in .
/// Nesting mode: set
/// </summary>
public class AwsSesReceiptRuleWorkmailActionBlock : TerraformBlock
{
    /// <summary>
    /// The organization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationArn is required")]
    public required TerraformProperty<string> OrganizationArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("organization_arn");
        set => WithProperty("organization_arn", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        get => GetRequiredProperty<TerraformProperty<double>>("position");
        set => WithProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
        set => WithProperty("topic_arn", value);
    }

}

/// <summary>
/// Manages a aws_ses_receipt_rule resource.
/// </summary>
public class AwsSesReceiptRule : TerraformResource
{
    public AwsSesReceiptRule(string name) : base("aws_ses_receipt_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The after attribute.
    /// </summary>
    public TerraformProperty<string>? After
    {
        get => GetProperty<TerraformProperty<string>>("after");
        set => this.WithProperty("after", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The recipients attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Recipients
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("recipients");
        set => this.WithProperty("recipients", value);
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
    /// The rule_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetName is required")]
    public required TerraformProperty<string> RuleSetName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule_set_name");
        set => this.WithProperty("rule_set_name", value);
    }

    /// <summary>
    /// The scan_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ScanEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("scan_enabled");
        set => this.WithProperty("scan_enabled", value);
    }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsPolicy
    {
        get => GetProperty<TerraformProperty<string>>("tls_policy");
        set => this.WithProperty("tls_policy", value);
    }

    /// <summary>
    /// Block for add_header_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleAddHeaderActionBlock>? AddHeaderAction
    {
        get => GetProperty<HashSet<AwsSesReceiptRuleAddHeaderActionBlock>>("add_header_action");
        set => this.WithProperty("add_header_action", value);
    }

    /// <summary>
    /// Block for bounce_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleBounceActionBlock>? BounceAction
    {
        get => GetProperty<HashSet<AwsSesReceiptRuleBounceActionBlock>>("bounce_action");
        set => this.WithProperty("bounce_action", value);
    }

    /// <summary>
    /// Block for lambda_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleLambdaActionBlock>? LambdaAction
    {
        get => GetProperty<HashSet<AwsSesReceiptRuleLambdaActionBlock>>("lambda_action");
        set => this.WithProperty("lambda_action", value);
    }

    /// <summary>
    /// Block for s3_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleS3ActionBlock>? S3Action
    {
        get => GetProperty<HashSet<AwsSesReceiptRuleS3ActionBlock>>("s3_action");
        set => this.WithProperty("s3_action", value);
    }

    /// <summary>
    /// Block for sns_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleSnsActionBlock>? SnsAction
    {
        get => GetProperty<HashSet<AwsSesReceiptRuleSnsActionBlock>>("sns_action");
        set => this.WithProperty("sns_action", value);
    }

    /// <summary>
    /// Block for stop_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleStopActionBlock>? StopAction
    {
        get => GetProperty<HashSet<AwsSesReceiptRuleStopActionBlock>>("stop_action");
        set => this.WithProperty("stop_action", value);
    }

    /// <summary>
    /// Block for workmail_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleWorkmailActionBlock>? WorkmailAction
    {
        get => GetProperty<HashSet<AwsSesReceiptRuleWorkmailActionBlock>>("workmail_action");
        set => this.WithProperty("workmail_action", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
