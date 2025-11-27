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
        get => new TerraformReference<double>(this, "anomaly_visibility_time");
        set => SetArgument("anomaly_visibility_time", value);
    }

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    public TerraformValue<string>? DetectorName
    {
        get => new TerraformReference<string>(this, "detector_name");
        set => SetArgument("detector_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    public TerraformValue<string>? EvaluationFrequency
    {
        get => new TerraformReference<string>(this, "evaluation_frequency");
        set => SetArgument("evaluation_frequency", value);
    }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    public TerraformValue<string>? FilterPattern
    {
        get => new TerraformReference<string>(this, "filter_pattern");
        set => SetArgument("filter_pattern", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArnList is required")]
    public TerraformList<string>? LogGroupArnList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "log_group_arn_list").ResolveNodes(ctx));
        set => SetArgument("log_group_arn_list", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

}
