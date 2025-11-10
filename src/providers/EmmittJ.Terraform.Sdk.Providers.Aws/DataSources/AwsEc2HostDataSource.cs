using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2HostDataSourceFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2HostDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_host.
/// </summary>
public class AwsEc2HostDataSource : TerraformDataSource
{
    public AwsEc2HostDataSource(string name) : base("aws_ec2_host", name)
    {
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HostId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2HostDataSourceFilterBlock>>? Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEc2HostDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [TerraformPropertyName("asset_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "asset_id");

    /// <summary>
    /// The auto_placement attribute.
    /// </summary>
    [TerraformPropertyName("auto_placement")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutoPlacement => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_placement");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The cores attribute.
    /// </summary>
    [TerraformPropertyName("cores")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Cores => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cores");

    /// <summary>
    /// The host_recovery attribute.
    /// </summary>
    [TerraformPropertyName("host_recovery")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostRecovery => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_recovery");

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    [TerraformPropertyName("instance_family")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceFamily => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_family");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformPropertyName("outpost_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The sockets attribute.
    /// </summary>
    [TerraformPropertyName("sockets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Sockets => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "sockets");

    /// <summary>
    /// The total_vcpus attribute.
    /// </summary>
    [TerraformPropertyName("total_vcpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalVcpus => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_vcpus");

}
