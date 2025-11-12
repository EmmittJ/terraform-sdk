using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleAdbsCharacterSetsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_adbs_character_sets.
/// </summary>
public partial class AzurermOracleAdbsCharacterSetsDataSource : TerraformDataSource
{
    public AzurermOracleAdbsCharacterSetsDataSource(string name) : base("azurerm_oracle_adbs_character_sets", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermOracleAdbsCharacterSetsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The character_sets attribute.
    /// </summary>
    [TerraformProperty("character_sets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CharacterSets { get; }

}
