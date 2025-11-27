using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kendra_query_suggestions_block_list Terraform data source.
/// Retrieves information about a aws_kendra_query_suggestions_block_list.
/// </summary>
public partial class AwsKendraQuerySuggestionsBlockListDataSource(string name) : TerraformDataSource("aws_kendra_query_suggestions_block_list", name)
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
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    public required TerraformValue<string> IndexId
    {
        get => new TerraformReference<string>(this, "index_id");
        set => SetArgument("index_id", value);
    }

    /// <summary>
    /// The query_suggestions_block_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuerySuggestionsBlockListId is required")]
    public required TerraformValue<string> QuerySuggestionsBlockListId
    {
        get => new TerraformReference<string>(this, "query_suggestions_block_list_id");
        set => SetArgument("query_suggestions_block_list_id", value);
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
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
    {
        get => new TerraformReference<string>(this, "error_message");
    }

    /// <summary>
    /// The file_size_bytes attribute.
    /// </summary>
    public TerraformValue<double> FileSizeBytes
    {
        get => new TerraformReference<double>(this, "file_size_bytes");
    }

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    public TerraformValue<double> ItemCount
    {
        get => new TerraformReference<double>(this, "item_count");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
    }

    /// <summary>
    /// The source_s3_path attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceS3Path
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source_s3_path").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
    {
        get => new TerraformReference<string>(this, "updated_at");
    }

}
