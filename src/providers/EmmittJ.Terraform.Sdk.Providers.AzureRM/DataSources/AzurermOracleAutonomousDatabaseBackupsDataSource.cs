using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_autonomous_database_backups.
/// </summary>
public partial class AzurermOracleAutonomousDatabaseBackupsDataSource : TerraformDataSource
{
    public AzurermOracleAutonomousDatabaseBackupsDataSource(string name) : base("azurerm_oracle_autonomous_database_backups", name)
    {
    }

    /// <summary>
    /// The autonomous_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformProperty("autonomous_database_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermOracleAutonomousDatabaseBackupsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The autonomous_database_backups attribute.
    /// </summary>
    [TerraformProperty("autonomous_database_backups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AutonomousDatabaseBackups { get; }

}
