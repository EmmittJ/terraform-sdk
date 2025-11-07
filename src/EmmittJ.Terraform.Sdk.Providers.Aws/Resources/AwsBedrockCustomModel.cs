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
    public TerraformProperty<string>? BaseModelIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("base_model_identifier");
        set => this.WithProperty("base_model_identifier", value);
    }

    /// <summary>
    /// The custom_model_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomModelKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("custom_model_kms_key_id");
        set => this.WithProperty("custom_model_kms_key_id", value);
    }

    /// <summary>
    /// The custom_model_name attribute.
    /// </summary>
    public TerraformProperty<string>? CustomModelName
    {
        get => GetProperty<TerraformProperty<string>>("custom_model_name");
        set => this.WithProperty("custom_model_name", value);
    }

    /// <summary>
    /// The customization_type attribute.
    /// </summary>
    public TerraformProperty<string>? CustomizationType
    {
        get => GetProperty<TerraformProperty<string>>("customization_type");
        set => this.WithProperty("customization_type", value);
    }

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Hyperparameters
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("hyperparameters");
        set => this.WithProperty("hyperparameters", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    public TerraformProperty<string>? JobName
    {
        get => GetProperty<TerraformProperty<string>>("job_name");
        set => this.WithProperty("job_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
