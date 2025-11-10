using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelOutputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformProperty<string> S3Uri
    {
        get => GetProperty<TerraformProperty<string>>("s3_uri");
        set => WithProperty("s3_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockCustomModelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Block type for training_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelTrainingDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformProperty<string> S3Uri
    {
        get => GetProperty<TerraformProperty<string>>("s3_uri");
        set => WithProperty("s3_uri", value);
    }

}

/// <summary>
/// Block type for validation_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelValidationDataConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelIdentifier is required")]
    public required TerraformProperty<string> BaseModelIdentifier
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomModelName is required")]
    public required TerraformProperty<string> CustomModelName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hyperparameters is required")]
    public Dictionary<string, TerraformProperty<string>>? Hyperparameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("hyperparameters");
        set => this.WithProperty("hyperparameters", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformProperty<string> JobName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// Block for output_data_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelOutputDataConfigBlock>? OutputDataConfig
    {
        get => GetProperty<List<AwsBedrockCustomModelOutputDataConfigBlock>>("output_data_config");
        set => this.WithProperty("output_data_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockCustomModelTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockCustomModelTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for training_data_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelTrainingDataConfigBlock>? TrainingDataConfig
    {
        get => GetProperty<List<AwsBedrockCustomModelTrainingDataConfigBlock>>("training_data_config");
        set => this.WithProperty("training_data_config", value);
    }

    /// <summary>
    /// Block for validation_data_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelValidationDataConfigBlock>? ValidationDataConfig
    {
        get => GetProperty<List<AwsBedrockCustomModelValidationDataConfigBlock>>("validation_data_config");
        set => this.WithProperty("validation_data_config", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelVpcConfigBlock>? VpcConfig
    {
        get => GetProperty<List<AwsBedrockCustomModelVpcConfigBlock>>("vpc_config");
        set => this.WithProperty("vpc_config", value);
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
