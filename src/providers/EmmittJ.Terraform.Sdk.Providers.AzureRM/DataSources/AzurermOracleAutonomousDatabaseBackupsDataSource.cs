using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_backups.
/// </summary>
public class AzurermOracleAutonomousDatabaseBackupsDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupsDataSource(string name) : base("azurerm_oracle_autonomous_database_backups", name)
    {
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformPropertyName("autonomous_database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The autonomous_database_backups attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_database_backups")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutonomousDatabaseBackups => new TerraformReference(this, "autonomous_database_backups");

}
