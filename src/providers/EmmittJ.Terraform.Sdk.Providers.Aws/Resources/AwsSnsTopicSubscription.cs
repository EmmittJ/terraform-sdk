using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_topic_subscription resource.
/// </summary>
public class AwsSnsTopicSubscription : TerraformResource
{
    public AwsSnsTopicSubscription(string name) : base("aws_sns_topic_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("confirmation_was_authenticated");
        SetOutput("owner_id");
        SetOutput("pending_confirmation");
        SetOutput("confirmation_timeout_in_minutes");
        SetOutput("delivery_policy");
        SetOutput("endpoint");
        SetOutput("endpoint_auto_confirms");
        SetOutput("filter_policy");
        SetOutput("filter_policy_scope");
        SetOutput("id");
        SetOutput("protocol");
        SetOutput("raw_message_delivery");
        SetOutput("redrive_policy");
        SetOutput("region");
        SetOutput("replay_policy");
        SetOutput("subscription_role_arn");
        SetOutput("topic_arn");
    }

    /// <summary>
    /// The confirmation_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> ConfirmationTimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("confirmation_timeout_in_minutes");
        set => SetProperty("confirmation_timeout_in_minutes", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformProperty<string> DeliveryPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_policy");
        set => SetProperty("delivery_policy", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformProperty<string> Endpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint");
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    public TerraformProperty<bool> EndpointAutoConfirms
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("endpoint_auto_confirms");
        set => SetProperty("endpoint_auto_confirms", value);
    }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    public TerraformProperty<string> FilterPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter_policy");
        set => SetProperty("filter_policy", value);
    }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    public TerraformProperty<string> FilterPolicyScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter_policy_scope");
        set => SetProperty("filter_policy_scope", value);
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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    public TerraformProperty<bool> RawMessageDelivery
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("raw_message_delivery");
        set => SetProperty("raw_message_delivery", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformProperty<string> RedrivePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redrive_policy");
        set => SetProperty("redrive_policy", value);
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
    /// The replay_policy attribute.
    /// </summary>
    public TerraformProperty<string> ReplayPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("replay_policy");
        set => SetProperty("replay_policy", value);
    }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> SubscriptionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_role_arn");
        set => SetProperty("subscription_role_arn", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicArn is required")]
    public required TerraformProperty<string> TopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("topic_arn");
        set => SetProperty("topic_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The confirmation_was_authenticated attribute.
    /// </summary>
    public TerraformExpression ConfirmationWasAuthenticated => this["confirmation_was_authenticated"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The pending_confirmation attribute.
    /// </summary>
    public TerraformExpression PendingConfirmation => this["pending_confirmation"];

}
