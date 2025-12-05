using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_bedrock_custom_model Terraform data source.
/// Retrieves information about a aws_bedrock_custom_model.
/// </summary>
public partial class AwsBedrockCustomModelDataSource(string name) : TerraformDataSource("aws_bedrock_custom_model", name)
{
    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformValue<string> ModelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
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
    /// The base_model_arn attribute.
    /// </summary>
    public TerraformValue<string> BaseModelArn
        => CreateReference("base_model_arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => CreateReference("creation_time");

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    public TerraformMap<string> Hyperparameters
        => CreateReference("hyperparameters");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    public TerraformValue<string> JobArn
        => CreateReference("job_arn");

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformValue<string> JobName
        => CreateReference("job_name");

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    public TerraformMap<string> JobTags
        => CreateReference("job_tags");

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public TerraformValue<string> ModelArn
        => CreateReference("model_arn");

    /// <summary>
    /// The model_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> ModelKmsKeyArn
        => CreateReference("model_kms_key_arn");

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    public TerraformValue<string> ModelName
        => CreateReference("model_name");

    /// <summary>
    /// The model_tags attribute.
    /// </summary>
    public TerraformMap<string> ModelTags
        => CreateReference("model_tags");

    /// <summary>
    /// The output_data_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutputDataConfig
        => CreateReference("output_data_config");

    /// <summary>
    /// The training_data_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrainingDataConfig
        => CreateReference("training_data_config");

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrainingMetrics
        => CreateReference("training_metrics");

    /// <summary>
    /// The validation_data_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationDataConfig
        => CreateReference("validation_data_config");

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationMetrics
        => CreateReference("validation_metrics");

}
