using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleChronicleDataAccessLabelTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_chronicle_data_access_label resource.
/// </summary>
public partial class GoogleChronicleDataAccessLabel : TerraformResource
{
    public GoogleChronicleDataAccessLabel(string name) : base("google_chronicle_data_access_label", name)
    {
    }

    /// <summary>
    /// Required. The ID to use for the data access label, which will become the label&#39;s
    /// display name and the final component of the label&#39;s resource name. The
    /// maximum number of characters should be 63. Regex pattern is as per AIP:
    /// https://google.aip.dev/122#resource-id-segments
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessLabelId is required")]
    [TerraformProperty("data_access_label_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataAccessLabelId { get; set; }

    /// <summary>
    /// Optional. A description of the data access label for a human reader.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A UDM query over event data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UdmQuery is required")]
    [TerraformProperty("udm_query")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UdmQuery { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleChronicleDataAccessLabelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The user who created the data access label.
    /// </summary>
    [TerraformProperty("author")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Author { get; }

    /// <summary>
    /// Output only. The time at which the data access label was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. The short name displayed for the label as it appears on event data. This is same as data access label id.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// Output only. The user who last updated the data access label.
    /// </summary>
    [TerraformProperty("last_editor")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastEditor { get; }

    /// <summary>
    /// The unique resource name of the data access label. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label_id}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The time at which the data access label was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
