using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBlueprintDefinitionDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_blueprint_definition.
/// </summary>
public partial class AzurermBlueprintDefinitionDataSource : TerraformDataSource
{
    public AzurermBlueprintDefinitionDataSource(string name) : base("azurerm_blueprint_definition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    [TerraformProperty("scope_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScopeId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermBlueprintDefinitionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The target_scope attribute.
    /// </summary>
    [TerraformProperty("target_scope")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetScope { get; }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    [TerraformProperty("versions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Versions { get; }

}
