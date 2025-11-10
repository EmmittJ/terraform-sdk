using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappBackupPolicyDataSourceTimeoutsBlock : TerraformBlock
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
        this.WithOutput("daily_backups_to_keep");
        this.WithOutput("enabled");
        this.WithOutput("location");
        this.WithOutput("monthly_backups_to_keep");
        this.WithOutput("tags");
        this.WithOutput("weekly_backups_to_keep");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_name");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappBackupPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappBackupPolicyDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
