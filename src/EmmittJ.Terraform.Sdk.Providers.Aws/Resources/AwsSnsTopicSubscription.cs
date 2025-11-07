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
    public TerraformProperty<double>? ConfirmationTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("confirmation_timeout_in_minutes");
        set => this.WithProperty("confirmation_timeout_in_minutes", value);
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DeliveryPolicy
    {
        get => GetProperty<TerraformProperty<string>>("delivery_policy");
        set => this.WithProperty("delivery_policy", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    public TerraformProperty<bool>? EndpointAutoConfirms
    {
        get => GetProperty<TerraformProperty<bool>>("endpoint_auto_confirms");
        set => this.WithProperty("endpoint_auto_confirms", value);
    }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPolicy
    {
        get => GetProperty<TerraformProperty<string>>("filter_policy");
        set => this.WithProperty("filter_policy", value);
    }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPolicyScope
    {
        get => GetProperty<TerraformProperty<string>>("filter_policy_scope");
        set => this.WithProperty("filter_policy_scope", value);
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
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    public TerraformProperty<bool>? RawMessageDelivery
    {
        get => GetProperty<TerraformProperty<bool>>("raw_message_delivery");
        set => this.WithProperty("raw_message_delivery", value);
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public TerraformProperty<string>? RedrivePolicy
    {
        get => GetProperty<TerraformProperty<string>>("redrive_policy");
        set => this.WithProperty("redrive_policy", value);
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
    /// The replay_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ReplayPolicy
    {
        get => GetProperty<TerraformProperty<string>>("replay_policy");
        set => this.WithProperty("replay_policy", value);
    }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriptionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("subscription_role_arn");
        set => this.WithProperty("subscription_role_arn", value);
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TopicArn
    {
        get => GetProperty<TerraformProperty<string>>("topic_arn");
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
