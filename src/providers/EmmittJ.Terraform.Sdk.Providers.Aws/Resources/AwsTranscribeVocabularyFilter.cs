using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transcribe_vocabulary_filter resource.
/// </summary>
public partial class AwsTranscribeVocabularyFilter : TerraformResource
{
    public AwsTranscribeVocabularyFilter(string name) : base("aws_transcribe_vocabulary_filter", name)
    {
    }

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
    /// The vocabulary_filter_file_uri attribute.
    /// </summary>
    [TerraformProperty("vocabulary_filter_file_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VocabularyFilterFileUri { get; set; }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VocabularyFilterName is required")]
    [TerraformProperty("vocabulary_filter_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VocabularyFilterName { get; set; }

    /// <summary>
    /// The words attribute.
    /// </summary>
    [TerraformProperty("words")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Words { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The download_uri attribute.
    /// </summary>
    [TerraformProperty("download_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DownloadUri { get; }

}
