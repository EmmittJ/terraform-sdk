using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transcribe_vocabulary_filter resource.
/// </summary>
public class AwsTranscribeVocabularyFilter : TerraformResource
{
    public AwsTranscribeVocabularyFilter(string name) : base("aws_transcribe_vocabulary_filter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("download_uri");
        SetOutput("id");
        SetOutput("language_code");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vocabulary_filter_file_uri");
        SetOutput("vocabulary_filter_name");
        SetOutput("words");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformProperty<string> LanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_code");
        set => SetProperty("language_code", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The vocabulary_filter_file_uri attribute.
    /// </summary>
    public TerraformProperty<string> VocabularyFilterFileUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vocabulary_filter_file_uri");
        set => SetProperty("vocabulary_filter_file_uri", value);
    }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VocabularyFilterName is required")]
    public required TerraformProperty<string> VocabularyFilterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vocabulary_filter_name");
        set => SetProperty("vocabulary_filter_name", value);
    }

    /// <summary>
    /// The words attribute.
    /// </summary>
    public List<TerraformProperty<string>> Words
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("words");
        set => SetProperty("words", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The download_uri attribute.
    /// </summary>
    public TerraformExpression DownloadUri => this["download_uri"];

}
