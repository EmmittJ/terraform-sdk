using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ce_anomaly_monitor resource.
/// </summary>
public class AwsCeAnomalyMonitor : TerraformResource
{
    public AwsCeAnomalyMonitor(string name) : base("aws_ce_anomaly_monitor", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The monitor_dimension attribute.
    /// </summary>
    [TerraformPropertyName("monitor_dimension")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MonitorDimension { get; set; }

    /// <summary>
    /// The monitor_specification attribute.
    /// </summary>
    [TerraformPropertyName("monitor_specification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MonitorSpecification { get; set; }

    /// <summary>
    /// The monitor_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorType is required")]
    [TerraformPropertyName("monitor_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MonitorType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
