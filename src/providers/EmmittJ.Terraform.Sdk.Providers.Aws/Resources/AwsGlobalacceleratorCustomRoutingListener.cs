using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_range in .
/// Nesting mode: set
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingListenerPortRangeBlock : TerraformBlockBase
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformProperty("from_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FromPort { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformProperty("to_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ToPort { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGlobalacceleratorCustomRoutingListenerTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_globalaccelerator_custom_routing_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlobalacceleratorCustomRoutingListener : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingListener(string name) : base("aws_globalaccelerator_custom_routing_listener", name)
    {
    }

    /// <summary>
    /// The accelerator_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorArn is required")]
    [TerraformProperty("accelerator_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AcceleratorArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for port_range.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortRange is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortRange block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortRange block(s) allowed")]
    [TerraformProperty("port_range")]
    public TerraformSet<TerraformBlock<AwsGlobalacceleratorCustomRoutingListenerPortRangeBlock>>? PortRange { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsGlobalacceleratorCustomRoutingListenerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
