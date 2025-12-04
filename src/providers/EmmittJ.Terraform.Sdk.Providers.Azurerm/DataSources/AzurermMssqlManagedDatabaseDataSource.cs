using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlManagedDatabaseDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mssql_managed_database Terraform data source.
/// Retrieves information about a azurerm_mssql_managed_database.
/// </summary>
public partial class AzurermMssqlManagedDatabaseDataSource(string name) : TerraformDataSource("azurerm_mssql_managed_database", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => GetArgument<TerraformValue<string>>("managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The long_term_retention_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LongTermRetentionPolicy
        => AsReference("long_term_retention_policy");

    /// <summary>
    /// The managed_instance_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedInstanceName
        => AsReference("managed_instance_name");

    /// <summary>
    /// The point_in_time_restore attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PointInTimeRestore
        => AsReference("point_in_time_restore");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ResourceGroupName
        => AsReference("resource_group_name");

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    public TerraformValue<double> ShortTermRetentionDays
        => AsReference("short_term_retention_days");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
