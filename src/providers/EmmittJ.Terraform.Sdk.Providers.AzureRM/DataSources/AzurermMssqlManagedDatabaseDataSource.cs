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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("long_term_retention_policy");
        this.WithOutput("managed_instance_name");
        this.WithOutput("point_in_time_restore");
        this.WithOutput("resource_group_name");
        this.WithOutput("short_term_retention_days");
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
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformProperty<string> ManagedInstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("managed_instance_id");
        set => this.WithProperty("managed_instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlManagedDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
