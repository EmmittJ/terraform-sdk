using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_managed_database.
/// </summary>
public class AzurermMssqlManagedDatabaseDataSource : TerraformDataSource
{
    public AzurermMssqlManagedDatabaseDataSource(string name) : base("azurerm_mssql_managed_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("long_term_retention_policy");
        SetOutput("managed_instance_name");
        SetOutput("point_in_time_restore");
        SetOutput("resource_group_name");
        SetOutput("short_term_retention_days");
        SetOutput("id");
        SetOutput("managed_instance_id");
        SetOutput("name");
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
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformProperty<string> ManagedInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_instance_id");
        set => SetProperty("managed_instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The long_term_retention_policy attribute.
    /// </summary>
    public TerraformExpression LongTermRetentionPolicy => this["long_term_retention_policy"];

    /// <summary>
    /// The managed_instance_name attribute.
    /// </summary>
    public TerraformExpression ManagedInstanceName => this["managed_instance_name"];

    /// <summary>
    /// The point_in_time_restore attribute.
    /// </summary>
    public TerraformExpression PointInTimeRestore => this["point_in_time_restore"];

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformExpression ResourceGroupName => this["resource_group_name"];

    /// <summary>
    /// The short_term_retention_days attribute.
    /// </summary>
    public TerraformExpression ShortTermRetentionDays => this["short_term_retention_days"];

}
