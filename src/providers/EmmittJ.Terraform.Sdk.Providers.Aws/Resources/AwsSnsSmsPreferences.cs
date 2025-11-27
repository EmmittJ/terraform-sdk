using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sns_sms_preferences Terraform resource.
/// Manages a aws_sns_sms_preferences resource.
/// </summary>
public partial class AwsSnsSmsPreferences(string name) : TerraformResource("aws_sns_sms_preferences", name)
{
    /// <summary>
    /// The default_sender_id attribute.
    /// </summary>
    public TerraformValue<string>? DefaultSenderId
    {
        get => new TerraformReference<string>(this, "default_sender_id");
        set => SetArgument("default_sender_id", value);
    }

    /// <summary>
    /// The default_sms_type attribute.
    /// </summary>
    public TerraformValue<string>? DefaultSmsType
    {
        get => new TerraformReference<string>(this, "default_sms_type");
        set => SetArgument("default_sms_type", value);
    }

    /// <summary>
    /// The delivery_status_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryStatusIamRoleArn
    {
        get => new TerraformReference<string>(this, "delivery_status_iam_role_arn");
        set => SetArgument("delivery_status_iam_role_arn", value);
    }

    /// <summary>
    /// The delivery_status_success_sampling_rate attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryStatusSuccessSamplingRate
    {
        get => new TerraformReference<string>(this, "delivery_status_success_sampling_rate");
        set => SetArgument("delivery_status_success_sampling_rate", value);
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
    /// The monthly_spend_limit attribute.
    /// </summary>
    public TerraformValue<double> MonthlySpendLimit
    {
        get => new TerraformReference<double>(this, "monthly_spend_limit");
        set => SetArgument("monthly_spend_limit", value);
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
    /// The usage_report_s3_bucket attribute.
    /// </summary>
    public TerraformValue<string>? UsageReportS3Bucket
    {
        get => new TerraformReference<string>(this, "usage_report_s3_bucket");
        set => SetArgument("usage_report_s3_bucket", value);
    }

}
