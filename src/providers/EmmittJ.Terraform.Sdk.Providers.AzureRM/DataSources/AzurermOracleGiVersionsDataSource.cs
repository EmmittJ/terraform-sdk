using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleGiVersionsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_gi_versions.
/// </summary>
public class AzurermOracleGiVersionsDataSource : TerraformDataSource
{
    public AzurermOracleGiVersionsDataSource(string name) : base("azurerm_oracle_gi_versions", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Filter the versions by system shape. Possible values are &#39;ExaDbXS&#39;, &#39;Exadata.X9M&#39;, and &#39;Exadata.X11M&#39;.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Shape { get; set; }

    /// <summary>
    /// Filter the versions by zone
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleGiVersionsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    [TerraformPropertyName("versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Versions => new TerraformReference(this, "versions");

}
