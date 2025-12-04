using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sns_topic_subscription Terraform resource.
/// Manages a aws_sns_topic_subscription resource.
/// </summary>
public partial class AwsSnsTopicSubscription(string name) : TerraformResource("aws_sns_topic_subscription", name)
{
    /// <summary>
    /// The confirmation_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? ConfirmationTimeoutInMinutes
    {
        get => GetArgument<TerraformValue<double>>("confirmation_timeout_in_minutes");
        set => SetArgument("confirmation_timeout_in_minutes", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryPolicy
    {
        get => GetArgument<TerraformValue<string>>("delivery_policy");
        set => SetArgument("delivery_policy", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    public TerraformValue<bool>? EndpointAutoConfirms
    {
        get => GetArgument<TerraformValue<bool>>("endpoint_auto_confirms");
        set => SetArgument("endpoint_auto_confirms", value);
    }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    public TerraformValue<string>? FilterPolicy
    {
        get => GetArgument<TerraformValue<string>>("filter_policy");
        set => SetArgument("filter_policy", value);
    }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    public TerraformValue<string>? FilterPolicyScope
    {
        get => GetArgument<TerraformValue<string>>("filter_policy_scope");
        set => SetArgument("filter_policy_scope", value);
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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    public TerraformValue<bool>? RawMessageDelivery
    {
        get => GetArgument<TerraformValue<bool>>("raw_message_delivery");
        set => SetArgument("raw_message_delivery", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformValue<string>? RedrivePolicy
    {
        get => GetArgument<TerraformValue<string>>("redrive_policy");
        set => SetArgument("redrive_policy", value);
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
    /// The replay_policy attribute.
    /// </summary>
    public TerraformValue<string>? ReplayPolicy
    {
        get => GetArgument<TerraformValue<string>>("replay_policy");
        set => SetArgument("replay_policy", value);
    }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SubscriptionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("subscription_role_arn");
        set => SetArgument("subscription_role_arn", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformValue<string> TopicArn
    {
        get => GetArgument<TerraformValue<string>>("topic_arn");
        set => SetArgument("topic_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The confirmation_was_authenticated attribute.
    /// </summary>
    public TerraformValue<bool> ConfirmationWasAuthenticated
        => AsReference("confirmation_was_authenticated");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The pending_confirmation attribute.
    /// </summary>
    public TerraformValue<bool> PendingConfirmation
        => AsReference("pending_confirmation");

}
