using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_query_suggestions_block_list.
/// </summary>
public class AwsKendraQuerySuggestionsBlockListDataSource : TerraformDataSource
{
    public AwsKendraQuerySuggestionsBlockListDataSource(string name) : base("aws_kendra_query_suggestions_block_list", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    [TerraformPropertyName("index_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IndexId { get; set; }

    /// <summary>
    /// The query_suggestions_block_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuerySuggestionsBlockListId is required")]
    [TerraformPropertyName("query_suggestions_block_list_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QuerySuggestionsBlockListId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformPropertyName("error_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ErrorMessage => new TerraformReference(this, "error_message");

    /// <summary>
    /// The file_size_bytes attribute.
    /// </summary>
    [TerraformPropertyName("file_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> FileSizeBytes => new TerraformReference(this, "file_size_bytes");

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    [TerraformPropertyName("item_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ItemCount => new TerraformReference(this, "item_count");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The source_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("source_s3_path")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SourceS3Path => new TerraformReference(this, "source_s3_path");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdatedAt => new TerraformReference(this, "updated_at");

}
