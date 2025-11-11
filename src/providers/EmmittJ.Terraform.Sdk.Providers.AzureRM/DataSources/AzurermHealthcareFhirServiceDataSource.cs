using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermHealthcareFhirServiceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_fhir_service.
/// </summary>
public partial class AzurermHealthcareFhirServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareFhirServiceDataSource(string name) : base("azurerm_healthcare_fhir_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermHealthcareFhirServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformProperty("access_policy_object_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AccessPolicyObjectIds { get; }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformProperty("authentication")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Authentication { get; }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    [TerraformProperty("configuration_export_storage_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConfigurationExportStorageAccountName { get; }

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    [TerraformProperty("container_registry_login_server_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ContainerRegistryLoginServerUrl { get; }

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformProperty("cors")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Cors { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

}
