using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_platform_application resource.
/// </summary>
public class AwsSnsPlatformApplication : TerraformResource
{
    public AwsSnsPlatformApplication(string name) : base("aws_sns_platform_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The apple_platform_bundle_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplePlatformBundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apple_platform_bundle_id");
        set => this.WithProperty("apple_platform_bundle_id", value);
    }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplePlatformTeamId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apple_platform_team_id");
        set => this.WithProperty("apple_platform_team_id", value);
    }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventDeliveryFailureTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_delivery_failure_topic_arn");
        set => this.WithProperty("event_delivery_failure_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventEndpointCreatedTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_endpoint_created_topic_arn");
        set => this.WithProperty("event_endpoint_created_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventEndpointDeletedTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_endpoint_deleted_topic_arn");
        set => this.WithProperty("event_endpoint_deleted_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventEndpointUpdatedTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_endpoint_updated_topic_arn");
        set => this.WithProperty("event_endpoint_updated_topic_arn", value);
    }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("failure_feedback_role_arn");
        set => this.WithProperty("failure_feedback_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Platform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform");
        set => this.WithProperty("platform", value);
    }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlatformCredential
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_credential");
        set => this.WithProperty("platform_credential", value);
    }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlatformPrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_principal");
        set => this.WithProperty("platform_principal", value);
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
    /// The success_feedback_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("success_feedback_role_arn");
        set => this.WithProperty("success_feedback_role_arn", value);
    }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("success_feedback_sample_rate");
        set => this.WithProperty("success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
