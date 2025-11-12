using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudhsmV2HsmTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_cloudhsm_v2_hsm resource.
/// </summary>
public partial class AwsCloudhsmV2Hsm : TerraformResource
{
    public AwsCloudhsmV2Hsm(string name) : base("aws_cloudhsm_v2_hsm", name)
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddress { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsCloudhsmV2HsmTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The hsm_eni_id attribute.
    /// </summary>
    [TerraformProperty("hsm_eni_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HsmEniId { get; }

    /// <summary>
    /// The hsm_id attribute.
    /// </summary>
    [TerraformProperty("hsm_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HsmId { get; }

    /// <summary>
    /// The hsm_state attribute.
    /// </summary>
    [TerraformProperty("hsm_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HsmState { get; }

}
