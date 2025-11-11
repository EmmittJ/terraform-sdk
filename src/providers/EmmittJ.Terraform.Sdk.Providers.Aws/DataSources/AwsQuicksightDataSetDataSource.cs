using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_data_set.
/// </summary>
public partial class AwsQuicksightDataSetDataSource : TerraformDataSource
{
    public AwsQuicksightDataSetDataSource(string name) : base("aws_quicksight_data_set", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    [TerraformProperty("data_set_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The column_groups attribute.
    /// </summary>
    [TerraformProperty("column_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ColumnGroups { get; }

    /// <summary>
    /// The column_level_permission_rules attribute.
    /// </summary>
    [TerraformProperty("column_level_permission_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ColumnLevelPermissionRules { get; }

    /// <summary>
    /// The data_set_usage_configuration attribute.
    /// </summary>
    [TerraformProperty("data_set_usage_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataSetUsageConfiguration { get; }

    /// <summary>
    /// The field_folders attribute.
    /// </summary>
    [TerraformProperty("field_folders")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> FieldFolders { get; }

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    [TerraformProperty("import_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImportMode { get; }

    /// <summary>
    /// The logical_table_map attribute.
    /// </summary>
    [TerraformProperty("logical_table_map")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LogicalTableMap { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformProperty("permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Permissions { get; }

    /// <summary>
    /// The physical_table_map attribute.
    /// </summary>
    [TerraformProperty("physical_table_map")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> PhysicalTableMap { get; }

    /// <summary>
    /// The row_level_permission_data_set attribute.
    /// </summary>
    [TerraformProperty("row_level_permission_data_set")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RowLevelPermissionDataSet { get; }

    /// <summary>
    /// The row_level_permission_tag_configuration attribute.
    /// </summary>
    [TerraformProperty("row_level_permission_tag_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RowLevelPermissionTagConfiguration { get; }

}
