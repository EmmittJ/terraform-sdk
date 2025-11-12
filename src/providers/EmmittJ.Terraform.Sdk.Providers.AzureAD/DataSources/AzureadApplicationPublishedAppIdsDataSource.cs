using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationPublishedAppIdsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_application_published_app_ids.
/// </summary>
public partial class AzureadApplicationPublishedAppIdsDataSource : TerraformDataSource
{
    public AzureadApplicationPublishedAppIdsDataSource(string name) : base("azuread_application_published_app_ids", name)
    {
    }

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
    public AzureadApplicationPublishedAppIdsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// A mapping of application names and application IDs
    /// </summary>
    [TerraformProperty("result")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Result { get; }

}
