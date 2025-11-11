using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_routing_control resource.
/// </summary>
public partial class AwsRoute53recoverycontrolconfigRoutingControl : TerraformResource
{
    public AwsRoute53recoverycontrolconfigRoutingControl(string name) : base("aws_route53recoverycontrolconfig_routing_control", name)
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
    /// The control_panel_arn attribute.
    /// </summary>
    [TerraformProperty("control_panel_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ControlPanelArn { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
