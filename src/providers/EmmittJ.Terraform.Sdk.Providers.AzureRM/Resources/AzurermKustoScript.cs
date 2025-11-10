using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoScriptTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_script resource.
/// </summary>
public class AzurermKustoScript : TerraformResource
{
    public AzurermKustoScript(string name) : base("azurerm_kusto_script", name)
    {
    }

    /// <summary>
    /// The continue_on_errors_enabled attribute.
    /// </summary>
    [TerraformPropertyName("continue_on_errors_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContinueOnErrorsEnabled { get; set; }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    [TerraformPropertyName("database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseId { get; set; }

    /// <summary>
    /// The force_an_update_when_value_changed attribute.
    /// </summary>
    [TerraformPropertyName("force_an_update_when_value_changed")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ForceAnUpdateWhenValueChanged { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "force_an_update_when_value_changed");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The sas_token attribute.
    /// </summary>
    [TerraformPropertyName("sas_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SasToken { get; set; }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    [TerraformPropertyName("script_content")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScriptContent { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Url { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKustoScriptTimeoutsBlock>? Timeouts { get; set; } = new();

}
