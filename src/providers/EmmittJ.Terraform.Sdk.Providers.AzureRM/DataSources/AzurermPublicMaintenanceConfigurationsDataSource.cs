using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicMaintenanceConfigurationsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_public_maintenance_configurations.
/// </summary>
public class AzurermPublicMaintenanceConfigurationsDataSource : TerraformDataSource
{
    public AzurermPublicMaintenanceConfigurationsDataSource(string name) : base("azurerm_public_maintenance_configurations", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The recur_every attribute.
    /// </summary>
    [TerraformPropertyName("recur_every")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RecurEvery { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPublicMaintenanceConfigurationsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The configs attribute.
    /// </summary>
    [TerraformPropertyName("configs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Configs => new TerraformReference(this, "configs");

}
