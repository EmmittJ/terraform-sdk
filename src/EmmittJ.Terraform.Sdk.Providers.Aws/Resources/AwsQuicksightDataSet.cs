using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for column_groups in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnGroupsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for column_level_permission_rules in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetColumnLevelPermissionRulesBlock : TerraformBlock
{
    /// <summary>
    /// The column_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ColumnNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("column_names");
        set => WithProperty("column_names", value);
    }

    /// <summary>
    /// The principals attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Principals
    {
        get => GetProperty<List<TerraformProperty<string>>>("principals");
        set => WithProperty("principals", value);
    }

}

/// <summary>
/// Block type for data_set_usage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetDataSetUsageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The disable_use_as_direct_query_source attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableUseAsDirectQuerySource
    {
        get => GetProperty<TerraformProperty<bool>>("disable_use_as_direct_query_source");
        set => WithProperty("disable_use_as_direct_query_source", value);
    }

    /// <summary>
    /// The disable_use_as_imported_source attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableUseAsImportedSource
    {
        get => GetProperty<TerraformProperty<bool>>("disable_use_as_imported_source");
        set => WithProperty("disable_use_as_imported_source", value);
    }

}

/// <summary>
/// Block type for field_folders in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetFieldFoldersBlock : TerraformBlock
{
    /// <summary>
    /// The columns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Columns
    {
        get => GetProperty<List<TerraformProperty<string>>>("columns");
        set => WithProperty("columns", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The field_folders_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldFoldersId is required")]
    public required TerraformProperty<string> FieldFoldersId
    {
        get => GetProperty<TerraformProperty<string>>("field_folders_id");
        set => WithProperty("field_folders_id", value);
    }

}

/// <summary>
/// Block type for logical_table_map in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetLogicalTableMapBlock : TerraformBlock
{
    /// <summary>
    /// The alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformProperty<string> Alias
    {
        get => GetProperty<TerraformProperty<string>>("alias");
        set => WithProperty("alias", value);
    }

    /// <summary>
    /// The logical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicalTableMapId is required")]
    public required TerraformProperty<string> LogicalTableMapId
    {
        get => GetProperty<TerraformProperty<string>>("logical_table_map_id");
        set => WithProperty("logical_table_map_id", value);
    }

}

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public HashSet<TerraformProperty<string>>? Actions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("actions");
        set => WithProperty("actions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetProperty<TerraformProperty<string>>("principal");
        set => WithProperty("principal", value);
    }

}

/// <summary>
/// Block type for physical_table_map in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightDataSetPhysicalTableMapBlock : TerraformBlock
{
    /// <summary>
    /// The physical_table_map_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalTableMapId is required")]
    public required TerraformProperty<string> PhysicalTableMapId
    {
        get => GetProperty<TerraformProperty<string>>("physical_table_map_id");
        set => WithProperty("physical_table_map_id", value);
    }

}

/// <summary>
/// Block type for refresh_properties in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRefreshPropertiesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for row_level_permission_data_set in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionDataSetBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

    /// <summary>
    /// The format_version attribute.
    /// </summary>
    public TerraformProperty<string>? FormatVersion
    {
        get => GetProperty<TerraformProperty<string>>("format_version");
        set => WithProperty("format_version", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
    }

    /// <summary>
    /// The permission_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionPolicy is required")]
    public required TerraformProperty<string> PermissionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("permission_policy");
        set => WithProperty("permission_policy", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for row_level_permission_tag_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_data_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsQuicksightDataSet : TerraformResource
{
    public AwsQuicksightDataSet(string name) : base("aws_quicksight_data_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("output_columns");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformProperty<string> DataSetId
    {
        get => GetProperty<TerraformProperty<string>>("data_set_id");
        set => this.WithProperty("data_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMode is required")]
    public required TerraformProperty<string> ImportMode
    {
        get => GetProperty<TerraformProperty<string>>("import_mode");
        set => this.WithProperty("import_mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for column_groups.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 ColumnGroups block(s) allowed")]
    public List<AwsQuicksightDataSetColumnGroupsBlock>? ColumnGroups
    {
        get => GetProperty<List<AwsQuicksightDataSetColumnGroupsBlock>>("column_groups");
        set => this.WithProperty("column_groups", value);
    }

    /// <summary>
    /// Block for column_level_permission_rules.
    /// Nesting mode: list
    /// </summary>
    public List<AwsQuicksightDataSetColumnLevelPermissionRulesBlock>? ColumnLevelPermissionRules
    {
        get => GetProperty<List<AwsQuicksightDataSetColumnLevelPermissionRulesBlock>>("column_level_permission_rules");
        set => this.WithProperty("column_level_permission_rules", value);
    }

    /// <summary>
    /// Block for data_set_usage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSetUsageConfiguration block(s) allowed")]
    public List<AwsQuicksightDataSetDataSetUsageConfigurationBlock>? DataSetUsageConfiguration
    {
        get => GetProperty<List<AwsQuicksightDataSetDataSetUsageConfigurationBlock>>("data_set_usage_configuration");
        set => this.WithProperty("data_set_usage_configuration", value);
    }

    /// <summary>
    /// Block for field_folders.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 FieldFolders block(s) allowed")]
    public HashSet<AwsQuicksightDataSetFieldFoldersBlock>? FieldFolders
    {
        get => GetProperty<HashSet<AwsQuicksightDataSetFieldFoldersBlock>>("field_folders");
        set => this.WithProperty("field_folders", value);
    }

    /// <summary>
    /// Block for logical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 LogicalTableMap block(s) allowed")]
    public HashSet<AwsQuicksightDataSetLogicalTableMapBlock>? LogicalTableMap
    {
        get => GetProperty<HashSet<AwsQuicksightDataSetLogicalTableMapBlock>>("logical_table_map");
        set => this.WithProperty("logical_table_map", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    public HashSet<AwsQuicksightDataSetPermissionsBlock>? Permissions
    {
        get => GetProperty<HashSet<AwsQuicksightDataSetPermissionsBlock>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// Block for physical_table_map.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(32, ErrorMessage = "Maximum 32 PhysicalTableMap block(s) allowed")]
    public HashSet<AwsQuicksightDataSetPhysicalTableMapBlock>? PhysicalTableMap
    {
        get => GetProperty<HashSet<AwsQuicksightDataSetPhysicalTableMapBlock>>("physical_table_map");
        set => this.WithProperty("physical_table_map", value);
    }

    /// <summary>
    /// Block for refresh_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RefreshProperties block(s) allowed")]
    public List<AwsQuicksightDataSetRefreshPropertiesBlock>? RefreshProperties
    {
        get => GetProperty<List<AwsQuicksightDataSetRefreshPropertiesBlock>>("refresh_properties");
        set => this.WithProperty("refresh_properties", value);
    }

    /// <summary>
    /// Block for row_level_permission_data_set.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionDataSet block(s) allowed")]
    public List<AwsQuicksightDataSetRowLevelPermissionDataSetBlock>? RowLevelPermissionDataSet
    {
        get => GetProperty<List<AwsQuicksightDataSetRowLevelPermissionDataSetBlock>>("row_level_permission_data_set");
        set => this.WithProperty("row_level_permission_data_set", value);
    }

    /// <summary>
    /// Block for row_level_permission_tag_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowLevelPermissionTagConfiguration block(s) allowed")]
    public List<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock>? RowLevelPermissionTagConfiguration
    {
        get => GetProperty<List<AwsQuicksightDataSetRowLevelPermissionTagConfigurationBlock>>("row_level_permission_tag_configuration");
        set => this.WithProperty("row_level_permission_tag_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The output_columns attribute.
    /// </summary>
    public TerraformExpression OutputColumns => this["output_columns"];

}
