using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEipDataSourceFilterBlock : TerraformBlockBase
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
public partial class AwsEipDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_eip.
/// </summary>
public partial class AwsEipDataSource : TerraformDataSource
{
    public AwsEipDataSource(string name) : base("aws_eip", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformProperty("public_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PublicIp { get; set; }

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
    public TerraformSet<TerraformBlock<AwsEipDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEipDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssociationId { get; }

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    [TerraformProperty("carrier_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CarrierIp { get; }

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerOwnedIp { get; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ipv4_pool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerOwnedIpv4Pool { get; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Domain { get; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceId { get; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformProperty("ipam_pool_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpamPoolId { get; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkInterfaceId { get; }

    /// <summary>
    /// The network_interface_owner_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkInterfaceOwnerId { get; }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformProperty("private_dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateDns { get; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateIp { get; }

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    [TerraformProperty("ptr_record")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PtrRecord { get; }

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformProperty("public_dns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicDns { get; }

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("public_ipv4_pool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicIpv4Pool { get; }

}
