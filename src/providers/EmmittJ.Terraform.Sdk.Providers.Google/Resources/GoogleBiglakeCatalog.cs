using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBiglakeCatalogTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_biglake_catalog resource.
/// </summary>
public partial class GoogleBiglakeCatalog : TerraformResource
{
    public GoogleBiglakeCatalog(string name) : base("google_biglake_catalog", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The geographic location where the Catalog should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the Catalog. Format:
    /// projects/{project_id_or_number}/locations/{locationId}/catalogs/{catalogId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBiglakeCatalogTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The creation time of the catalog. A timestamp in RFC3339 UTC
    /// &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. The deletion time of the catalog. Only set after the catalog
    /// is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    [TerraformProperty("delete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteTime { get; }

    /// <summary>
    /// Output only. The time when this catalog is considered expired. Only set
    /// after the catalog is deleted. Only set after the catalog is deleted.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// Output only. The last modification time of the catalog. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
