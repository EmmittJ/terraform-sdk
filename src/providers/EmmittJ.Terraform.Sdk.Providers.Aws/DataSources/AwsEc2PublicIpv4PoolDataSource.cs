using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_public_ipv4_pool.
/// </summary>
public partial class AwsEc2PublicIpv4PoolDataSource : TerraformDataSource
{
    public AwsEc2PublicIpv4PoolDataSource(string name) : base("aws_ec2_public_ipv4_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolId is required")]
    [TerraformProperty("pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PoolId { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformProperty("network_border_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkBorderGroup { get; }

    /// <summary>
    /// The pool_address_ranges attribute.
    /// </summary>
    [TerraformProperty("pool_address_ranges")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PoolAddressRanges { get; }

    /// <summary>
    /// The total_address_count attribute.
    /// </summary>
    [TerraformProperty("total_address_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalAddressCount { get; }

    /// <summary>
    /// The total_available_address_count attribute.
    /// </summary>
    [TerraformProperty("total_available_address_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalAvailableAddressCount { get; }

}
