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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    [TerraformPropertyName("data_set_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The column_groups attribute.
    /// </summary>
    [TerraformPropertyName("column_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ColumnGroups => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "column_groups");

    /// <summary>
    /// The column_level_permission_rules attribute.
    /// </summary>
    [TerraformPropertyName("column_level_permission_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ColumnLevelPermissionRules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "column_level_permission_rules");

    /// <summary>
    /// The data_set_usage_configuration attribute.
    /// </summary>
    [TerraformPropertyName("data_set_usage_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataSetUsageConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_set_usage_configuration");

    /// <summary>
    /// The field_folders attribute.
    /// </summary>
    [TerraformPropertyName("field_folders")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> FieldFolders => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "field_folders");

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    [TerraformPropertyName("import_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImportMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "import_mode");

    /// <summary>
    /// The logical_table_map attribute.
    /// </summary>
    [TerraformPropertyName("logical_table_map")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LogicalTableMap => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "logical_table_map");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Permissions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "permissions");

    /// <summary>
    /// The physical_table_map attribute.
    /// </summary>
    [TerraformPropertyName("physical_table_map")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> PhysicalTableMap => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "physical_table_map");

    /// <summary>
    /// The row_level_permission_data_set attribute.
    /// </summary>
    [TerraformPropertyName("row_level_permission_data_set")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RowLevelPermissionDataSet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "row_level_permission_data_set");

    /// <summary>
    /// The row_level_permission_tag_configuration attribute.
    /// </summary>
    [TerraformPropertyName("row_level_permission_tag_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RowLevelPermissionTagConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "row_level_permission_tag_configuration");

}
