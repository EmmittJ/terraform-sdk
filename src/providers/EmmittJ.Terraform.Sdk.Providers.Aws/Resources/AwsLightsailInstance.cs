using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for add_on in .
/// Nesting mode: list
/// </summary>
public partial class AwsLightsailInstanceAddOnBlock : TerraformBlockBase
{
    /// <summary>
    /// The snapshot_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotTime is required")]
    [TerraformProperty("snapshot_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SnapshotTime { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    [TerraformProperty("status")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Status { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_lightsail_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLightsailInstance : TerraformResource
{
    public AwsLightsailInstance(string name) : base("aws_lightsail_instance", name)
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    [TerraformProperty("availability_zone")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    [TerraformProperty("blueprint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BlueprintId { get; set; }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformProperty("bundle_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpAddressType { get; set; }

    /// <summary>
    /// The key_pair_name attribute.
    /// </summary>
    [TerraformProperty("key_pair_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyPairName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    [TerraformProperty("user_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserData { get; set; }

    /// <summary>
    /// Block for add_on.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddOn block(s) allowed")]
    [TerraformProperty("add_on")]
    public TerraformList<TerraformBlock<AwsLightsailInstanceAddOnBlock>>? AddOn { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformProperty("cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCount { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    [TerraformProperty("ipv6_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Ipv6Addresses { get; }

    /// <summary>
    /// The is_static_ip attribute.
    /// </summary>
    [TerraformProperty("is_static_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsStaticIp { get; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The public_ip_address attribute.
    /// </summary>
    [TerraformProperty("public_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PublicIpAddress { get; }

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    [TerraformProperty("ram_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RamSize { get; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Username { get; }

}
