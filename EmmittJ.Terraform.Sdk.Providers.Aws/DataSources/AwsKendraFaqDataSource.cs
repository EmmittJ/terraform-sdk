using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_faq.
/// </summary>
public class AwsKendraFaqDataSource : TerraformDataSource
{
    public AwsKendraFaqDataSource(string name) : base("aws_kendra_faq", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("description");
        this.DeclareOutput("error_message");
        this.DeclareOutput("file_format");
        this.DeclareOutput("language_code");
        this.DeclareOutput("name");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("s3_path");
        this.DeclareOutput("status");
        this.DeclareOutput("updated_at");
    }

    /// <summary>
    /// The faq_id attribute.
    /// </summary>
    public string? FaqId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("faq_id")?.Value;
        set => this.WithProperty("faq_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The index_id attribute.
    /// </summary>
    public string? IndexId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("index_id")?.Value;
        set => this.WithProperty("index_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformExpression FileFormat => this["file_format"];

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformExpression LanguageCode => this["language_code"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The s3_path attribute.
    /// </summary>
    public TerraformExpression S3Path => this["s3_path"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
