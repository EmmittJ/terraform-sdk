using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_query_suggestions_block_list.
/// </summary>
public partial class AwsKendraQuerySuggestionsBlockListDataSource : TerraformDataSource
{
    public AwsKendraQuerySuggestionsBlockListDataSource(string name) : base("aws_kendra_query_suggestions_block_list", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    [TerraformProperty("index_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IndexId { get; set; }

    /// <summary>
    /// The query_suggestions_block_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuerySuggestionsBlockListId is required")]
    [TerraformProperty("query_suggestions_block_list_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QuerySuggestionsBlockListId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ErrorMessage { get; }

    /// <summary>
    /// The file_size_bytes attribute.
    /// </summary>
    [TerraformProperty("file_size_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> FileSizeBytes { get; }

    /// <summary>
    /// The item_count attribute.
    /// </summary>
    [TerraformProperty("item_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ItemCount { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The source_s3_path attribute.
    /// </summary>
    [TerraformProperty("source_s3_path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SourceS3Path { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

}
