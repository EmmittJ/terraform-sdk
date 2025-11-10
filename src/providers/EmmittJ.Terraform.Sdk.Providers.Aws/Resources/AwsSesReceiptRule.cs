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
        set => SetProperty("header_name", value);
    }

    /// <summary>
    /// The header_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeaderValue is required")]
    public required TerraformProperty<string> HeaderValue
    {
        set => SetProperty("header_value", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        set => SetProperty("position", value);
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
        set => SetProperty("message", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        set => SetProperty("position", value);
    }

    /// <summary>
    /// The sender attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sender is required")]
    public required TerraformProperty<string> Sender
    {
        set => SetProperty("sender", value);
    }

    /// <summary>
    /// The smtp_reply_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SmtpReplyCode is required")]
    public required TerraformProperty<string> SmtpReplyCode
    {
        set => SetProperty("smtp_reply_code", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    public TerraformProperty<string>? StatusCode
    {
        set => SetProperty("status_code", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        set => SetProperty("topic_arn", value);
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
        set => SetProperty("function_arn", value);
    }

    /// <summary>
    /// The invocation_type attribute.
    /// </summary>
    public TerraformProperty<string>? InvocationType
    {
        set => SetProperty("invocation_type", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        set => SetProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        set => SetProperty("topic_arn", value);
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
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        set => SetProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The object_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectKeyPrefix
    {
        set => SetProperty("object_key_prefix", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        set => SetProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        set => SetProperty("topic_arn", value);
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
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        set => SetProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        set => SetProperty("topic_arn", value);
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
        set => SetProperty("position", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        set => SetProperty("topic_arn", value);
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
        set => SetProperty("organization_arn", value);
    }

    /// <summary>
    /// The position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Position is required")]
    public required TerraformProperty<double> Position
    {
        set => SetProperty("position", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        set => SetProperty("topic_arn", value);
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
        SetOutput("arn");
        SetOutput("after");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("recipients");
        SetOutput("region");
        SetOutput("rule_set_name");
        SetOutput("scan_enabled");
        SetOutput("tls_policy");
    }

    /// <summary>
    /// The after attribute.
    /// </summary>
    public TerraformProperty<string> After
    {
        get => GetRequiredOutput<TerraformProperty<string>>("after");
        set => SetProperty("after", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The recipients attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Recipients
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("recipients");
        set => SetProperty("recipients", value);
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
    /// The rule_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleSetName is required")]
    public required TerraformProperty<string> RuleSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_set_name");
        set => SetProperty("rule_set_name", value);
    }

    /// <summary>
    /// The scan_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ScanEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("scan_enabled");
        set => SetProperty("scan_enabled", value);
    }

    /// <summary>
    /// The tls_policy attribute.
    /// </summary>
    public TerraformProperty<string> TlsPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tls_policy");
        set => SetProperty("tls_policy", value);
    }

    /// <summary>
    /// Block for add_header_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleAddHeaderActionBlock>? AddHeaderAction
    {
        set => SetProperty("add_header_action", value);
    }

    /// <summary>
    /// Block for bounce_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleBounceActionBlock>? BounceAction
    {
        set => SetProperty("bounce_action", value);
    }

    /// <summary>
    /// Block for lambda_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleLambdaActionBlock>? LambdaAction
    {
        set => SetProperty("lambda_action", value);
    }

    /// <summary>
    /// Block for s3_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleS3ActionBlock>? S3Action
    {
        set => SetProperty("s3_action", value);
    }

    /// <summary>
    /// Block for sns_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleSnsActionBlock>? SnsAction
    {
        set => SetProperty("sns_action", value);
    }

    /// <summary>
    /// Block for stop_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleStopActionBlock>? StopAction
    {
        set => SetProperty("stop_action", value);
    }

    /// <summary>
    /// Block for workmail_action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesReceiptRuleWorkmailActionBlock>? WorkmailAction
    {
        set => SetProperty("workmail_action", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
