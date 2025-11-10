using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for column_groups in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnGroupsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for column_level_permission_rules in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnLevelPermissionRulesBlock : ITerraformBlock
{
    /// <summary>
    /// The column_names attribute.
    /// </summary>
    [TerraformPropertyName("column_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ColumnNames { get; set; }

    /// <summary>
    /// The principals attribute.
    /// </summary>
    [TerraformPropertyName("principals")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Principals { get; set; }

}

/// <summary>
/// Block type for data_set_usage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetDataSetUsageConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The disable_use_as_direct_query_source attribute.
    /// </summary>
    [TerraformPropertyName("disable_use_as_direct_query_source")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisableUseAsDirectQuerySource { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "disable_use_as_direct_query_source");

    /// <summary>
    /// The disable_use_as_imported_source attribute.
    /// </summary>
    [TerraformPropertyName("disable_use_as_imported_source")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DisableUseAsImportedSource { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "disable_use_as_imported_source");

}

/// <summary>
/// Block type for field_folders in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetFieldFoldersBlock : ITerraformBlock
{
    /// <summary>
    /// The columns attribute.
    /// </summary>
    [TerraformPropertyName("columns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Columns { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The field_folders_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldFoldersId is required")]
    [TerraformPropertyName("field_folders_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FieldFoldersId { get; set; }

}

/// <summary>
/// Block type for logical_table_map in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlock : ITerraformBlock
{
    /// <summary>
    /// The alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    [TerraformPropertyName("alias")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Alias { get; set; }

    /// <summary>
    /// The logical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicalTableMapId is required")]
    [TerraformPropertyName("logical_table_map_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogicalTableMapId { get; set; }

}

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformPropertyName("actions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Actions { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformPropertyName("principal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Principal { get; set; }

}

/// <summary>
/// Block type for physical_table_map in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlock : ITerraformBlock
{
    /// <summary>
    /// The physical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalTableMapId is required")]
    [TerraformPropertyName("physical_table_map_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PhysicalTableMapId { get; set; }

}

/// <summary>
/// Block type for refresh_properties in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRefreshPropertiesBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for row_level_permission_data_set in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionDataSetBlock : ITerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The format_version attribute.
    /// </summary>
    [TerraformPropertyName("format_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FormatVersion { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Namespace { get; set; }

    /// <summary>
    /// The permission_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionPolicy is required")]
    [TerraformPropertyName("permission_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PermissionPolicy { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

}

/// <summary>
/// Block type for row_level_permission_tag_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

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
    /// The import_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMode is required")]
    [TerraformPropertyName("import_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ImportMode { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for column_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 ColumnGroups block(s) allowed")]
    [TerraformPropertyName("column_groups")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetColumnGroupsBlock>>? ColumnGroups { get; set; } = new();

    /// <summary>
    /// Block for column_level_permission_rules.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("column_level_permission_rules")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetColumnLevelPermissionRulesBlock>>? ColumnLevelPermissionRules { get; set; } = new();

    /// <summary>
    /// Block for data_set_usage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSetUsageConfiguration block(s) allowed")]
    [TerraformPropertyName("data_set_usage_configuration")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetDataSetUsageConfigurationBlock>>? DataSetUsageConfiguration { get; set; } = new();

    /// <summary>
    /// Block for field_folders.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 FieldFolders block(s) allowed")]
    [TerraformPropertyName("field_folders")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetFieldFoldersBlock>>? FieldFolders { get; set; } = new();

    /// <summary>
    /// Block for logical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 LogicalTableMap block(s) allowed")]
    [TerraformPropertyName("logical_table_map")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetLogicalTableMapBlock>>? LogicalTableMap { get; set; } = new();

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    [TerraformPropertyName("permissions")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetPermissionsBlock>>? Permissions { get; set; } = new();

    /// <summary>
    /// Block for physical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(32, ErrorMessage = "Maximum 32 PhysicalTableMap block(s) allowed")]
    [TerraformPropertyName("physical_table_map")]
    public TerraformSet<TerraformBlock<AwsQuicksightDataSetPhysicalTableMapBlock>>? PhysicalTableMap { get; set; } = new();

    /// <summary>
    /// Block for refresh_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RefreshProperties block(s) allowed")]
    [TerraformPropertyName("refresh_properties")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRefreshPropertiesBlock>>? RefreshProperties { get; set; } = new();

    /// <summary>
    /// Block for row_level_permission_data_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionDataSet block(s) allowed")]
    [TerraformPropertyName("row_level_permission_data_set")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRowLevelPermissionDataSetBlock>>? RowLevelPermissionDataSet { get; set; } = new();

    /// <summary>
    /// Block for row_level_permission_tag_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionTagConfiguration block(s) allowed")]
    [TerraformPropertyName("row_level_permission_tag_configuration")]
    public TerraformList<TerraformBlock<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock>>? RowLevelPermissionTagConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The output_columns attribute.
    /// </summary>
    [TerraformPropertyName("output_columns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OutputColumns => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "output_columns");

}
