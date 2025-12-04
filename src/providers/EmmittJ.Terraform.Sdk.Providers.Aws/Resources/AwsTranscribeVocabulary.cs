using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsTranscribeVocabulary.
/// Nesting mode: single
/// </summary>
public class AwsTranscribeVocabularyTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_transcribe_vocabulary Terraform resource.
/// Manages a aws_transcribe_vocabulary resource.
/// </summary>
public partial class AwsTranscribeVocabulary(string name) : TerraformResource("aws_transcribe_vocabulary", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The phrases attribute.
    /// </summary>
    public TerraformList<string>? Phrases
    {
        get => GetArgument<TerraformList<string>>("phrases");
        set => SetArgument("phrases", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vocabulary_file_uri attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyFileUri
    {
        get => GetArgument<TerraformValue<string>>("vocabulary_file_uri");
        set => SetArgument("vocabulary_file_uri", value);
    }

    /// <summary>
    /// The vocabulary_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VocabularyName is required")]
    public required TerraformValue<string> VocabularyName
    {
        get => GetArgument<TerraformValue<string>>("vocabulary_name");
        set => SetArgument("vocabulary_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The download_uri attribute.
    /// </summary>
    public TerraformValue<string> DownloadUri
        => AsReference("download_uri");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsTranscribeVocabularyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsTranscribeVocabularyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
