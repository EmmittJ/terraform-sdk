using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEipTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_eip resource.
/// </summary>
public partial class AwsEip : TerraformResource
{
    public AwsEip(string name) : base("aws_eip", name)
    {
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformProperty("address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Address { get; set; }

    /// <summary>
    /// The associate_with_private_ip attribute.
    /// </summary>
    [TerraformProperty("associate_with_private_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AssociateWithPrivateIp { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ipv4_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [TerraformProperty("instance")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [TerraformProperty("ipam_pool_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpamPoolId { get; set; }

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformProperty("network_border_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkBorderGroup { get; set; }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformProperty("network_interface")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkInterface { get; set; }

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("public_ipv4_pool")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PublicIpv4Pool { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEipTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformProperty("allocation_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AllocationId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationId { get; }

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    [TerraformProperty("carrier_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CarrierIp { get; }

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomerOwnedIp { get; }

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    [TerraformProperty("private_dns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateDns { get; }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateIp { get; }

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    [TerraformProperty("ptr_record")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PtrRecord { get; }

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    [TerraformProperty("public_dns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicDns { get; }

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    [TerraformProperty("public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicIp { get; }

}
