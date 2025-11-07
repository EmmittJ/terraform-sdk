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
    public TerraformLiteralProperty<string>? DefaultSenderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_sender_id");
        set => this.WithProperty("default_sender_id", value);
    }

    /// <summary>
    /// The default_sms_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultSmsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_sms_type");
        set => this.WithProperty("default_sms_type", value);
    }

    /// <summary>
    /// The delivery_status_iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliveryStatusIamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_status_iam_role_arn");
        set => this.WithProperty("delivery_status_iam_role_arn", value);
    }

    /// <summary>
    /// The delivery_status_success_sampling_rate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliveryStatusSuccessSamplingRate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_status_success_sampling_rate");
        set => this.WithProperty("delivery_status_success_sampling_rate", value);
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
    /// The monthly_spend_limit attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MonthlySpendLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("monthly_spend_limit");
        set => this.WithProperty("monthly_spend_limit", value);
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
    /// The usage_report_s3_bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UsageReportS3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_report_s3_bucket");
        set => this.WithProperty("usage_report_s3_bucket", value);
    }

}
