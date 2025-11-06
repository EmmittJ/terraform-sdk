using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("long_term_retention_policy");
        this.DeclareOutput("managed_instance_name");
        this.DeclareOutput("point_in_time_restore");
        this.DeclareOutput("resource_group_name");
        this.DeclareOutput("short_term_retention_days");
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
    /// The managed_instance_id attribute.
    /// </summary>
    public string? ManagedInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_instance_id")?.Value;
        set => this.WithProperty("managed_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
