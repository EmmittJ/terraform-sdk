using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ebs_config in .
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceGroupEbsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Iops { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformPropertyName("size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Size { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    [TerraformPropertyName("volumes_per_instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VolumesPerInstance { get; set; }

}

/// <summary>
/// Manages a aws_emr_instance_group resource.
/// </summary>
public class AwsEmrInstanceGroup : TerraformResource
{
    public AwsEmrInstanceGroup(string name) : base("aws_emr_instance_group", name)
    {
    }

    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    [TerraformPropertyName("autoscaling_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutoscalingPolicy { get; set; }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformPropertyName("bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BidPrice { get; set; }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    [TerraformPropertyName("configurations_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfigurationsJson { get; set; }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    [TerraformPropertyName("ebs_optimized")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EbsOptimized { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> InstanceCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "instance_count");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for ebs_config.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("ebs_config")]
    public TerraformSet<TerraformBlock<AwsEmrInstanceGroupEbsConfigBlock>>? EbsConfig { get; set; } = new();

    /// <summary>
    /// The running_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("running_instance_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RunningInstanceCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "running_instance_count");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
