using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sns_sms_preferences resource.
/// </summary>
public class AwsSnsSmsPreferences : TerraformResource
{
    public AwsSnsSmsPreferences(string name) : base("aws_sns_sms_preferences", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The default_sender_id attribute.
    /// </summary>
    public string? DefaultSenderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_sender_id")?.Value;
        set => this.WithProperty("default_sender_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_sms_type attribute.
    /// </summary>
    public string? DefaultSmsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_sms_type")?.Value;
        set => this.WithProperty("default_sms_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delivery_status_iam_role_arn attribute.
    /// </summary>
    public string? DeliveryStatusIamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_status_iam_role_arn")?.Value;
        set => this.WithProperty("delivery_status_iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delivery_status_success_sampling_rate attribute.
    /// </summary>
    public string? DeliveryStatusSuccessSamplingRate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_status_success_sampling_rate")?.Value;
        set => this.WithProperty("delivery_status_success_sampling_rate", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The monthly_spend_limit attribute.
    /// </summary>
    public double? MonthlySpendLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("monthly_spend_limit")?.Value;
        set => this.WithProperty("monthly_spend_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The usage_report_s3_bucket attribute.
    /// </summary>
    public string? UsageReportS3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_report_s3_bucket")?.Value;
        set => this.WithProperty("usage_report_s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
