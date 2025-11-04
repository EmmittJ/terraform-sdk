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
        this.DeclareOutput("base_model_arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("hyperparameters");
        this.DeclareOutput("id");
        this.DeclareOutput("job_arn");
        this.DeclareOutput("job_name");
        this.DeclareOutput("job_tags");
        this.DeclareOutput("model_arn");
        this.DeclareOutput("model_kms_key_arn");
        this.DeclareOutput("model_name");
        this.DeclareOutput("model_tags");
        this.DeclareOutput("output_data_config");
        this.DeclareOutput("training_data_config");
        this.DeclareOutput("training_metrics");
        this.DeclareOutput("validation_data_config");
        this.DeclareOutput("validation_metrics");
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    public string? ModelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_id")?.Value;
        set => this.WithProperty("model_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
