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
        get => new TerraformReference<string>(this, "model_id");
        set => SetArgument("model_id", value);
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
    /// The base_model_arn attribute.
    /// </summary>
    public TerraformValue<string> BaseModelArn
    {
        get => new TerraformReference<string>(this, "base_model_arn");
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    public TerraformMap<string> Hyperparameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "hyperparameters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    public TerraformValue<string> JobArn
    {
        get => new TerraformReference<string>(this, "job_arn");
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformValue<string> JobName
    {
        get => new TerraformReference<string>(this, "job_name");
    }

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    public TerraformMap<string> JobTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "job_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public TerraformValue<string> ModelArn
    {
        get => new TerraformReference<string>(this, "model_arn");
    }

    /// <summary>
    /// The model_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> ModelKmsKeyArn
    {
        get => new TerraformReference<string>(this, "model_kms_key_arn");
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    public TerraformValue<string> ModelName
    {
        get => new TerraformReference<string>(this, "model_name");
    }

    /// <summary>
    /// The model_tags attribute.
    /// </summary>
    public TerraformMap<string> ModelTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "model_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The output_data_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OutputDataConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "output_data_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The training_data_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrainingDataConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "training_data_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrainingMetrics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "training_metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The validation_data_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationDataConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "validation_data_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationMetrics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "validation_metrics").ResolveNodes(ctx));
    }

}
