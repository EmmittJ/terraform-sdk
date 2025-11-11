using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectPoolDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public required TerraformValue<string> DevCenterProjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDevCenterProjectPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    [TerraformPropertyName("dev_box_definition_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DevBoxDefinitionName => new TerraformReference(this, "dev_box_definition_name");

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    [TerraformPropertyName("dev_center_attached_network_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DevCenterAttachedNetworkName => new TerraformReference(this, "dev_center_attached_network_name");

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_administrator_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LocalAdministratorEnabled => new TerraformReference(this, "local_administrator_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    [TerraformPropertyName("single_sign_on_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SingleSignOnEnabled => new TerraformReference(this, "single_sign_on_enabled");

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    [TerraformPropertyName("stop_on_disconnect_grace_period_minutes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StopOnDisconnectGracePeriodMinutes => new TerraformReference(this, "stop_on_disconnect_grace_period_minutes");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
