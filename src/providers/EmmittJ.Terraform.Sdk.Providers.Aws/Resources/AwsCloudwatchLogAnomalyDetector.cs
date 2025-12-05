using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_anomaly_detector Terraform resource.
/// Manages a aws_cloudwatch_log_anomaly_detector resource.
/// </summary>
public partial class AwsCloudwatchLogAnomalyDetector(string name) : TerraformResource("aws_cloudwatch_log_anomaly_detector", name)
{
    /// <summary>
    /// The anomaly_visibility_time attribute.
    /// </summary>
    public TerraformValue<double> AnomalyVisibilityTime
    {
        get => GetArgument<TerraformValue<double>>("anomaly_visibility_time") ?? CreateReference("anomaly_visibility_time");
        set => SetArgument("anomaly_visibility_time", value);
    }

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    public TerraformValue<string>? DetectorName
    {
        get => GetArgument<TerraformValue<string>>("detector_name");
        set => SetArgument("detector_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public TerraformValue<string>? EvaluationFrequency
    {
        get => GetArgument<TerraformValue<string>>("evaluation_frequency");
        set => SetArgument("evaluation_frequency", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    public TerraformValue<string>? FilterPattern
    {
        get => GetArgument<TerraformValue<string>>("filter_pattern");
        set => SetArgument("filter_pattern", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArnList is required")]
    public TerraformList<string>? LogGroupArnList
    {
        get => GetArgument<TerraformList<string>>("log_group_arn_list");
        set => SetArgument("log_group_arn_list", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

}
