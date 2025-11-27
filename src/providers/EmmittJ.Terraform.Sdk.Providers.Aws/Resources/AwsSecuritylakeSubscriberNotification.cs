using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsSecuritylakeSubscriberNotification.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberNotificationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// HttpsNotificationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeSubscriberNotificationConfigurationBlockHttpsNotificationConfigurationBlock>? HttpsNotificationConfiguration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeSubscriberNotificationConfigurationBlockHttpsNotificationConfigurationBlock>>("https_notification_configuration");
        set => SetArgument("https_notification_configuration", value);
    }

    /// <summary>
    /// SqsNotificationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeSubscriberNotificationConfigurationBlockSqsNotificationConfigurationBlock>? SqsNotificationConfiguration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeSubscriberNotificationConfigurationBlockSqsNotificationConfigurationBlock>>("sqs_notification_configuration");
        set => SetArgument("sqs_notification_configuration", value);
    }

}

/// <summary>
/// Block type for https_notification_configuration in AwsSecuritylakeSubscriberNotificationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberNotificationConfigurationBlockHttpsNotificationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "https_notification_configuration";

    /// <summary>
    /// The authorization_api_key_name attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationApiKeyName
    {
        get => new TerraformReference<string>(this, "authorization_api_key_name");
        set => SetArgument("authorization_api_key_name", value);
    }

    /// <summary>
    /// The authorization_api_key_value attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationApiKeyValue
    {
        get => new TerraformReference<string>(this, "authorization_api_key_value");
        set => SetArgument("authorization_api_key_value", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The http_method attribute.
    /// </summary>
    public TerraformValue<string>? HttpMethod
    {
        get => new TerraformReference<string>(this, "http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// The target_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRoleArn is required")]
    public required TerraformValue<string> TargetRoleArn
    {
        get => new TerraformReference<string>(this, "target_role_arn");
        set => SetArgument("target_role_arn", value);
    }

}

/// <summary>
/// Block type for sqs_notification_configuration in AwsSecuritylakeSubscriberNotificationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberNotificationConfigurationBlockSqsNotificationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs_notification_configuration";

}


/// <summary>
/// Represents a aws_securitylake_subscriber_notification Terraform resource.
/// Manages a aws_securitylake_subscriber_notification resource.
/// </summary>
public partial class AwsSecuritylakeSubscriberNotification(string name) : TerraformResource("aws_securitylake_subscriber_notification", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subscriber_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriberId is required")]
    public required TerraformValue<string> SubscriberId
    {
        get => new TerraformReference<string>(this, "subscriber_id");
        set => SetArgument("subscriber_id", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> EndpointId
    {
        get => new TerraformReference<string>(this, "endpoint_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SubscriberEndpoint
    {
        get => new TerraformReference<string>(this, "subscriber_endpoint");
    }

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeSubscriberNotificationConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeSubscriberNotificationConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}
