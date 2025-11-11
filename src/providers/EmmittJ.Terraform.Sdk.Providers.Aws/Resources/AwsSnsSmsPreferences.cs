using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_sms_preferences resource.
/// </summary>
public partial class AwsSnsSmsPreferences : TerraformResource
{
    public AwsSnsSmsPreferences(string name) : base("aws_sns_sms_preferences", name)
    {
    }

    /// <summary>
    /// The default_sender_id attribute.
    /// </summary>
    [TerraformProperty("default_sender_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultSenderId { get; set; }

    /// <summary>
    /// The default_sms_type attribute.
    /// </summary>
    [TerraformProperty("default_sms_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultSmsType { get; set; }

    /// <summary>
    /// The delivery_status_iam_role_arn attribute.
    /// </summary>
    [TerraformProperty("delivery_status_iam_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeliveryStatusIamRoleArn { get; set; }

    /// <summary>
    /// The delivery_status_success_sampling_rate attribute.
    /// </summary>
    [TerraformProperty("delivery_status_success_sampling_rate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeliveryStatusSuccessSamplingRate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The monthly_spend_limit attribute.
    /// </summary>
    [TerraformProperty("monthly_spend_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MonthlySpendLimit { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The usage_report_s3_bucket attribute.
    /// </summary>
    [TerraformProperty("usage_report_s3_bucket")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UsageReportS3Bucket { get; set; }

}
