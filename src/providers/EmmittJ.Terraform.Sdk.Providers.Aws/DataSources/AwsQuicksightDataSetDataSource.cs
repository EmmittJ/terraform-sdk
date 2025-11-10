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
        SetOutput("arn");
        SetOutput("column_groups");
        SetOutput("column_level_permission_rules");
        SetOutput("data_set_usage_configuration");
        SetOutput("field_folders");
        SetOutput("import_mode");
        SetOutput("logical_table_map");
        SetOutput("name");
        SetOutput("permissions");
        SetOutput("physical_table_map");
        SetOutput("row_level_permission_data_set");
        SetOutput("row_level_permission_tag_configuration");
        SetOutput("aws_account_id");
        SetOutput("data_set_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformProperty<string> DataSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_set_id");
        set => SetProperty("data_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
