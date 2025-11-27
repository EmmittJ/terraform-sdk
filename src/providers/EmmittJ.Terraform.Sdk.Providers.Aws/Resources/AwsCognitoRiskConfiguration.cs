using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_takeover_risk_configuration in AwsCognitoRiskConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "account_takeover_risk_configuration";

    /// <summary>
    /// Actions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    public required TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlock> Actions
    {
        get => GetRequiredArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// NotifyConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotifyConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlock>? NotifyConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlock>>("notify_configuration");
        set => SetArgument("notify_configuration", value);
    }

}

/// <summary>
/// Block type for actions in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// HighAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighAction block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockHighActionBlock>? HighAction
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockHighActionBlock>>("high_action");
        set => SetArgument("high_action", value);
    }

    /// <summary>
    /// LowAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LowAction block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockLowActionBlock>? LowAction
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockLowActionBlock>>("low_action");
        set => SetArgument("low_action", value);
    }

    /// <summary>
    /// MediumAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediumAction block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockMediumActionBlock>? MediumAction
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockMediumActionBlock>>("medium_action");
        set => SetArgument("medium_action", value);
    }

}

/// <summary>
/// Block type for high_action in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockHighActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "high_action";

    /// <summary>
    /// The event_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventAction is required")]
    public required TerraformValue<string> EventAction
    {
        get => new TerraformReference<string>(this, "event_action");
        set => SetArgument("event_action", value);
    }

    /// <summary>
    /// The notify attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notify is required")]
    public required TerraformValue<bool> Notify
    {
        get => new TerraformReference<bool>(this, "notify");
        set => SetArgument("notify", value);
    }

}

/// <summary>
/// Block type for low_action in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockLowActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "low_action";

    /// <summary>
    /// The event_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventAction is required")]
    public required TerraformValue<string> EventAction
    {
        get => new TerraformReference<string>(this, "event_action");
        set => SetArgument("event_action", value);
    }

    /// <summary>
    /// The notify attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notify is required")]
    public required TerraformValue<bool> Notify
    {
        get => new TerraformReference<bool>(this, "notify");
        set => SetArgument("notify", value);
    }

}

/// <summary>
/// Block type for medium_action in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockActionsBlockMediumActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "medium_action";

    /// <summary>
    /// The event_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventAction is required")]
    public required TerraformValue<string> EventAction
    {
        get => new TerraformReference<string>(this, "event_action");
        set => SetArgument("event_action", value);
    }

    /// <summary>
    /// The notify attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notify is required")]
    public required TerraformValue<bool> Notify
    {
        get => new TerraformReference<bool>(this, "notify");
        set => SetArgument("notify", value);
    }

}

/// <summary>
/// Block type for notify_configuration in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notify_configuration";

    /// <summary>
    /// The from attribute.
    /// </summary>
    public TerraformValue<string>? From
    {
        get => new TerraformReference<string>(this, "from");
        set => SetArgument("from", value);
    }

    /// <summary>
    /// The reply_to attribute.
    /// </summary>
    public TerraformValue<string>? ReplyTo
    {
        get => new TerraformReference<string>(this, "reply_to");
        set => SetArgument("reply_to", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceArn is required")]
    public required TerraformValue<string> SourceArn
    {
        get => new TerraformReference<string>(this, "source_arn");
        set => SetArgument("source_arn", value);
    }

    /// <summary>
    /// BlockEmail block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlockEmail block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockBlockEmailBlock>? BlockEmail
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockBlockEmailBlock>>("block_email");
        set => SetArgument("block_email", value);
    }

    /// <summary>
    /// MfaEmail block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MfaEmail block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockMfaEmailBlock>? MfaEmail
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockMfaEmailBlock>>("mfa_email");
        set => SetArgument("mfa_email", value);
    }

    /// <summary>
    /// NoActionEmail block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NoActionEmail block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockNoActionEmailBlock>? NoActionEmail
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockNoActionEmailBlock>>("no_action_email");
        set => SetArgument("no_action_email", value);
    }

}

/// <summary>
/// Block type for block_email in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockBlockEmailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "block_email";

    /// <summary>
    /// The html_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HtmlBody is required")]
    public required TerraformValue<string> HtmlBody
    {
        get => new TerraformReference<string>(this, "html_body");
        set => SetArgument("html_body", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    public required TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The text_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextBody is required")]
    public required TerraformValue<string> TextBody
    {
        get => new TerraformReference<string>(this, "text_body");
        set => SetArgument("text_body", value);
    }

}

/// <summary>
/// Block type for mfa_email in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockMfaEmailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mfa_email";

    /// <summary>
    /// The html_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HtmlBody is required")]
    public required TerraformValue<string> HtmlBody
    {
        get => new TerraformReference<string>(this, "html_body");
        set => SetArgument("html_body", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    public required TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The text_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextBody is required")]
    public required TerraformValue<string> TextBody
    {
        get => new TerraformReference<string>(this, "text_body");
        set => SetArgument("text_body", value);
    }

}

/// <summary>
/// Block type for no_action_email in AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlockNotifyConfigurationBlockNoActionEmailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "no_action_email";

    /// <summary>
    /// The html_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HtmlBody is required")]
    public required TerraformValue<string> HtmlBody
    {
        get => new TerraformReference<string>(this, "html_body");
        set => SetArgument("html_body", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    public required TerraformValue<string> Subject
    {
        get => new TerraformReference<string>(this, "subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The text_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextBody is required")]
    public required TerraformValue<string> TextBody
    {
        get => new TerraformReference<string>(this, "text_body");
        set => SetArgument("text_body", value);
    }

}


/// <summary>
/// Block type for compromised_credentials_risk_configuration in AwsCognitoRiskConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compromised_credentials_risk_configuration";

    /// <summary>
    /// The event_filter attribute.
    /// </summary>
    public TerraformSet<string> EventFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "event_filter").ResolveNodes(ctx));
        set => SetArgument("event_filter", value);
    }

    /// <summary>
    /// Actions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    public required TerraformList<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlockActionsBlock> Actions
    {
        get => GetRequiredArgument<TerraformList<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlockActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for actions in AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlockActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// The event_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventAction is required")]
    public required TerraformValue<string> EventAction
    {
        get => new TerraformReference<string>(this, "event_action");
        set => SetArgument("event_action", value);
    }

}


/// <summary>
/// Block type for risk_exception_configuration in AwsCognitoRiskConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "risk_exception_configuration";

    /// <summary>
    /// The blocked_ip_range_list attribute.
    /// </summary>
    public TerraformSet<string>? BlockedIpRangeList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "blocked_ip_range_list").ResolveNodes(ctx));
        set => SetArgument("blocked_ip_range_list", value);
    }

    /// <summary>
    /// The skipped_ip_range_list attribute.
    /// </summary>
    public TerraformSet<string>? SkippedIpRangeList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "skipped_ip_range_list").ResolveNodes(ctx));
        set => SetArgument("skipped_ip_range_list", value);
    }

}


/// <summary>
/// Represents a aws_cognito_risk_configuration Terraform resource.
/// Manages a aws_cognito_risk_configuration resource.
/// </summary>
public partial class AwsCognitoRiskConfiguration(string name) : TerraformResource("aws_cognito_risk_configuration", name)
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// AccountTakeoverRiskConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountTakeoverRiskConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock>? AccountTakeoverRiskConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock>>("account_takeover_risk_configuration");
        set => SetArgument("account_takeover_risk_configuration", value);
    }

    /// <summary>
    /// CompromisedCredentialsRiskConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CompromisedCredentialsRiskConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock>? CompromisedCredentialsRiskConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock>>("compromised_credentials_risk_configuration");
        set => SetArgument("compromised_credentials_risk_configuration", value);
    }

    /// <summary>
    /// RiskExceptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RiskExceptionConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock>? RiskExceptionConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock>>("risk_exception_configuration");
        set => SetArgument("risk_exception_configuration", value);
    }

}
