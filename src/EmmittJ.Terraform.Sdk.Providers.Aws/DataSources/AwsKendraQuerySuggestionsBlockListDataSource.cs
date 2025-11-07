using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_query_suggestions_block_list.
/// </summary>
public class AwsKendraQuerySuggestionsBlockListDataSource : TerraformDataSource
{
    public AwsKendraQuerySuggestionsBlockListDataSource(string name) : base("aws_kendra_query_suggestions_block_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("description");
        this.DeclareOutput("error_message");
        this.DeclareOutput("file_size_bytes");
        this.DeclareOutput("item_count");
        this.DeclareOutput("name");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("source_s3_path");
        this.DeclareOutput("status");
        this.DeclareOutput("updated_at");
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
    /// The index_id attribute.
    /// </summary>
    public TerraformProperty<string>? IndexId
    {
        get => GetProperty<TerraformProperty<string>>("index_id");
        set => this.WithProperty("index_id", value);
    }

    /// <summary>
    /// The query_suggestions_block_list_id attribute.
    /// </summary>
    public TerraformProperty<string>? QuerySuggestionsBlockListId
    {
        get => GetProperty<TerraformProperty<string>>("query_suggestions_block_list_id");
        set => this.WithProperty("query_suggestions_block_list_id", value);
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
    /// The item_count attribute.
    /// </summary>
    public TerraformExpression ItemCount => this["item_count"];

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
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
