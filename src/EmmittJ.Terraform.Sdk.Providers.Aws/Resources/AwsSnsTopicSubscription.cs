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
        this.DeclareOutput("arn");
        this.DeclareOutput("confirmation_was_authenticated");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("pending_confirmation");
    }

    /// <summary>
    /// The confirmation_timeout_in_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ConfirmationTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("confirmation_timeout_in_minutes");
        set => this.WithProperty("confirmation_timeout_in_minutes", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliveryPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_policy");
        set => this.WithProperty("delivery_policy", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Endpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EndpointAutoConfirms
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("endpoint_auto_confirms");
        set => this.WithProperty("endpoint_auto_confirms", value);
    }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FilterPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_policy");
        set => this.WithProperty("filter_policy", value);
    }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FilterPolicyScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_policy_scope");
        set => this.WithProperty("filter_policy_scope", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RawMessageDelivery
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("raw_message_delivery");
        set => this.WithProperty("raw_message_delivery", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RedrivePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redrive_policy");
        set => this.WithProperty("redrive_policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replay_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReplayPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replay_policy");
        set => this.WithProperty("replay_policy", value);
    }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_role_arn");
        set => this.WithProperty("subscription_role_arn", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_arn");
        set => this.WithProperty("topic_arn", value);
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
