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
    public string? AutonomousDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autonomous_database_id")?.Value;
        set => this.WithProperty("autonomous_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The autonomous_database_backups attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabaseBackups => this["autonomous_database_backups"];

}
