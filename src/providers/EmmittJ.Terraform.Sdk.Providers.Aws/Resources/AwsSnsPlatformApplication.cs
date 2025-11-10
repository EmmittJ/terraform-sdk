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
        SetOutput("arn");
        SetOutput("apple_platform_bundle_id");
        SetOutput("apple_platform_team_id");
        SetOutput("event_delivery_failure_topic_arn");
        SetOutput("event_endpoint_created_topic_arn");
        SetOutput("event_endpoint_deleted_topic_arn");
        SetOutput("event_endpoint_updated_topic_arn");
        SetOutput("failure_feedback_role_arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("platform");
        SetOutput("platform_credential");
        SetOutput("platform_principal");
        SetOutput("region");
        SetOutput("success_feedback_role_arn");
        SetOutput("success_feedback_sample_rate");
    }

    /// <summary>
    /// The apple_platform_bundle_id attribute.
    /// </summary>
    public TerraformProperty<string> ApplePlatformBundleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("apple_platform_bundle_id");
        set => SetProperty("apple_platform_bundle_id", value);
    }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    public TerraformProperty<string> ApplePlatformTeamId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("apple_platform_team_id");
        set => SetProperty("apple_platform_team_id", value);
    }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> EventDeliveryFailureTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_delivery_failure_topic_arn");
        set => SetProperty("event_delivery_failure_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> EventEndpointCreatedTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_endpoint_created_topic_arn");
        set => SetProperty("event_endpoint_created_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> EventEndpointDeletedTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_endpoint_deleted_topic_arn");
        set => SetProperty("event_endpoint_deleted_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> EventEndpointUpdatedTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_endpoint_updated_topic_arn");
        set => SetProperty("event_endpoint_updated_topic_arn", value);
    }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> FailureFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("failure_feedback_role_arn");
        set => SetProperty("failure_feedback_role_arn", value);
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
    /// The platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Platform is required")]
    public required TerraformProperty<string> Platform
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform");
        set => SetProperty("platform", value);
    }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformCredential is required")]
    public required TerraformProperty<string> PlatformCredential
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_credential");
        set => SetProperty("platform_credential", value);
    }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    public TerraformProperty<string> PlatformPrincipal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_principal");
        set => SetProperty("platform_principal", value);
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
    /// The success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> SuccessFeedbackRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("success_feedback_role_arn");
        set => SetProperty("success_feedback_role_arn", value);
    }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<string> SuccessFeedbackSampleRate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("success_feedback_sample_rate");
        set => SetProperty("success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
