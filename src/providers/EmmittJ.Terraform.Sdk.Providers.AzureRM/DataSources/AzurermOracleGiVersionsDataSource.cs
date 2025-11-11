using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleGiVersionsDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_gi_versions.
/// </summary>
public partial class AzurermOracleGiVersionsDataSource : TerraformDataSource
{
    public AzurermOracleGiVersionsDataSource(string name) : base("azurerm_oracle_gi_versions", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Filter the versions by system shape. Possible values are &#39;ExaDbXS&#39;, &#39;Exadata.X9M&#39;, and &#39;Exadata.X11M&#39;.
    /// </summary>
    [TerraformProperty("shape")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Shape { get; set; }

    /// <summary>
    /// Filter the versions by zone
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOracleGiVersionsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    [TerraformProperty("versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Versions { get; }

}
