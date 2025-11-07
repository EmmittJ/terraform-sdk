using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_netapp_backup_policy resource.
/// </summary>
public class AzurermNetappBackupPolicy : TerraformResource
{
    public AzurermNetappBackupPolicy(string name) : base("azurerm_netapp_backup_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The daily_backups_to_keep attribute.
    /// </summary>
    public TerraformProperty<double>? DailyBackupsToKeep
    {
        get => GetProperty<TerraformProperty<double>>("daily_backups_to_keep");
        set => this.WithProperty("daily_backups_to_keep", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The monthly_backups_to_keep attribute.
    /// </summary>
    public TerraformProperty<double>? MonthlyBackupsToKeep
    {
        get => GetProperty<TerraformProperty<double>>("monthly_backups_to_keep");
        set => this.WithProperty("monthly_backups_to_keep", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The weekly_backups_to_keep attribute.
    /// </summary>
    public TerraformProperty<double>? WeeklyBackupsToKeep
    {
        get => GetProperty<TerraformProperty<double>>("weekly_backups_to_keep");
        set => this.WithProperty("weekly_backups_to_keep", value);
    }

}
