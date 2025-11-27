using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sns_platform_application Terraform resource.
/// Manages a aws_sns_platform_application resource.
/// </summary>
public partial class AwsSnsPlatformApplication(string name) : TerraformResource("aws_sns_platform_application", name)
{
    /// <summary>
    /// The apple_platform_bundle_id attribute.
    /// </summary>
    public TerraformValue<string>? ApplePlatformBundleId
    {
        get => new TerraformReference<string>(this, "apple_platform_bundle_id");
        set => SetArgument("apple_platform_bundle_id", value);
    }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    public TerraformValue<string>? ApplePlatformTeamId
    {
        get => new TerraformReference<string>(this, "apple_platform_team_id");
        set => SetArgument("apple_platform_team_id", value);
    }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventDeliveryFailureTopicArn
    {
        get => new TerraformReference<string>(this, "event_delivery_failure_topic_arn");
        set => SetArgument("event_delivery_failure_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventEndpointCreatedTopicArn
    {
        get => new TerraformReference<string>(this, "event_endpoint_created_topic_arn");
        set => SetArgument("event_endpoint_created_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventEndpointDeletedTopicArn
    {
        get => new TerraformReference<string>(this, "event_endpoint_deleted_topic_arn");
        set => SetArgument("event_endpoint_deleted_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventEndpointUpdatedTopicArn
    {
        get => new TerraformReference<string>(this, "event_endpoint_updated_topic_arn");
        set => SetArgument("event_endpoint_updated_topic_arn", value);
    }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FailureFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "failure_feedback_role_arn");
        set => SetArgument("failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Platform is required")]
    public required TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
        set => SetArgument("platform", value);
    }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformCredential is required")]
    public required TerraformValue<string> PlatformCredential
    {
        get => new TerraformReference<string>(this, "platform_credential");
        set => SetArgument("platform_credential", value);
    }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    public TerraformValue<string>? PlatformPrincipal
    {
        get => new TerraformReference<string>(this, "platform_principal");
        set => SetArgument("platform_principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SuccessFeedbackRoleArn
    {
        get => new TerraformReference<string>(this, "success_feedback_role_arn");
        set => SetArgument("success_feedback_role_arn", value);
    }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<string>? SuccessFeedbackSampleRate
    {
        get => new TerraformReference<string>(this, "success_feedback_sample_rate");
        set => SetArgument("success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
