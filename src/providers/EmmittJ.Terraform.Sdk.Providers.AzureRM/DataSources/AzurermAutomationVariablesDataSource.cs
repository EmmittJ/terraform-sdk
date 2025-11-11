using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationVariablesDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_automation_variables.
/// </summary>
public class AzurermAutomationVariablesDataSource : TerraformDataSource
{
    public AzurermAutomationVariablesDataSource(string name) : base("azurerm_automation_variables", name)
    {
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformPropertyName("automation_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutomationAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationVariablesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The bool attribute.
    /// </summary>
    [TerraformPropertyName("bool")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Bool => new TerraformReference(this, "bool");

    /// <summary>
    /// The datetime attribute.
    /// </summary>
    [TerraformPropertyName("datetime")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Datetime => new TerraformReference(this, "datetime");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Encrypted => new TerraformReference(this, "encrypted");

    /// <summary>
    /// The int attribute.
    /// </summary>
    [TerraformPropertyName("int")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Int => new TerraformReference(this, "int");

    /// <summary>
    /// The null attribute.
    /// </summary>
    [TerraformPropertyName("null")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Null => new TerraformReference(this, "null");

    /// <summary>
    /// The object attribute.
    /// </summary>
    [TerraformPropertyName("object")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Object => new TerraformReference(this, "object");

    /// <summary>
    /// The string attribute.
    /// </summary>
    [TerraformPropertyName("string")]
    // Output-only attribute - read-only reference
    public TerraformList<object> String => new TerraformReference(this, "string");

}
