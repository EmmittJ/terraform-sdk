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
        this.WithOutput("arn");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The anomaly_visibility_time attribute.
    /// </summary>
    public TerraformProperty<double>? AnomalyVisibilityTime
    {
        get => GetProperty<TerraformProperty<double>>("anomaly_visibility_time");
        set => this.WithProperty("anomaly_visibility_time", value);
    }

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    public TerraformProperty<string>? DetectorName
    {
        get => GetProperty<TerraformProperty<string>>("detector_name");
        set => this.WithProperty("detector_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? EvaluationFrequency
    {
        get => GetProperty<TerraformProperty<string>>("evaluation_frequency");
        set => this.WithProperty("evaluation_frequency", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    public TerraformProperty<string>? FilterPattern
    {
        get => GetProperty<TerraformProperty<string>>("filter_pattern");
        set => this.WithProperty("filter_pattern", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArnList is required")]
    public List<TerraformProperty<string>>? LogGroupArnList
    {
        get => GetProperty<List<TerraformProperty<string>>>("log_group_arn_list");
        set => this.WithProperty("log_group_arn_list", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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
