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
    public string? ApplePlatformBundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apple_platform_bundle_id")?.Value;
        set => this.WithProperty("apple_platform_bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    public string? ApplePlatformTeamId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("apple_platform_team_id")?.Value;
        set => this.WithProperty("apple_platform_team_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    public string? EventDeliveryFailureTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_delivery_failure_topic_arn")?.Value;
        set => this.WithProperty("event_delivery_failure_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    public string? EventEndpointCreatedTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_endpoint_created_topic_arn")?.Value;
        set => this.WithProperty("event_endpoint_created_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    public string? EventEndpointDeletedTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_endpoint_deleted_topic_arn")?.Value;
        set => this.WithProperty("event_endpoint_deleted_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    public string? EventEndpointUpdatedTopicArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_endpoint_updated_topic_arn")?.Value;
        set => this.WithProperty("event_endpoint_updated_topic_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    public string? FailureFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("failure_feedback_role_arn")?.Value;
        set => this.WithProperty("failure_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public string? Platform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform")?.Value;
        set => this.WithProperty("platform", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    public string? PlatformCredential
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_credential")?.Value;
        set => this.WithProperty("platform_credential", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    public string? PlatformPrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_principal")?.Value;
        set => this.WithProperty("platform_principal", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The success_feedback_role_arn attribute.
    /// </summary>
    public string? SuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("success_feedback_role_arn")?.Value;
        set => this.WithProperty("success_feedback_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    public string? SuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("success_feedback_sample_rate")?.Value;
        set => this.WithProperty("success_feedback_sample_rate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
