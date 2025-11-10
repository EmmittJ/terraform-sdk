using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatadogMonitorSsoConfigurationTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_datadog_monitor_sso_configuration resource.
/// </summary>
public class AzurermDatadogMonitorSsoConfiguration : TerraformResource
{
    public AzurermDatadogMonitorSsoConfiguration(string name) : base("azurerm_datadog_monitor_sso_configuration", name)
    {
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    [TerraformPropertyName("datadog_monitor_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatadogMonitorId { get; set; }

    /// <summary>
    /// The enterprise_application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnterpriseApplicationId is required")]
    [TerraformPropertyName("enterprise_application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EnterpriseApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The single_sign_on attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SingleSignOn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "single_sign_on");

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("single_sign_on_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SingleSignOnEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "single_sign_on_enabled");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDatadogMonitorSsoConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The login_url attribute.
    /// </summary>
    [TerraformPropertyName("login_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoginUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "login_url");

}
