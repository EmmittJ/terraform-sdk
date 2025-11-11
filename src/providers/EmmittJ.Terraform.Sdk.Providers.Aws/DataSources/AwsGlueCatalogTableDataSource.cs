using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_catalog_table.
/// </summary>
public class AwsGlueCatalogTableDataSource : TerraformDataSource
{
    public AwsGlueCatalogTableDataSource(string name) : base("aws_glue_catalog_table", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CatalogId { get; set; } = default!;

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    [TerraformPropertyName("query_as_of_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueryAsOfTime { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The transaction_id attribute.
    /// </summary>
    [TerraformPropertyName("transaction_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TransactionId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Parameters => new TerraformReference(this, "parameters");

    /// <summary>
    /// The partition_index attribute.
    /// </summary>
    [TerraformPropertyName("partition_index")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PartitionIndex => new TerraformReference(this, "partition_index");

    /// <summary>
    /// The partition_keys attribute.
    /// </summary>
    [TerraformPropertyName("partition_keys")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PartitionKeys => new TerraformReference(this, "partition_keys");

    /// <summary>
    /// The retention attribute.
    /// </summary>
    [TerraformPropertyName("retention")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Retention => new TerraformReference(this, "retention");

    /// <summary>
    /// The storage_descriptor attribute.
    /// </summary>
    [TerraformPropertyName("storage_descriptor")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StorageDescriptor => new TerraformReference(this, "storage_descriptor");

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    [TerraformPropertyName("table_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TableType => new TerraformReference(this, "table_type");

    /// <summary>
    /// The target_table attribute.
    /// </summary>
    [TerraformPropertyName("target_table")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TargetTable => new TerraformReference(this, "target_table");

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    [TerraformPropertyName("view_expanded_text")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ViewExpandedText => new TerraformReference(this, "view_expanded_text");

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    [TerraformPropertyName("view_original_text")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ViewOriginalText => new TerraformReference(this, "view_original_text");

}
