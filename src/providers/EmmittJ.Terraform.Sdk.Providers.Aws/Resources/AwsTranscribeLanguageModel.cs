using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_data_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsTranscribeLanguageModelInputDataConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessRoleArn is required")]
    [TerraformProperty("data_access_role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataAccessRoleArn { get; set; }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    [TerraformProperty("s3_uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> S3Uri { get; set; }

    /// <summary>
    /// The tuning_data_s3_uri attribute.
    /// </summary>
    [TerraformProperty("tuning_data_s3_uri")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TuningDataS3Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsTranscribeLanguageModelTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_transcribe_language_model resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsTranscribeLanguageModel : TerraformResource
{
    public AwsTranscribeLanguageModel(string name) : base("aws_transcribe_language_model", name)
    {
    }

    /// <summary>
    /// The base_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseModelName is required")]
    [TerraformProperty("base_model_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BaseModelName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    [TerraformProperty("language_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LanguageCode { get; set; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelName is required")]
    [TerraformProperty("model_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ModelName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for input_data_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputDataConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputDataConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputDataConfig block(s) allowed")]
    [TerraformProperty("input_data_config")]
    public TerraformList<TerraformBlock<AwsTranscribeLanguageModelInputDataConfigBlock>>? InputDataConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsTranscribeLanguageModelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
