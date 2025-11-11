using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleAdbsCharacterSetsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_adbs_character_sets.
/// </summary>
public class AzurermOracleAdbsCharacterSetsDataSource : TerraformDataSource
{
    public AzurermOracleAdbsCharacterSetsDataSource(string name) : base("azurerm_oracle_adbs_character_sets", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleAdbsCharacterSetsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The character_sets attribute.
    /// </summary>
    [TerraformPropertyName("character_sets")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CharacterSets => new TerraformReference(this, "character_sets");

}
