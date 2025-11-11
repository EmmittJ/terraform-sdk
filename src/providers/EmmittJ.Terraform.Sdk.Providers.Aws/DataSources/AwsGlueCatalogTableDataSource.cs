using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_catalog_table.
/// </summary>
public partial class AwsGlueCatalogTableDataSource : TerraformDataSource
{
    public AwsGlueCatalogTableDataSource(string name) : base("aws_glue_catalog_table", name)
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_as_of_time attribute.
    /// </summary>
    [TerraformProperty("query_as_of_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? QueryAsOfTime { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The transaction_id attribute.
    /// </summary>
    [TerraformProperty("transaction_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TransactionId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Owner { get; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Parameters { get; }

    /// <summary>
    /// The partition_index attribute.
    /// </summary>
    [TerraformProperty("partition_index")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PartitionIndex { get; }

    /// <summary>
    /// The partition_keys attribute.
    /// </summary>
    [TerraformProperty("partition_keys")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PartitionKeys { get; }

    /// <summary>
    /// The retention attribute.
    /// </summary>
    [TerraformProperty("retention")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Retention { get; }

    /// <summary>
    /// The storage_descriptor attribute.
    /// </summary>
    [TerraformProperty("storage_descriptor")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StorageDescriptor { get; }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    [TerraformProperty("table_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TableType { get; }

    /// <summary>
    /// The target_table attribute.
    /// </summary>
    [TerraformProperty("target_table")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TargetTable { get; }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    [TerraformProperty("view_expanded_text")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ViewExpandedText { get; }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    [TerraformProperty("view_original_text")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ViewOriginalText { get; }

}
