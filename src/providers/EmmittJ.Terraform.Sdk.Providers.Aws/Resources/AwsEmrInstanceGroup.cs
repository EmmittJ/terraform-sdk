using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_config in .
/// Nesting mode: set
/// </summary>
public partial class AwsEmrInstanceGroupEbsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Iops { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformProperty("size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Size { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    [TerraformProperty("volumes_per_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VolumesPerInstance { get; set; }

}

/// <summary>
/// Manages a aws_emr_instance_group resource.
/// </summary>
public partial class AwsEmrInstanceGroup : TerraformResource
{
    public AwsEmrInstanceGroup(string name) : base("aws_emr_instance_group", name)
    {
    }

    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    [TerraformProperty("autoscaling_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoscalingPolicy { get; set; }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformProperty("bid_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BidPrice { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    [TerraformProperty("configurations_json")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationsJson { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformProperty("ebs_optimized")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EbsOptimized { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for ebs_config.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("ebs_config")]
    public partial TerraformSet<TerraformBlock<AwsEmrInstanceGroupEbsConfigBlock>>? EbsConfig { get; set; }

    /// <summary>
    /// The running_instance_count attribute.
    /// </summary>
    [TerraformProperty("running_instance_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RunningInstanceCount { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
