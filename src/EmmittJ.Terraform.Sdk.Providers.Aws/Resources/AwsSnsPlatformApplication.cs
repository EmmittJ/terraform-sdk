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
    public TerraformProperty<string>? ApplePlatformBundleId
    {
        get => GetProperty<TerraformProperty<string>>("apple_platform_bundle_id");
        set => this.WithProperty("apple_platform_bundle_id", value);
    }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplePlatformTeamId
    {
        get => GetProperty<TerraformProperty<string>>("apple_platform_team_id");
        set => this.WithProperty("apple_platform_team_id", value);
    }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventDeliveryFailureTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("event_delivery_failure_topic_arn");
        set => this.WithProperty("event_delivery_failure_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventEndpointCreatedTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("event_endpoint_created_topic_arn");
        set => this.WithProperty("event_endpoint_created_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventEndpointDeletedTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("event_endpoint_deleted_topic_arn");
        set => this.WithProperty("event_endpoint_deleted_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? EventEndpointUpdatedTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("event_endpoint_updated_topic_arn");
        set => this.WithProperty("event_endpoint_updated_topic_arn", value);
    }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? FailureFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("failure_feedback_role_arn");
        set => this.WithProperty("failure_feedback_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Platform is required")]
    public required TerraformProperty<string> Platform
    {
        get => GetRequiredProperty<TerraformProperty<string>>("platform");
        set => this.WithProperty("platform", value);
    }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformCredential is required")]
    public required TerraformProperty<string> PlatformCredential
    {
        get => GetRequiredProperty<TerraformProperty<string>>("platform_credential");
        set => this.WithProperty("platform_credential", value);
    }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformPrincipal
    {
        get => GetProperty<TerraformProperty<string>>("platform_principal");
        set => this.WithProperty("platform_principal", value);
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
    /// The success_feedback_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SuccessFeedbackRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("success_feedback_role_arn");
        set => this.WithProperty("success_feedback_role_arn", value);
    }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformProperty<string>? SuccessFeedbackSampleRate
    {
        get => GetProperty<TerraformProperty<string>>("success_feedback_sample_rate");
        set => this.WithProperty("success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
