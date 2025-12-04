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
        get => GetArgument<TerraformValue<string>>("apple_platform_bundle_id");
        set => SetArgument("apple_platform_bundle_id", value);
    }

    /// <summary>
    /// The apple_platform_team_id attribute.
    /// </summary>
    public TerraformValue<string>? ApplePlatformTeamId
    {
        get => GetArgument<TerraformValue<string>>("apple_platform_team_id");
        set => SetArgument("apple_platform_team_id", value);
    }

    /// <summary>
    /// The event_delivery_failure_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventDeliveryFailureTopicArn
    {
        get => GetArgument<TerraformValue<string>>("event_delivery_failure_topic_arn");
        set => SetArgument("event_delivery_failure_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_created_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventEndpointCreatedTopicArn
    {
        get => GetArgument<TerraformValue<string>>("event_endpoint_created_topic_arn");
        set => SetArgument("event_endpoint_created_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_deleted_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventEndpointDeletedTopicArn
    {
        get => GetArgument<TerraformValue<string>>("event_endpoint_deleted_topic_arn");
        set => SetArgument("event_endpoint_deleted_topic_arn", value);
    }

    /// <summary>
    /// The event_endpoint_updated_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? EventEndpointUpdatedTopicArn
    {
        get => GetArgument<TerraformValue<string>>("event_endpoint_updated_topic_arn");
        set => SetArgument("event_endpoint_updated_topic_arn", value);
    }

    /// <summary>
    /// The failure_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? FailureFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("failure_feedback_role_arn");
        set => SetArgument("failure_feedback_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Platform is required")]
    public required TerraformValue<string> Platform
    {
        get => GetRequiredArgument<TerraformValue<string>>("platform");
        set => SetArgument("platform", value);
    }

    /// <summary>
    /// The platform_credential attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformCredential is required")]
    public required TerraformValue<string> PlatformCredential
    {
        get => GetRequiredArgument<TerraformValue<string>>("platform_credential");
        set => SetArgument("platform_credential", value);
    }

    /// <summary>
    /// The platform_principal attribute.
    /// </summary>
    public TerraformValue<string>? PlatformPrincipal
    {
        get => GetArgument<TerraformValue<string>>("platform_principal");
        set => SetArgument("platform_principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The success_feedback_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SuccessFeedbackRoleArn
    {
        get => GetArgument<TerraformValue<string>>("success_feedback_role_arn");
        set => SetArgument("success_feedback_role_arn", value);
    }

    /// <summary>
    /// The success_feedback_sample_rate attribute.
    /// </summary>
    public TerraformValue<string>? SuccessFeedbackSampleRate
    {
        get => GetArgument<TerraformValue<string>>("success_feedback_sample_rate");
        set => SetArgument("success_feedback_sample_rate", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
