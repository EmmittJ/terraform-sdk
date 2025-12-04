using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_data_set Terraform data source.
/// Retrieves information about a aws_quicksight_data_set.
/// </summary>
public partial class AwsQuicksightDataSetDataSource(string name) : TerraformDataSource("aws_quicksight_data_set", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id") ?? AsReference("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformValue<string> DataSetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_set_id");
        set => SetArgument("data_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The column_groups attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ColumnGroups
        => AsReference("column_groups");

    /// <summary>
    /// The column_level_permission_rules attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ColumnLevelPermissionRules
        => AsReference("column_level_permission_rules");

    /// <summary>
    /// The data_set_usage_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataSetUsageConfiguration
        => AsReference("data_set_usage_configuration");

    /// <summary>
    /// The field_folders attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> FieldFolders
        => AsReference("field_folders");

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    public TerraformValue<string> ImportMode
        => AsReference("import_mode");

    /// <summary>
    /// The logical_table_map attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogicalTableMap
        => AsReference("logical_table_map");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Permissions
        => AsReference("permissions");

    /// <summary>
    /// The physical_table_map attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PhysicalTableMap
        => AsReference("physical_table_map");

    /// <summary>
    /// The row_level_permission_data_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RowLevelPermissionDataSet
        => AsReference("row_level_permission_data_set");

    /// <summary>
    /// The row_level_permission_tag_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RowLevelPermissionTagConfiguration
        => AsReference("row_level_permission_tag_configuration");

}
