using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadNamedLocationDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_named_location.
/// </summary>
public partial class AzureadNamedLocationDataSource : TerraformDataSource
{
    public AzureadNamedLocationDataSource(string name) : base("azuread_named_location", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadNamedLocationDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformProperty("country")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Country { get; }

    /// <summary>
    /// The ip attribute.
    /// </summary>
    [TerraformProperty("ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Ip { get; }

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    [TerraformProperty("object_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ObjectId { get; }

}
