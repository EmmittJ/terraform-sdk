using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("autonomous_database_backups");
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? AutonomousDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("autonomous_database_id");
        set => this.WithProperty("autonomous_database_id", value);
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
    /// The autonomous_database_backups attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabaseBackups => this["autonomous_database_backups"];

}
