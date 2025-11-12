using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataShareDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_share.
/// </summary>
public partial class AzurermDataShareDataSource : TerraformDataSource
{
    public AzurermDataShareDataSource(string name) : base("azurerm_data_share", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataShareDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The snapshot_schedule attribute.
    /// </summary>
    [TerraformProperty("snapshot_schedule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SnapshotSchedule { get; }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    [TerraformProperty("terms")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Terms { get; }

}
