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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The retention_period_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_period_in_days");
        set => this.WithProperty("retention_period_in_days", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
