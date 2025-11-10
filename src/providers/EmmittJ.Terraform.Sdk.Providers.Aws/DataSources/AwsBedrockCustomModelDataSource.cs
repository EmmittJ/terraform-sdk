using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_custom_model.
/// </summary>
public class AwsBedrockCustomModelDataSource : TerraformDataSource
{
    public AwsBedrockCustomModelDataSource(string name) : base("aws_bedrock_custom_model", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("base_model_arn");
        SetOutput("creation_time");
        SetOutput("hyperparameters");
        SetOutput("id");
        SetOutput("job_arn");
        SetOutput("job_name");
        SetOutput("job_tags");
        SetOutput("model_arn");
        SetOutput("model_kms_key_arn");
        SetOutput("model_name");
        SetOutput("model_tags");
        SetOutput("output_data_config");
        SetOutput("training_data_config");
        SetOutput("training_metrics");
        SetOutput("validation_data_config");
        SetOutput("validation_metrics");
        SetOutput("model_id");
        SetOutput("region");
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformProperty<string> ModelId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_id");
        set => SetProperty("model_id", value);
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
    /// The base_model_arn attribute.
    /// </summary>
    public TerraformExpression BaseModelArn => this["base_model_arn"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    public TerraformExpression Hyperparameters => this["hyperparameters"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    public TerraformExpression JobArn => this["job_arn"];

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformExpression JobName => this["job_name"];

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    public TerraformExpression JobTags => this["job_tags"];

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public TerraformExpression ModelArn => this["model_arn"];

    /// <summary>
    /// The model_kms_key_arn attribute.
    /// </summary>
    public TerraformExpression ModelKmsKeyArn => this["model_kms_key_arn"];

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    public TerraformExpression ModelName => this["model_name"];

    /// <summary>
    /// The model_tags attribute.
    /// </summary>
    public TerraformExpression ModelTags => this["model_tags"];

    /// <summary>
    /// The output_data_config attribute.
    /// </summary>
    public TerraformExpression OutputDataConfig => this["output_data_config"];

    /// <summary>
    /// The training_data_config attribute.
    /// </summary>
    public TerraformExpression TrainingDataConfig => this["training_data_config"];

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    public TerraformExpression TrainingMetrics => this["training_metrics"];

    /// <summary>
    /// The validation_data_config attribute.
    /// </summary>
    public TerraformExpression ValidationDataConfig => this["validation_data_config"];

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    public TerraformExpression ValidationMetrics => this["validation_metrics"];

}
