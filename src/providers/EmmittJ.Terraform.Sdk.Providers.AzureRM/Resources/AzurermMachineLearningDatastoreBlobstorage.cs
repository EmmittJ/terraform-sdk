using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMachineLearningDatastoreBlobstorageTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_machine_learning_datastore_blobstorage resource.
/// </summary>
public partial class AzurermMachineLearningDatastoreBlobstorage : TerraformResource
{
    public AzurermMachineLearningDatastoreBlobstorage(string name) : base("azurerm_machine_learning_datastore_blobstorage", name)
    {
    }

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    [TerraformProperty("account_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountKey { get; set; }

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
    /// The is_default attribute.
    /// </summary>
    [TerraformProperty("is_default")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IsDefault { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service_data_auth_identity attribute.
    /// </summary>
    [TerraformProperty("service_data_auth_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceDataAuthIdentity { get; set; }

    /// <summary>
    /// The shared_access_signature attribute.
    /// </summary>
    [TerraformProperty("shared_access_signature")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharedAccessSignature { get; set; }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    [TerraformProperty("storage_container_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageContainerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMachineLearningDatastoreBlobstorageTimeoutsBlock Timeouts { get; set; } = new();

}
