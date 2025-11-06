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
    public double? ConfirmationTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("confirmation_timeout_in_minutes")?.Value;
        set => this.WithProperty("confirmation_timeout_in_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The delivery_policy attribute.
    /// </summary>
    public string? DeliveryPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_policy")?.Value;
        set => this.WithProperty("delivery_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public string? Endpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint")?.Value;
        set => this.WithProperty("endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_auto_confirms attribute.
    /// </summary>
    public bool? EndpointAutoConfirms
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("endpoint_auto_confirms")?.Value;
        set => this.WithProperty("endpoint_auto_confirms", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The filter_policy attribute.
    /// </summary>
    public string? FilterPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_policy")?.Value;
        set => this.WithProperty("filter_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The filter_policy_scope attribute.
    /// </summary>
    public string? FilterPolicyScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_policy_scope")?.Value;
        set => this.WithProperty("filter_policy_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The raw_message_delivery attribute.
    /// </summary>
    public bool? RawMessageDelivery
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("raw_message_delivery")?.Value;
        set => this.WithProperty("raw_message_delivery", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The redrive_policy attribute.
    /// </summary>
    public string? RedrivePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redrive_policy")?.Value;
        set => this.WithProperty("redrive_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The replay_policy attribute.
    /// </summary>
    public string? ReplayPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("replay_policy")?.Value;
        set => this.WithProperty("replay_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_role_arn attribute.
    /// </summary>
    public string? SubscriptionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_role_arn")?.Value;
        set => this.WithProperty("subscription_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The topic_arn attribute.
    /// </summary>
    public string? TopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_arn")?.Value;
        set => this.WithProperty("topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
