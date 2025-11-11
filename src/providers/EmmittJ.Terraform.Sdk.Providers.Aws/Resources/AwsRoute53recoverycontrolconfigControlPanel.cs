using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_control_panel resource.
/// </summary>
public partial class AwsRoute53recoverycontrolconfigControlPanel : TerraformResource
{
    public AwsRoute53recoverycontrolconfigControlPanel(string name) : base("aws_route53recoverycontrolconfig_control_panel", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformProperty("cluster_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_control_panel attribute.
    /// </summary>
    [TerraformProperty("default_control_panel")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DefaultControlPanel { get; }

    /// <summary>
    /// The routing_control_count attribute.
    /// </summary>
    [TerraformProperty("routing_control_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RoutingControlCount { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
