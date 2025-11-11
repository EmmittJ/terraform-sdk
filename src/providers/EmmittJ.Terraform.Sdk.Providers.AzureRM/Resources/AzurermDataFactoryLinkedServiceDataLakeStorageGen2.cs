using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryLinkedServiceDataLakeStorageGen2TimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_data_factory_linked_service_data_lake_storage_gen2 resource.
/// </summary>
public partial class AzurermDataFactoryLinkedServiceDataLakeStorageGen2 : TerraformResource
{
    public AzurermDataFactoryLinkedServiceDataLakeStorageGen2(string name) : base("azurerm_data_factory_linked_service_data_lake_storage_gen2", name)
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    [TerraformProperty("integration_runtime_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IntegrationRuntimeName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    [TerraformProperty("service_principal_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServicePrincipalId { get; set; }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    [TerraformProperty("service_principal_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServicePrincipalKey { get; set; }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountKey { get; set; }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [TerraformProperty("tenant")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tenant { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    [TerraformProperty("use_managed_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseManagedIdentity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDataFactoryLinkedServiceDataLakeStorageGen2TimeoutsBlock>? Timeouts { get; set; }

}
