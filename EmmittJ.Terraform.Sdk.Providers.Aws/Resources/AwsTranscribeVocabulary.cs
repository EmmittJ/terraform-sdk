using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transcribe_vocabulary resource.
/// </summary>
public class AwsTranscribeVocabulary : TerraformResource
{
    public AwsTranscribeVocabulary(string name) : base("aws_transcribe_vocabulary", name)
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
    /// The phrases attribute.
    /// </summary>
    public List<string>? Phrases
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("phrases")?.Value;
        set => this.WithProperty("phrases", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The vocabulary_file_uri attribute.
    /// </summary>
    public string? VocabularyFileUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vocabulary_file_uri")?.Value;
        set => this.WithProperty("vocabulary_file_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vocabulary_name attribute.
    /// </summary>
    public string? VocabularyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vocabulary_name")?.Value;
        set => this.WithProperty("vocabulary_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
