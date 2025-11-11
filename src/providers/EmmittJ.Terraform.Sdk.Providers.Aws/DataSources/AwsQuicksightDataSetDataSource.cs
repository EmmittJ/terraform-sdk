using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_data_set.
/// </summary>
public class AwsQuicksightDataSetDataSource : TerraformDataSource
{
    public AwsQuicksightDataSetDataSource(string name) : base("aws_quicksight_data_set", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AwsAccountId { get; set; } = default!;

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    [TerraformPropertyName("data_set_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// The column_groups attribute.
    /// </summary>
    [TerraformPropertyName("column_groups")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ColumnGroups => new TerraformReference(this, "column_groups");

    /// <summary>
    /// The column_level_permission_rules attribute.
    /// </summary>
    [TerraformPropertyName("column_level_permission_rules")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ColumnLevelPermissionRules => new TerraformReference(this, "column_level_permission_rules");

    /// <summary>
    /// The data_set_usage_configuration attribute.
    /// </summary>
    [TerraformPropertyName("data_set_usage_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataSetUsageConfiguration => new TerraformReference(this, "data_set_usage_configuration");

    /// <summary>
    /// The field_folders attribute.
    /// </summary>
    [TerraformPropertyName("field_folders")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> FieldFolders => new TerraformReference(this, "field_folders");

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    [TerraformPropertyName("import_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImportMode => new TerraformReference(this, "import_mode");

    /// <summary>
    /// The logical_table_map attribute.
    /// </summary>
    [TerraformPropertyName("logical_table_map")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LogicalTableMap => new TerraformReference(this, "logical_table_map");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Permissions => new TerraformReference(this, "permissions");

    /// <summary>
    /// The physical_table_map attribute.
    /// </summary>
    [TerraformPropertyName("physical_table_map")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> PhysicalTableMap => new TerraformReference(this, "physical_table_map");

    /// <summary>
    /// The row_level_permission_data_set attribute.
    /// </summary>
    [TerraformPropertyName("row_level_permission_data_set")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RowLevelPermissionDataSet => new TerraformReference(this, "row_level_permission_data_set");

    /// <summary>
    /// The row_level_permission_tag_configuration attribute.
    /// </summary>
    [TerraformPropertyName("row_level_permission_tag_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RowLevelPermissionTagConfiguration => new TerraformReference(this, "row_level_permission_tag_configuration");

}
