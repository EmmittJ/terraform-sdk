using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKustoScriptTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_script resource.
/// </summary>
public partial class AzurermKustoScript : TerraformResource
{
    public AzurermKustoScript(string name) : base("azurerm_kusto_script", name)
    {
    }

    /// <summary>
    /// The continue_on_errors_enabled attribute.
    /// </summary>
    [TerraformProperty("continue_on_errors_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContinueOnErrorsEnabled { get; set; }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    [TerraformProperty("database_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseId { get; set; }

    /// <summary>
    /// The force_an_update_when_value_changed attribute.
    /// </summary>
    [TerraformProperty("force_an_update_when_value_changed")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ForceAnUpdateWhenValueChanged { get; set; }

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
    /// The sas_token attribute.
    /// </summary>
    [TerraformProperty("sas_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SasToken { get; set; }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    [TerraformProperty("script_content")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScriptContent { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Url { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKustoScriptTimeoutsBlock Timeouts { get; set; } = new();

}
