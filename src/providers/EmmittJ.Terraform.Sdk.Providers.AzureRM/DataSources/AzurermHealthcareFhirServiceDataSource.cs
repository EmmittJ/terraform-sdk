using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareFhirServiceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_fhir_service.
/// </summary>
public class AzurermHealthcareFhirServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareFhirServiceDataSource(string name) : base("azurerm_healthcare_fhir_service", name)
    {
    }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermHealthcareFhirServiceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformPropertyName("access_policy_object_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AccessPolicyObjectIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "access_policy_object_ids");

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformPropertyName("authentication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Authentication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "authentication");

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    [TerraformPropertyName("configuration_export_storage_account_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationExportStorageAccountName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_export_storage_account_name");

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_login_server_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ContainerRegistryLoginServerUrl => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "container_registry_login_server_url");

    /// <summary>
    /// The cors attribute.
    /// </summary>
    [TerraformPropertyName("cors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Cors => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cors");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

}
