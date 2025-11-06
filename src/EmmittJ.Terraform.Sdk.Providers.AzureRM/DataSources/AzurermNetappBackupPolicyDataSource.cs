using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_netapp_backup_policy.
/// </summary>
public class AzurermNetappBackupPolicyDataSource : TerraformDataSource
{
    public AzurermNetappBackupPolicyDataSource(string name) : base("azurerm_netapp_backup_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("daily_backups_to_keep");
        this.DeclareOutput("enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("monthly_backups_to_keep");
        this.DeclareOutput("tags");
        this.DeclareOutput("weekly_backups_to_keep");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The daily_backups_to_keep attribute.
    /// </summary>
    public TerraformExpression DailyBackupsToKeep => this["daily_backups_to_keep"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The monthly_backups_to_keep attribute.
    /// </summary>
    public TerraformExpression MonthlyBackupsToKeep => this["monthly_backups_to_keep"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The weekly_backups_to_keep attribute.
    /// </summary>
    public TerraformExpression WeeklyBackupsToKeep => this["weekly_backups_to_keep"];

}
