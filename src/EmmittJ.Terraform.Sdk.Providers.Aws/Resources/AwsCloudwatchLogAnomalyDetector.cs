using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_anomaly_detector resource.
/// </summary>
public class AwsCloudwatchLogAnomalyDetector : TerraformResource
{
    public AwsCloudwatchLogAnomalyDetector(string name) : base("aws_cloudwatch_log_anomaly_detector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The anomaly_visibility_time attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AnomalyVisibilityTime
    {
        get => GetProperty<TerraformLiteralProperty<double>>("anomaly_visibility_time");
        set => this.WithProperty("anomaly_visibility_time", value);
    }

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DetectorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_name");
        set => this.WithProperty("detector_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EvaluationFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluation_frequency");
        set => this.WithProperty("evaluation_frequency", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FilterPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_pattern");
        set => this.WithProperty("filter_pattern", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? LogGroupArnList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("log_group_arn_list");
        set => this.WithProperty("log_group_arn_list", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
