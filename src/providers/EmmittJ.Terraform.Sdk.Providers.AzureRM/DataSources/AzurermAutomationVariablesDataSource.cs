using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationVariablesDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AutomationAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAutomationVariablesDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The bool attribute.
    /// </summary>
    [TerraformPropertyName("bool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Bool => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bool");

    /// <summary>
    /// The datetime attribute.
    /// </summary>
    [TerraformPropertyName("datetime")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Datetime => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "datetime");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Encrypted => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The int attribute.
    /// </summary>
    [TerraformPropertyName("int")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Int => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "int");

    /// <summary>
    /// The null attribute.
    /// </summary>
    [TerraformPropertyName("null")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Null => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "null");

    /// <summary>
    /// The object attribute.
    /// </summary>
    [TerraformPropertyName("object")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Object => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "object");

    /// <summary>
    /// The string attribute.
    /// </summary>
    [TerraformPropertyName("string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> String => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "string");

}
