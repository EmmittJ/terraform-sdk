using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStreamAnalyticsJobStorageAccountTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_stream_analytics_job_storage_account resource.
/// </summary>
public partial class AzurermStreamAnalyticsJobStorageAccount : TerraformResource
{
    public AzurermStreamAnalyticsJobStorageAccount(string name) : base("azurerm_stream_analytics_job_storage_account", name)
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationMode is required")]
    [TerraformProperty("authentication_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountKey { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformProperty("storage_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountName { get; set; }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    [TerraformProperty("stream_analytics_job_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamAnalyticsJobId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStreamAnalyticsJobStorageAccountTimeoutsBlock Timeouts { get; set; } = new();

}
