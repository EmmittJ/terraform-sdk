using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transcribe_vocabulary_filter Terraform resource.
/// Manages a aws_transcribe_vocabulary_filter resource.
/// </summary>
public partial class AwsTranscribeVocabularyFilter(string name) : TerraformResource("aws_transcribe_vocabulary_filter", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vocabulary_filter_file_uri attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyFilterFileUri
    {
        get => GetArgument<TerraformValue<string>>("vocabulary_filter_file_uri");
        set => SetArgument("vocabulary_filter_file_uri", value);
    }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VocabularyFilterName is required")]
    public required TerraformValue<string> VocabularyFilterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("vocabulary_filter_name");
        set => SetArgument("vocabulary_filter_name", value);
    }

    /// <summary>
    /// The words attribute.
    /// </summary>
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The download_uri attribute.
    /// </summary>
    public TerraformValue<string> DownloadUri
        => CreateReference("download_uri");

}
