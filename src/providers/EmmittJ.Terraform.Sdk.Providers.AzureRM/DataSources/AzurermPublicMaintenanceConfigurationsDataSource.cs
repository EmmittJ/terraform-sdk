using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPublicMaintenanceConfigurationsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_public_maintenance_configurations.
/// </summary>
public partial class AzurermPublicMaintenanceConfigurationsDataSource : TerraformDataSource
{
    public AzurermPublicMaintenanceConfigurationsDataSource(string name) : base("azurerm_public_maintenance_configurations", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    [TerraformProperty("recur_every")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RecurEvery { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPublicMaintenanceConfigurationsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The configs attribute.
    /// </summary>
    [TerraformProperty("configs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Configs { get; }

}
