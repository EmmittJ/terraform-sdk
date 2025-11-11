using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleDataAccessLabelTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_chronicle_data_access_label resource.
/// </summary>
public class GoogleChronicleDataAccessLabel : TerraformResource
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
    [TerraformPropertyName("data_access_label_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataAccessLabelId { get; set; }

    /// <summary>
    /// Optional. A description of the data access label for a human reader.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// A UDM query over event data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UdmQuery is required")]
    [TerraformPropertyName("udm_query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UdmQuery { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleChronicleDataAccessLabelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The user who created the data access label.
    /// </summary>
    [TerraformPropertyName("author")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Author => new TerraformReference(this, "author");

    /// <summary>
    /// Output only. The time at which the data access label was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Output only. The short name displayed for the label as it appears on event data. This is same as data access label id.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// Output only. The user who last updated the data access label.
    /// </summary>
    [TerraformPropertyName("last_editor")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastEditor => new TerraformReference(this, "last_editor");

    /// <summary>
    /// The unique resource name of the data access label. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label_id}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. The time at which the data access label was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
