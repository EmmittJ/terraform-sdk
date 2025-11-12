using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcIpamsDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_ipams.
/// </summary>
public partial class AwsVpcIpamsDataSource : TerraformDataSource
{
    public AwsVpcIpamsDataSource(string name) : base("aws_vpc_ipams", name)
    {
    }

    /// <summary>
    /// The ipam_ids attribute.
    /// </summary>
    [TerraformProperty("ipam_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IpamIds { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsVpcIpamsDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// The ipams attribute.
    /// </summary>
    [TerraformProperty("ipams")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Ipams { get; }

}
