using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eip_association resource.
/// </summary>
public partial class AwsEipAssociation : TerraformResource
{
    public AwsEipAssociation(string name) : base("aws_eip_association", name)
    {
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformProperty("allocation_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AllocationId { get; set; }

    /// <summary>
    /// The allow_reassociation attribute.
    /// </summary>
    [TerraformProperty("allow_reassociation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowReassociation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [TerraformProperty("instance_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NetworkInterfaceId { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrivateIpAddress { get; set; }

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

}
