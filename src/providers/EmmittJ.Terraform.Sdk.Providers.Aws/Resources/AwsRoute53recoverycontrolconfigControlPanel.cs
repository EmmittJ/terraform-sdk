using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_control_panel resource.
/// </summary>
public class AwsRoute53recoverycontrolconfigControlPanel : TerraformResource
{
    public AwsRoute53recoverycontrolconfigControlPanel(string name) : base("aws_route53recoverycontrolconfig_control_panel", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformPropertyName("cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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

    /// <summary>
    /// The default_control_panel attribute.
    /// </summary>
    [TerraformPropertyName("default_control_panel")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DefaultControlPanel => new TerraformReference(this, "default_control_panel");

    /// <summary>
    /// The routing_control_count attribute.
    /// </summary>
    [TerraformPropertyName("routing_control_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RoutingControlCount => new TerraformReference(this, "routing_control_count");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
