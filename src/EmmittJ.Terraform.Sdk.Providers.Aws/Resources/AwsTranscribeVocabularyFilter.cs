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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public string? LanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_code")?.Value;
        set => this.WithProperty("language_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vocabulary_filter_file_uri attribute.
    /// </summary>
    public string? VocabularyFilterFileUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vocabulary_filter_file_uri")?.Value;
        set => this.WithProperty("vocabulary_filter_file_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    public string? VocabularyFilterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vocabulary_filter_name")?.Value;
        set => this.WithProperty("vocabulary_filter_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The words attribute.
    /// </summary>
    public List<string>? Words
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("words")?.Value;
        set => this.WithProperty("words", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
