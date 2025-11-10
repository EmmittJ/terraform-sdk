using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_thesaurus.
/// </summary>
public class AwsKendraThesaurusDataSource : TerraformDataSource
{
    public AwsKendraThesaurusDataSource(string name) : base("aws_kendra_thesaurus", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("description");
        SetOutput("error_message");
        SetOutput("file_size_bytes");
        SetOutput("name");
        SetOutput("role_arn");
        SetOutput("source_s3_path");
        SetOutput("status");
        SetOutput("synonym_rule_count");
        SetOutput("term_count");
        SetOutput("updated_at");
        SetOutput("id");
        SetOutput("index_id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("thesaurus_id");
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
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    public required TerraformProperty<string> IndexId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("index_id");
        set => SetProperty("index_id", value);
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
    /// The thesaurus_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThesaurusId is required")]
    public required TerraformProperty<string> ThesaurusId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("thesaurus_id");
        set => SetProperty("thesaurus_id", value);
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
    /// The file_size_bytes attribute.
    /// </summary>
    public TerraformExpression FileSizeBytes => this["file_size_bytes"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The source_s3_path attribute.
    /// </summary>
    public TerraformExpression SourceS3Path => this["source_s3_path"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The synonym_rule_count attribute.
    /// </summary>
    public TerraformExpression SynonymRuleCount => this["synonym_rule_count"];

    /// <summary>
    /// The term_count attribute.
    /// </summary>
    public TerraformExpression TermCount => this["term_count"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
