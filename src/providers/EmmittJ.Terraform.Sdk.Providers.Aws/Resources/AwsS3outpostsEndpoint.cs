using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3outposts_endpoint resource.
/// </summary>
public partial class AwsS3outpostsEndpoint : TerraformResource
{
    public AwsS3outpostsEndpoint(string name) : base("aws_s3outposts_endpoint", name)
    {
    }

    /// <summary>
    /// The access_type attribute.
    /// </summary>
    [TerraformProperty("access_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccessType { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ipv4_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The outpost_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutpostId is required")]
    [TerraformProperty("outpost_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OutpostId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupId is required")]
    [TerraformProperty("security_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecurityGroupId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    [TerraformProperty("cidr_block")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CidrBlock { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    [TerraformProperty("network_interfaces")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> NetworkInterfaces { get; }

}
