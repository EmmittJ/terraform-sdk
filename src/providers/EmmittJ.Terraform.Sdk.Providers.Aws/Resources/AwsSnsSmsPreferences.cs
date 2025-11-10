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
    public TerraformProperty<string>? DefaultSenderId
    {
        get => GetProperty<TerraformProperty<string>>("default_sender_id");
        set => this.WithProperty("default_sender_id", value);
    }

    /// <summary>
    /// The default_sms_type attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultSmsType
    {
        get => GetProperty<TerraformProperty<string>>("default_sms_type");
        set => this.WithProperty("default_sms_type", value);
    }

    /// <summary>
    /// The delivery_status_iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DeliveryStatusIamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("delivery_status_iam_role_arn");
        set => this.WithProperty("delivery_status_iam_role_arn", value);
    }

    /// <summary>
    /// The delivery_status_success_sampling_rate attribute.
    /// </summary>
    public TerraformProperty<string>? DeliveryStatusSuccessSamplingRate
    {
        get => GetProperty<TerraformProperty<string>>("delivery_status_success_sampling_rate");
        set => this.WithProperty("delivery_status_success_sampling_rate", value);
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
    /// The monthly_spend_limit attribute.
    /// </summary>
    public TerraformProperty<double>? MonthlySpendLimit
    {
        get => GetProperty<TerraformProperty<double>>("monthly_spend_limit");
        set => this.WithProperty("monthly_spend_limit", value);
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
    /// The usage_report_s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? UsageReportS3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("usage_report_s3_bucket");
        set => this.WithProperty("usage_report_s3_bucket", value);
    }

}
