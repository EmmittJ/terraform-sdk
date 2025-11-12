using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preferred_tables in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryBiReservationPreferredTablesBlock() : TerraformBlock("preferred_tables")
{
    /// <summary>
    /// The ID of the dataset in the above project.
    /// </summary>
    [TerraformProperty("dataset_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatasetId { get; set; }

    /// <summary>
    /// The assigned project ID of the project.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectId { get; set; }

    /// <summary>
    /// The ID of the table in the above dataset.
    /// </summary>
    [TerraformProperty("table_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TableId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryBiReservationTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_bi_reservation resource.
/// </summary>
public partial class GoogleBigqueryBiReservation : TerraformResource
{
    public GoogleBigqueryBiReservation(string name) : base("google_bigquery_bi_reservation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// LOCATION_DESCRIPTION
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Size of a reservation, in bytes.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Size { get; set; }

    /// <summary>
    /// Block for preferred_tables.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("preferred_tables")]
    public TerraformList<GoogleBigqueryBiReservationPreferredTablesBlock> PreferredTables { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigqueryBiReservationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of the singleton BI reservation. Reservation names have the form &#39;projects/{projectId}/locations/{locationId}/biReservation&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The last update timestamp of a reservation.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
