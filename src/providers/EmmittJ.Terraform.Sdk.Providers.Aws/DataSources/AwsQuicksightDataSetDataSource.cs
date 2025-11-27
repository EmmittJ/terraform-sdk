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
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformValue<string> DataSetId
    {
        get => new TerraformReference<string>(this, "data_set_id");
        set => SetArgument("data_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The column_groups attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ColumnGroups
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "column_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The column_level_permission_rules attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ColumnLevelPermissionRules
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "column_level_permission_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_set_usage_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataSetUsageConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_set_usage_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The field_folders attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> FieldFolders
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "field_folders").ResolveNodes(ctx));
    }

    /// <summary>
    /// The import_mode attribute.
    /// </summary>
    public TerraformValue<string> ImportMode
    {
        get => new TerraformReference<string>(this, "import_mode");
    }

    /// <summary>
    /// The logical_table_map attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogicalTableMap
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "logical_table_map").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Permissions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The physical_table_map attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> PhysicalTableMap
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "physical_table_map").ResolveNodes(ctx));
    }

    /// <summary>
    /// The row_level_permission_data_set attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RowLevelPermissionDataSet
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "row_level_permission_data_set").ResolveNodes(ctx));
    }

    /// <summary>
    /// The row_level_permission_tag_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RowLevelPermissionTagConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "row_level_permission_tag_configuration").ResolveNodes(ctx));
    }

}
