using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_data_set.
/// </summary>
public class AwsQuicksightDataSetDataSource : TerraformDataSource
{
    public AwsQuicksightDataSetDataSource(string name) : base("aws_quicksight_data_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("column_groups");
        this.DeclareOutput("column_level_permission_rules");
        this.DeclareOutput("data_set_usage_configuration");
        this.DeclareOutput("field_folders");
        this.DeclareOutput("import_mode");
        this.DeclareOutput("logical_table_map");
        this.DeclareOutput("name");
        this.DeclareOutput("permissions");
        this.DeclareOutput("physical_table_map");
        this.DeclareOutput("row_level_permission_data_set");
        this.DeclareOutput("row_level_permission_tag_configuration");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    public string? DataSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_set_id")?.Value;
        set => this.WithProperty("data_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The column_groups attribute.
    /// </summary>
    public TerraformExpression ColumnGroups => this["column_groups"];

    /// <summary>
    /// The column_level_permission_rules attribute.
    /// </summary>
    public TerraformExpression ColumnLevelPermissionRules => this["column_level_permission_rules"];

    /// <summary>
    /// The data_set_usage_configuration attribute.
    /// </summary>
    public TerraformExpression DataSetUsageConfiguration => this["data_set_usage_configuration"];

    /// <summary>
    /// The field_folders attribute.
    /// </summary>
    public TerraformExpression FieldFolders => this["field_folders"];

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    public TerraformExpression ImportMode => this["import_mode"];

    /// <summary>
    /// The logical_table_map attribute.
    /// </summary>
    public TerraformExpression LogicalTableMap => this["logical_table_map"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

    /// <summary>
    /// The physical_table_map attribute.
    /// </summary>
    public TerraformExpression PhysicalTableMap => this["physical_table_map"];

    /// <summary>
    /// The row_level_permission_data_set attribute.
    /// </summary>
    public TerraformExpression RowLevelPermissionDataSet => this["row_level_permission_data_set"];

    /// <summary>
    /// The row_level_permission_tag_configuration attribute.
    /// </summary>
    public TerraformExpression RowLevelPermissionTagConfiguration => this["row_level_permission_tag_configuration"];

}
