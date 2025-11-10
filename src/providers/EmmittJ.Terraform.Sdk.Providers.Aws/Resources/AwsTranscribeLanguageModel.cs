using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_data_config in .
/// Nesting mode: list
/// </summary>
public class AwsTranscribeLanguageModelInputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessRoleArn is required")]
    public required TerraformProperty<string> DataAccessRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_access_role_arn");
        set => WithProperty("data_access_role_arn", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformProperty<string> S3Uri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_uri");
        set => WithProperty("s3_uri", value);
    }

    /// <summary>
    /// The tuning_data_s3_uri attribute.
    /// </summary>
    public TerraformProperty<string>? TuningDataS3Uri
    {
        get => GetProperty<TerraformProperty<string>>("tuning_data_s3_uri");
        set => WithProperty("tuning_data_s3_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsTranscribeLanguageModelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_transcribe_language_model resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsTranscribeLanguageModel : TerraformResource
{
    public AwsTranscribeLanguageModel(string name) : base("aws_transcribe_language_model", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The base_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelName is required")]
    public required TerraformProperty<string> BaseModelName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("base_model_name");
        set => this.WithProperty("base_model_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformProperty<string> LanguageCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    public required TerraformProperty<string> ModelName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("model_name");
        set => this.WithProperty("model_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for input_data_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputDataConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputDataConfig block(s) allowed")]
    public List<AwsTranscribeLanguageModelInputDataConfigBlock>? InputDataConfig
    {
        get => GetProperty<List<AwsTranscribeLanguageModelInputDataConfigBlock>>("input_data_config");
        set => this.WithProperty("input_data_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsTranscribeLanguageModelTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsTranscribeLanguageModelTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
