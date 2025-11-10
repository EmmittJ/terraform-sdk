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
        set => SetProperty("s3_uri", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        set => SetProperty("s3_uri", value);
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
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
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
        SetOutput("custom_model_arn");
        SetOutput("id");
        SetOutput("job_arn");
        SetOutput("job_status");
        SetOutput("tags_all");
        SetOutput("training_metrics");
        SetOutput("validation_metrics");
        SetOutput("base_model_identifier");
        SetOutput("custom_model_kms_key_id");
        SetOutput("custom_model_name");
        SetOutput("customization_type");
        SetOutput("hyperparameters");
        SetOutput("job_name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
    }

    /// <summary>
    /// The base_model_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelIdentifier is required")]
    public required TerraformProperty<string> BaseModelIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_model_identifier");
        set => SetProperty("base_model_identifier", value);
    }

    /// <summary>
    /// The custom_model_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomModelKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_model_kms_key_id");
        set => SetProperty("custom_model_kms_key_id", value);
    }

    /// <summary>
    /// The custom_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomModelName is required")]
    public required TerraformProperty<string> CustomModelName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_model_name");
        set => SetProperty("custom_model_name", value);
    }

    /// <summary>
    /// The customization_type attribute.
    /// </summary>
    public TerraformProperty<string> CustomizationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customization_type");
        set => SetProperty("customization_type", value);
    }

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hyperparameters is required")]
    public Dictionary<string, TerraformProperty<string>> Hyperparameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("hyperparameters");
        set => SetProperty("hyperparameters", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformProperty<string> JobName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_name");
        set => SetProperty("job_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
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
    /// Block for output_data_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelOutputDataConfigBlock>? OutputDataConfig
    {
        set => SetProperty("output_data_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockCustomModelTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for training_data_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelTrainingDataConfigBlock>? TrainingDataConfig
    {
        set => SetProperty("training_data_config", value);
    }

    /// <summary>
    /// Block for validation_data_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelValidationDataConfigBlock>? ValidationDataConfig
    {
        set => SetProperty("validation_data_config", value);
    }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockCustomModelVpcConfigBlock>? VpcConfig
    {
        set => SetProperty("vpc_config", value);
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
