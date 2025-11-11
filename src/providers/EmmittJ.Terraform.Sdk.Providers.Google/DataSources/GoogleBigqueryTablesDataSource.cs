using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_tables.
/// </summary>
public partial class GoogleBigqueryTablesDataSource : TerraformDataSource
{
    public GoogleBigqueryTablesDataSource(string name) : base("google_bigquery_tables", name)
    {
    }

    /// <summary>
    /// The ID of the dataset containing the tables.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    [TerraformProperty("tables")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Tables { get; }

}
