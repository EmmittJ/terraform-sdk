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
    public TerraformLiteralProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_set_id");
        set => this.WithProperty("data_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
