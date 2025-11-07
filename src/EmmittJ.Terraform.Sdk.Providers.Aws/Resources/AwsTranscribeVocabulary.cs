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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The phrases attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Phrases
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("phrases");
        set => this.WithProperty("phrases", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vocabulary_file_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VocabularyFileUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vocabulary_file_uri");
        set => this.WithProperty("vocabulary_file_uri", value);
    }

    /// <summary>
    /// The vocabulary_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VocabularyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vocabulary_name");
        set => this.WithProperty("vocabulary_name", value);
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
