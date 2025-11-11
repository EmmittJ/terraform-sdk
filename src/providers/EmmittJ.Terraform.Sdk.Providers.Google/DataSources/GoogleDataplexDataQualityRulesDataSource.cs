using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dataplex_data_quality_rules.
/// </summary>
public partial class GoogleDataplexDataQualityRulesDataSource : TerraformDataSource
{
    public GoogleDataplexDataQualityRulesDataSource(string name) : base("google_dataplex_data_quality_rules", name)
    {
    }

    /// <summary>
    /// The data_scan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    [TerraformProperty("data_scan_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataScanId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The rules attribute.
    /// </summary>
    [TerraformProperty("rules")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Rules { get; }

}
