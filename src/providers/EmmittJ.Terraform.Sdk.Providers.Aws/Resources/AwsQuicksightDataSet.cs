using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for column_groups in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSetColumnGroupsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for column_level_permission_rules in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSetColumnLevelPermissionRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// The column_names attribute.
    /// </summary>
    [TerraformProperty("column_names")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ColumnNames { get; set; }

    /// <summary>
    /// The principals attribute.
    /// </summary>
    [TerraformProperty("principals")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Principals { get; set; }

}

/// <summary>
/// Block type for data_set_usage_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSetDataSetUsageConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The disable_use_as_direct_query_source attribute.
    /// </summary>
    [TerraformProperty("disable_use_as_direct_query_source")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DisableUseAsDirectQuerySource { get; set; }

    /// <summary>
    /// The disable_use_as_imported_source attribute.
    /// </summary>
    [TerraformProperty("disable_use_as_imported_source")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DisableUseAsImportedSource { get; set; }

}

/// <summary>
/// Block type for field_folders in .
/// Nesting mode: set
/// </summary>
public partial class AwsQuicksightDataSetFieldFoldersBlock : TerraformBlockBase
{
    /// <summary>
    /// The columns attribute.
    /// </summary>
    [TerraformProperty("columns")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Columns { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The field_folders_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldFoldersId is required")]
    [TerraformProperty("field_folders_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FieldFoldersId { get; set; }

}

/// <summary>
/// Block type for logical_table_map in .
/// Nesting mode: set
/// </summary>
public partial class AwsQuicksightDataSetLogicalTableMapBlock : TerraformBlockBase
{
    /// <summary>
    /// The alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    [TerraformProperty("alias")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Alias { get; set; }

    /// <summary>
    /// The logical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicalTableMapId is required")]
    [TerraformProperty("logical_table_map_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogicalTableMapId { get; set; }

}

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public partial class AwsQuicksightDataSetPermissionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformProperty("actions")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Actions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for physical_table_map in .
/// Nesting mode: set
/// </summary>
public partial class AwsQuicksightDataSetPhysicalTableMapBlock : TerraformBlockBase
{
    /// <summary>
    /// The physical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalTableMapId is required")]
    [TerraformProperty("physical_table_map_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PhysicalTableMapId { get; set; }

}

/// <summary>
/// Block type for refresh_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSetRefreshPropertiesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for row_level_permission_data_set in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSetRowLevelPermissionDataSetBlock : TerraformBlockBase
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The format_version attribute.
    /// </summary>
    [TerraformProperty("format_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FormatVersion { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Namespace { get; set; }

    /// <summary>
    /// The permission_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionPolicy is required")]
    [TerraformProperty("permission_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PermissionPolicy { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Block type for row_level_permission_tag_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_data_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsQuicksightDataSet : TerraformResource
{
    public AwsQuicksightDataSet(string name) : base("aws_quicksight_data_set", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    [TerraformProperty("data_set_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataSetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMode is required")]
    [TerraformProperty("import_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ImportMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for column_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 ColumnGroups block(s) allowed")]
    [TerraformProperty("column_groups")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetColumnGroupsBlock>>? ColumnGroups { get; set; }

    /// <summary>
    /// Block for column_level_permission_rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("column_level_permission_rules")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetColumnLevelPermissionRulesBlock>>? ColumnLevelPermissionRules { get; set; }

    /// <summary>
    /// Block for data_set_usage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSetUsageConfiguration block(s) allowed")]
    [TerraformProperty("data_set_usage_configuration")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetDataSetUsageConfigurationBlock>>? DataSetUsageConfiguration { get; set; }

    /// <summary>
    /// Block for field_folders.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 FieldFolders block(s) allowed")]
    [TerraformProperty("field_folders")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetFieldFoldersBlock>>? FieldFolders { get; set; }

    /// <summary>
    /// Block for logical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 LogicalTableMap block(s) allowed")]
    [TerraformProperty("logical_table_map")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetLogicalTableMapBlock>>? LogicalTableMap { get; set; }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    [TerraformProperty("permissions")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetPermissionsBlock>>? Permissions { get; set; }

    /// <summary>
    /// Block for physical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(32, ErrorMessage = "Maximum 32 PhysicalTableMap block(s) allowed")]
    [TerraformProperty("physical_table_map")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetPhysicalTableMapBlock>>? PhysicalTableMap { get; set; }

    /// <summary>
    /// Block for refresh_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RefreshProperties block(s) allowed")]
    [TerraformProperty("refresh_properties")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRefreshPropertiesBlock>>? RefreshProperties { get; set; }

    /// <summary>
    /// Block for row_level_permission_data_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionDataSet block(s) allowed")]
    [TerraformProperty("row_level_permission_data_set")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRowLevelPermissionDataSetBlock>>? RowLevelPermissionDataSet { get; set; }

    /// <summary>
    /// Block for row_level_permission_tag_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionTagConfiguration block(s) allowed")]
    [TerraformProperty("row_level_permission_tag_configuration")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock>>? RowLevelPermissionTagConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The output_columns attribute.
    /// </summary>
    [TerraformProperty("output_columns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> OutputColumns { get; }

}
