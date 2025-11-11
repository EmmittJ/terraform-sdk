using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for column_groups in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnGroupsBlock
{
}

/// <summary>
/// Block type for column_level_permission_rules in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnLevelPermissionRulesBlock
{
    /// <summary>
    /// The column_names attribute.
    /// </summary>
    [TerraformPropertyName("column_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ColumnNames { get; set; }

    /// <summary>
    /// The principals attribute.
    /// </summary>
    [TerraformPropertyName("principals")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Principals { get; set; }

}

/// <summary>
/// Block type for data_set_usage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetDataSetUsageConfigurationBlock
{
    /// <summary>
    /// The disable_use_as_direct_query_source attribute.
    /// </summary>
    [TerraformPropertyName("disable_use_as_direct_query_source")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DisableUseAsDirectQuerySource { get; set; } = default!;

    /// <summary>
    /// The disable_use_as_imported_source attribute.
    /// </summary>
    [TerraformPropertyName("disable_use_as_imported_source")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DisableUseAsImportedSource { get; set; } = default!;

}

/// <summary>
/// Block type for field_folders in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetFieldFoldersBlock
{
    /// <summary>
    /// The columns attribute.
    /// </summary>
    [TerraformPropertyName("columns")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Columns { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The field_folders_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldFoldersId is required")]
    [TerraformPropertyName("field_folders_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FieldFoldersId { get; set; }

}

/// <summary>
/// Block type for logical_table_map in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlock
{
    /// <summary>
    /// The alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    [TerraformPropertyName("alias")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Alias { get; set; }

    /// <summary>
    /// The logical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicalTableMapId is required")]
    [TerraformPropertyName("logical_table_map_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogicalTableMapId { get; set; }

}

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPermissionsBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformPropertyName("actions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Actions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformPropertyName("principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Principal { get; set; }

}

/// <summary>
/// Block type for physical_table_map in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlock
{
    /// <summary>
    /// The physical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalTableMapId is required")]
    [TerraformPropertyName("physical_table_map_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PhysicalTableMapId { get; set; }

}

/// <summary>
/// Block type for refresh_properties in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRefreshPropertiesBlock
{
}

/// <summary>
/// Block type for row_level_permission_data_set in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionDataSetBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The format_version attribute.
    /// </summary>
    [TerraformPropertyName("format_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FormatVersion { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Namespace { get; set; }

    /// <summary>
    /// The permission_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionPolicy is required")]
    [TerraformPropertyName("permission_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PermissionPolicy { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Block type for row_level_permission_tag_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_data_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsQuicksightDataSet : TerraformResource
{
    public AwsQuicksightDataSet(string name) : base("aws_quicksight_data_set", name)
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
    /// The import_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMode is required")]
    [TerraformPropertyName("import_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ImportMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for column_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 ColumnGroups block(s) allowed")]
    [TerraformPropertyName("column_groups")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetColumnGroupsBlock>>? ColumnGroups { get; set; }

    /// <summary>
    /// Block for column_level_permission_rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("column_level_permission_rules")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetColumnLevelPermissionRulesBlock>>? ColumnLevelPermissionRules { get; set; }

    /// <summary>
    /// Block for data_set_usage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSetUsageConfiguration block(s) allowed")]
    [TerraformPropertyName("data_set_usage_configuration")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetDataSetUsageConfigurationBlock>>? DataSetUsageConfiguration { get; set; }

    /// <summary>
    /// Block for field_folders.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 FieldFolders block(s) allowed")]
    [TerraformPropertyName("field_folders")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetFieldFoldersBlock>>? FieldFolders { get; set; }

    /// <summary>
    /// Block for logical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 LogicalTableMap block(s) allowed")]
    [TerraformPropertyName("logical_table_map")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetLogicalTableMapBlock>>? LogicalTableMap { get; set; }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    [TerraformPropertyName("permissions")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetPermissionsBlock>>? Permissions { get; set; }

    /// <summary>
    /// Block for physical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(32, ErrorMessage = "Maximum 32 PhysicalTableMap block(s) allowed")]
    [TerraformPropertyName("physical_table_map")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetPhysicalTableMapBlock>>? PhysicalTableMap { get; set; }

    /// <summary>
    /// Block for refresh_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RefreshProperties block(s) allowed")]
    [TerraformPropertyName("refresh_properties")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRefreshPropertiesBlock>>? RefreshProperties { get; set; }

    /// <summary>
    /// Block for row_level_permission_data_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionDataSet block(s) allowed")]
    [TerraformPropertyName("row_level_permission_data_set")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRowLevelPermissionDataSetBlock>>? RowLevelPermissionDataSet { get; set; }

    /// <summary>
    /// Block for row_level_permission_tag_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionTagConfiguration block(s) allowed")]
    [TerraformPropertyName("row_level_permission_tag_configuration")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock>>? RowLevelPermissionTagConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The output_columns attribute.
    /// </summary>
    [TerraformPropertyName("output_columns")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OutputColumns => new TerraformReference(this, "output_columns");

}
