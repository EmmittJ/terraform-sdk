using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_sms_preferences resource.
/// </summary>
public class AwsSnsSmsPreferences : TerraformResource
{
    public AwsSnsSmsPreferences(string name) : base("aws_sns_sms_preferences", name)
    {
    }

    /// <summary>
    /// The default_sender_id attribute.
    /// </summary>
    [TerraformPropertyName("default_sender_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultSenderId { get; set; }

    /// <summary>
    /// The default_sms_type attribute.
    /// </summary>
    [TerraformPropertyName("default_sms_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultSmsType { get; set; }

    /// <summary>
    /// The delivery_status_iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("delivery_status_iam_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeliveryStatusIamRoleArn { get; set; }

    /// <summary>
    /// The delivery_status_success_sampling_rate attribute.
    /// </summary>
    [TerraformPropertyName("delivery_status_success_sampling_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeliveryStatusSuccessSamplingRate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The monthly_spend_limit attribute.
    /// </summary>
    [TerraformPropertyName("monthly_spend_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MonthlySpendLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "monthly_spend_limit");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The usage_report_s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("usage_report_s3_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UsageReportS3Bucket { get; set; }

}
