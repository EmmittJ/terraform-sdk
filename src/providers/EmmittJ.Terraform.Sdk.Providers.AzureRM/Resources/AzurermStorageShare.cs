using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for acl in .
/// Nesting mode: set
/// </summary>
public partial class AzurermStorageShareAclBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageShareTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_share resource.
/// </summary>
public partial class AzurermStorageShare : TerraformResource
{
    public AzurermStorageShare(string name) : base("azurerm_storage_share", name)
    {
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformProperty("access_tier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccessTier { get; set; }

    /// <summary>
    /// The enabled_protocol attribute.
    /// </summary>
    [TerraformProperty("enabled_protocol")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnabledProtocol { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The quota attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Quota is required")]
    [TerraformProperty("quota")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Quota { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("storage_account_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountName { get; set; }

    /// <summary>
    /// Block for acl.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("acl")]
    public TerraformSet<TerraformBlock<AzurermStorageShareAclBlock>>? Acl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageShareTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceManagerId { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
