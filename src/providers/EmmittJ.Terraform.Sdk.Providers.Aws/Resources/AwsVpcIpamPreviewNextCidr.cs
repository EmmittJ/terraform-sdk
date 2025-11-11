using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_preview_next_cidr resource.
/// </summary>
public partial class AwsVpcIpamPreviewNextCidr : TerraformResource
{
    public AwsVpcIpamPreviewNextCidr(string name) : base("aws_vpc_ipam_preview_next_cidr", name)
    {
    }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    [TerraformProperty("disallowed_cidrs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DisallowedCidrs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    [TerraformProperty("ipam_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpamPoolId { get; set; }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    [TerraformProperty("netmask_length")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NetmaskLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [TerraformProperty("cidr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Cidr { get; }

}
