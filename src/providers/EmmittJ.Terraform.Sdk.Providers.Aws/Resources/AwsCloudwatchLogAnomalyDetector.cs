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
        SetOutput("arn");
        SetOutput("tags_all");
        SetOutput("anomaly_visibility_time");
        SetOutput("detector_name");
        SetOutput("enabled");
        SetOutput("evaluation_frequency");
        SetOutput("filter_pattern");
        SetOutput("kms_key_id");
        SetOutput("log_group_arn_list");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The anomaly_visibility_time attribute.
    /// </summary>
    public TerraformProperty<double> AnomalyVisibilityTime
    {
        get => GetRequiredOutput<TerraformProperty<double>>("anomaly_visibility_time");
        set => SetProperty("anomaly_visibility_time", value);
    }

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    public TerraformProperty<string> DetectorName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("detector_name");
        set => SetProperty("detector_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public TerraformProperty<string> EvaluationFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("evaluation_frequency");
        set => SetProperty("evaluation_frequency", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    public TerraformProperty<string> FilterPattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter_pattern");
        set => SetProperty("filter_pattern", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArnList is required")]
    public List<TerraformProperty<string>> LogGroupArnList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("log_group_arn_list");
        set => SetProperty("log_group_arn_list", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
