using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_oracle_autonomous_database_backup resource.
/// </summary>
public class AzurermOracleAutonomousDatabaseBackup : TerraformResource
{
    public AzurermOracleAutonomousDatabaseBackup(string name) : base("azurerm_oracle_autonomous_database_backup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutonomousDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("autonomous_database_id");
        set => this.WithProperty("autonomous_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RetentionPeriodInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period_in_days");
        set => this.WithProperty("retention_period_in_days", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
