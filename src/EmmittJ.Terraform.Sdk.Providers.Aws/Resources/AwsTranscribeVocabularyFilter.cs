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
        this.DeclareOutput("arn");
        this.DeclareOutput("download_uri");
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
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vocabulary_filter_file_uri attribute.
    /// </summary>
    public TerraformProperty<string>? VocabularyFilterFileUri
    {
        get => GetProperty<TerraformProperty<string>>("vocabulary_filter_file_uri");
        set => this.WithProperty("vocabulary_filter_file_uri", value);
    }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    public TerraformProperty<string>? VocabularyFilterName
    {
        get => GetProperty<TerraformProperty<string>>("vocabulary_filter_name");
        set => this.WithProperty("vocabulary_filter_name", value);
    }

    /// <summary>
    /// The words attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Words
    {
        get => GetProperty<TerraformProperty<List<string>>>("words");
        set => this.WithProperty("words", value);
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
