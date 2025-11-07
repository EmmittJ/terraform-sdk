using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_netapp_snapshot_policy.
/// </summary>
public class AzurermNetappSnapshotPolicyDataSource : TerraformDataSource
{
    public AzurermNetappSnapshotPolicyDataSource(string name) : base("azurerm_netapp_snapshot_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("daily_schedule");
        this.DeclareOutput("enabled");
        this.DeclareOutput("hourly_schedule");
        this.DeclareOutput("location");
        this.DeclareOutput("monthly_schedule");
        this.DeclareOutput("tags");
        this.DeclareOutput("weekly_schedule");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformProperty<string>? AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The daily_schedule attribute.
    /// </summary>
    public TerraformExpression DailySchedule => this["daily_schedule"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The hourly_schedule attribute.
    /// </summary>
    public TerraformExpression HourlySchedule => this["hourly_schedule"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The monthly_schedule attribute.
    /// </summary>
    public TerraformExpression MonthlySchedule => this["monthly_schedule"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The weekly_schedule attribute.
    /// </summary>
    public TerraformExpression WeeklySchedule => this["weekly_schedule"];

}
