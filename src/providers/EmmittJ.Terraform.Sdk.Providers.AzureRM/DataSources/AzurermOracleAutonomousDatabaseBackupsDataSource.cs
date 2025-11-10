using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_oracle_autonomous_database_backups.
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupsDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupsDataSource(string name) : base("azurerm_oracle_autonomous_database_backups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("autonomous_database_backups");
        SetOutput("autonomous_database_id");
        SetOutput("id");
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformProperty<string> AutonomousDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autonomous_database_id");
        set => SetProperty("autonomous_database_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The autonomous_database_backups attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabaseBackups => this["autonomous_database_backups"];

}
