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
        SetOutput("default_sender_id");
        SetOutput("default_sms_type");
        SetOutput("delivery_status_iam_role_arn");
        SetOutput("delivery_status_success_sampling_rate");
        SetOutput("id");
        SetOutput("monthly_spend_limit");
        SetOutput("region");
        SetOutput("usage_report_s3_bucket");
    }

    /// <summary>
    /// The default_sender_id attribute.
    /// </summary>
    public TerraformProperty<string> DefaultSenderId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_sender_id");
        set => SetProperty("default_sender_id", value);
    }

    /// <summary>
    /// The default_sms_type attribute.
    /// </summary>
    public TerraformProperty<string> DefaultSmsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_sms_type");
        set => SetProperty("default_sms_type", value);
    }

    /// <summary>
    /// The delivery_status_iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> DeliveryStatusIamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_status_iam_role_arn");
        set => SetProperty("delivery_status_iam_role_arn", value);
    }

    /// <summary>
    /// The delivery_status_success_sampling_rate attribute.
    /// </summary>
    public TerraformProperty<string> DeliveryStatusSuccessSamplingRate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delivery_status_success_sampling_rate");
        set => SetProperty("delivery_status_success_sampling_rate", value);
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
    /// The monthly_spend_limit attribute.
    /// </summary>
    public TerraformProperty<double> MonthlySpendLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("monthly_spend_limit");
        set => SetProperty("monthly_spend_limit", value);
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
    /// The usage_report_s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string> UsageReportS3Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("usage_report_s3_bucket");
        set => SetProperty("usage_report_s3_bucket", value);
    }

}
