using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_data_config in AwsTranscribeLanguageModel.
/// Nesting mode: list
/// </summary>
public class AwsTranscribeLanguageModelInputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_data_config";

    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessRoleArn is required")]
    public required TerraformValue<string> DataAccessRoleArn
    {
        get => new TerraformReference<string>(this, "data_access_role_arn");
        set => SetArgument("data_access_role_arn", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

    /// <summary>
    /// The tuning_data_s3_uri attribute.
    /// </summary>
    public TerraformValue<string> TuningDataS3Uri
    {
        get => new TerraformReference<string>(this, "tuning_data_s3_uri");
        set => SetArgument("tuning_data_s3_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsTranscribeLanguageModel.
/// Nesting mode: single
/// </summary>
public class AwsTranscribeLanguageModelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_transcribe_language_model Terraform resource.
/// Manages a aws_transcribe_language_model resource.
/// </summary>
public partial class AwsTranscribeLanguageModel(string name) : TerraformResource("aws_transcribe_language_model", name)
{
    /// <summary>
    /// The base_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelName is required")]
    public required TerraformValue<string> BaseModelName
    {
        get => new TerraformReference<string>(this, "base_model_name");
        set => SetArgument("base_model_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformValue<string> ModelName
    {
        get => new TerraformReference<string>(this, "model_name");
        set => SetArgument("model_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// InputDataConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputDataConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputDataConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputDataConfig block(s) allowed")]
    public required TerraformList<AwsTranscribeLanguageModelInputDataConfigBlock> InputDataConfig
    {
        get => GetRequiredArgument<TerraformList<AwsTranscribeLanguageModelInputDataConfigBlock>>("input_data_config");
        set => SetArgument("input_data_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsTranscribeLanguageModelTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsTranscribeLanguageModelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
