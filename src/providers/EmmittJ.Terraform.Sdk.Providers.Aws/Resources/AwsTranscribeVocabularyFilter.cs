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
    /// The vocabulary_filter_file_uri attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyFilterFileUri
    {
        get => new TerraformReference<string>(this, "vocabulary_filter_file_uri");
        set => SetArgument("vocabulary_filter_file_uri", value);
    }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VocabularyFilterName is required")]
    public required TerraformValue<string> VocabularyFilterName
    {
        get => new TerraformReference<string>(this, "vocabulary_filter_name");
        set => SetArgument("vocabulary_filter_name", value);
    }

    /// <summary>
    /// The words attribute.
    /// </summary>
    public TerraformList<string>? Words
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "words").ResolveNodes(ctx));
        set => SetArgument("words", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The download_uri attribute.
    /// </summary>
    public TerraformValue<string> DownloadUri
    {
        get => new TerraformReference<string>(this, "download_uri");
    }

}
