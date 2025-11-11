using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstancePartitionTimeoutsBlock
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
/// Manages a google_spanner_instance_partition resource.
/// </summary>
public class GoogleSpannerInstancePartition : TerraformResource
{
    public GoogleSpannerInstancePartition(string name) : base("google_spanner_instance_partition", name)
    {
    }

    /// <summary>
    /// The name of the instance partition&#39;s configuration (similar to a region) which
    /// defines the geographic placement and replication of data in this instance partition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [TerraformPropertyName("config")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Config { get; set; }

    /// <summary>
    /// The descriptive name for this instance partition as it appears in UIs.
    /// Must be unique per project and between 4 and 30 characters in length.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance to create the instance partition in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// A unique identifier for the instance partition, which cannot be changed after
    /// the instance partition is created. The name must be between 2 and 64 characters
    /// and match the regular expression [a-z][a-z0-9\\-]{0,61}[a-z0-9].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The number of nodes allocated to this instance partition. One node equals
    /// 1000 processing units. Exactly one of either node_count or processing_units
    /// must be present.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NodeCount { get; set; }

    /// <summary>
    /// The number of processing units allocated to this instance partition.
    /// Exactly one of either node_count or processing_units must be present.
    /// </summary>
    [TerraformPropertyName("processing_units")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ProcessingUnits { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSpannerInstancePartitionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The current instance partition state. Possible values are:
    /// CREATING: The instance partition is being created. Resources are being
    /// allocated for the instance partition.
    /// READY: The instance partition has been allocated resources and is ready for use.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
