using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2HostDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2HostDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_host.
/// </summary>
public partial class AwsEc2HostDataSource : TerraformDataSource
{
    public AwsEc2HostDataSource(string name) : base("aws_ec2_host", name)
    {
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformProperty("host_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> HostId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsEc2HostDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEc2HostDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [TerraformProperty("asset_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssetId { get; }

    /// <summary>
    /// The auto_placement attribute.
    /// </summary>
    [TerraformProperty("auto_placement")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AutoPlacement { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The cores attribute.
    /// </summary>
    [TerraformProperty("cores")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Cores { get; }

    /// <summary>
    /// The host_recovery attribute.
    /// </summary>
    [TerraformProperty("host_recovery")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostRecovery { get; }

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    [TerraformProperty("instance_family")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceFamily { get; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceType { get; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutpostArn { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The sockets attribute.
    /// </summary>
    [TerraformProperty("sockets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Sockets { get; }

    /// <summary>
    /// The total_vcpus attribute.
    /// </summary>
    [TerraformProperty("total_vcpus")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalVcpus { get; }

}
