using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermManagedDiskSasTokenTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azurerm_managed_disk_sas_token resource.
/// </summary>
public partial class AzurermManagedDiskSasToken : TerraformResource
{
    public AzurermManagedDiskSasToken(string name) : base("azurerm_managed_disk_sas_token", name)
    {
    }

    /// <summary>
    /// The access_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    [TerraformProperty("access_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessLevel { get; set; }

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationInSeconds is required")]
    [TerraformProperty("duration_in_seconds")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DurationInSeconds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedDiskId is required")]
    [TerraformProperty("managed_disk_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedDiskId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermManagedDiskSasTokenTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [TerraformProperty("sas_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SasUrl { get; }

}
