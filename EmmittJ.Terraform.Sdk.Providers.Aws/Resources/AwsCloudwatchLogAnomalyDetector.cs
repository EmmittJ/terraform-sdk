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
    public double? AnomalyVisibilityTime
    {
        get => GetProperty<TerraformLiteralProperty<double>>("anomaly_visibility_time")?.Value;
        set => this.WithProperty("anomaly_visibility_time", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    public string? DetectorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_name")?.Value;
        set => this.WithProperty("detector_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public string? EvaluationFrequency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluation_frequency")?.Value;
        set => this.WithProperty("evaluation_frequency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    public string? FilterPattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filter_pattern")?.Value;
        set => this.WithProperty("filter_pattern", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    public List<string>? LogGroupArnList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("log_group_arn_list")?.Value;
        set => this.WithProperty("log_group_arn_list", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
