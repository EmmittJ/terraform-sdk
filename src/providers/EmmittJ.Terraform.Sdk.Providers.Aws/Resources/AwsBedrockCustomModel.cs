using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_data_config in AwsBedrockCustomModel.
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelOutputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_data_config";

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockCustomModel.
/// Nesting mode: single
/// </summary>
public class AwsBedrockCustomModelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Block type for training_data_config in AwsBedrockCustomModel.
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelTrainingDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "training_data_config";

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

}


/// <summary>
/// Block type for validation_data_config in AwsBedrockCustomModel.
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelValidationDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation_data_config";

    /// <summary>
    /// Validator block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockCustomModelValidationDataConfigBlockValidatorBlock>? Validator
    {
        get => GetArgument<TerraformList<AwsBedrockCustomModelValidationDataConfigBlockValidatorBlock>>("validator");
        set => SetArgument("validator", value);
    }

}

/// <summary>
/// Block type for validator in AwsBedrockCustomModelValidationDataConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelValidationDataConfigBlockValidatorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validator";

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsBedrockCustomModel.
/// Nesting mode: list
/// </summary>
public class AwsBedrockCustomModelVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Represents a aws_bedrock_custom_model Terraform resource.
/// Manages a aws_bedrock_custom_model resource.
/// </summary>
public partial class AwsBedrockCustomModel(string name) : TerraformResource("aws_bedrock_custom_model", name)
{
    /// <summary>
    /// The base_model_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelIdentifier is required")]
    public required TerraformValue<string> BaseModelIdentifier
    {
        get => new TerraformReference<string>(this, "base_model_identifier");
        set => SetArgument("base_model_identifier", value);
    }

    /// <summary>
    /// The custom_model_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomModelKmsKeyId
    {
        get => new TerraformReference<string>(this, "custom_model_kms_key_id");
        set => SetArgument("custom_model_kms_key_id", value);
    }

    /// <summary>
    /// The custom_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomModelName is required")]
    public required TerraformValue<string> CustomModelName
    {
        get => new TerraformReference<string>(this, "custom_model_name");
        set => SetArgument("custom_model_name", value);
    }

    /// <summary>
    /// The customization_type attribute.
    /// </summary>
    public TerraformValue<string> CustomizationType
    {
        get => new TerraformReference<string>(this, "customization_type");
        set => SetArgument("customization_type", value);
    }

    /// <summary>
    /// The hyperparameters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hyperparameters is required")]
    public required TerraformMap<string> Hyperparameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "hyperparameters").ResolveNodes(ctx));
        set => SetArgument("hyperparameters", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformValue<string> JobName
    {
        get => new TerraformReference<string>(this, "job_name");
        set => SetArgument("job_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
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
    /// The custom_model_arn attribute.
    /// </summary>
    public TerraformValue<string> CustomModelArn
    {
        get => new TerraformReference<string>(this, "custom_model_arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
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
    /// The job_status attribute.
    /// </summary>
    public TerraformValue<string> JobStatus
    {
        get => new TerraformReference<string>(this, "job_status");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The training_metrics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrainingMetrics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "training_metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The validation_metrics attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ValidationMetrics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "validation_metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// OutputDataConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockCustomModelOutputDataConfigBlock>? OutputDataConfig
    {
        get => GetArgument<TerraformList<AwsBedrockCustomModelOutputDataConfigBlock>>("output_data_config");
        set => SetArgument("output_data_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockCustomModelTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockCustomModelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrainingDataConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockCustomModelTrainingDataConfigBlock>? TrainingDataConfig
    {
        get => GetArgument<TerraformList<AwsBedrockCustomModelTrainingDataConfigBlock>>("training_data_config");
        set => SetArgument("training_data_config", value);
    }

    /// <summary>
    /// ValidationDataConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockCustomModelValidationDataConfigBlock>? ValidationDataConfig
    {
        get => GetArgument<TerraformList<AwsBedrockCustomModelValidationDataConfigBlock>>("validation_data_config");
        set => SetArgument("validation_data_config", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockCustomModelVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsBedrockCustomModelVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
