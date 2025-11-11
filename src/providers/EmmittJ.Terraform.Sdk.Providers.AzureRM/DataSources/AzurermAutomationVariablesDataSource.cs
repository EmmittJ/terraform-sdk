using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAutomationVariablesDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_automation_variables.
/// </summary>
public partial class AzurermAutomationVariablesDataSource : TerraformDataSource
{
    public AzurermAutomationVariablesDataSource(string name) : base("azurerm_automation_variables", name)
    {
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformProperty("automation_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutomationAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermAutomationVariablesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The bool attribute.
    /// </summary>
    [TerraformProperty("bool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Bool { get; }

    /// <summary>
    /// The datetime attribute.
    /// </summary>
    [TerraformProperty("datetime")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Datetime { get; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Encrypted { get; }

    /// <summary>
    /// The int attribute.
    /// </summary>
    [TerraformProperty("int")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Int { get; }

    /// <summary>
    /// The null attribute.
    /// </summary>
    [TerraformProperty("null")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Null { get; }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [TerraformProperty("object")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Object { get; }

    /// <summary>
    /// The string attribute.
    /// </summary>
    [TerraformProperty("string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> String { get; }

}
