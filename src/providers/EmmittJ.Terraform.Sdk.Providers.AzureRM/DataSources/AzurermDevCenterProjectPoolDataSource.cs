using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectPoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_project_pool.
/// </summary>
public class AzurermDevCenterProjectPoolDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectPoolDataSource(string name) : base("azurerm_dev_center_project_pool", name)
    {
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterProjectId is required")]
    [TerraformPropertyName("dev_center_project_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DevCenterProjectId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDevCenterProjectPoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [TerraformPropertyName("dev_box_definition_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DevBoxDefinitionName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dev_box_definition_name");

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [TerraformPropertyName("dev_center_attached_network_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DevCenterAttachedNetworkName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dev_center_attached_network_name");

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_administrator_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LocalAdministratorEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_administrator_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SingleSignOnEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "single_sign_on_enabled");

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    [TerraformPropertyName("stop_on_disconnect_grace_period_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StopOnDisconnectGracePeriodMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "stop_on_disconnect_grace_period_minutes");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
