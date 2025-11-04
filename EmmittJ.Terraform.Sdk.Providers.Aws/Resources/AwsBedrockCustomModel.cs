using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrock_custom_model resource.
/// </summary>
public class AwsBedrockCustomModel : TerraformResource
{
    public AwsBedrockCustomModel(string name) : base("aws_bedrock_custom_model", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_model_arn");
        this.DeclareOutput("id");
        this.DeclareOutput("job_arn");
        this.DeclareOutput("job_status");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("training_metrics");
        this.DeclareOutput("validation_metrics");
    }

    /// <summary>
    /// The base_model_identifier attribute.
    /// </summary>
    public string? BaseModelIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_model_identifier")?.Value;
        set => this.WithProperty("base_model_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_model_kms_key_id attribute.
    /// </summary>
    public string? CustomModelKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_model_kms_key_id")?.Value;
        set => this.WithProperty("custom_model_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_model_name attribute.
    /// </summary>
    public string? CustomModelName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_model_name")?.Value;
        set => this.WithProperty("custom_model_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customization_type attribute.
    /// </summary>
    public string? CustomizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customization_type")?.Value;
        set => this.WithProperty("customization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    public Dictionary<string, string>? Hyperparameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("hyperparameters")?.Value;
        set => this.WithProperty("hyperparameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public string? JobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_name")?.Value;
        set => this.WithProperty("job_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The custom_model_arn attribute.
    /// </summary>
    public TerraformExpression CustomModelArn => this["custom_model_arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The job_arn attribute.
    /// </summary>
    public TerraformExpression JobArn => this["job_arn"];

    /// <summary>
    /// The job_status attribute.
    /// </summary>
    public TerraformExpression JobStatus => this["job_status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    public TerraformExpression TrainingMetrics => this["training_metrics"];

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    public TerraformExpression ValidationMetrics => this["validation_metrics"];

}
