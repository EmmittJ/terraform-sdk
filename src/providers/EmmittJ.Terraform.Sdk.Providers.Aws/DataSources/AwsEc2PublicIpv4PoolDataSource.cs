using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_public_ipv4_pool.
/// </summary>
public class AwsEc2PublicIpv4PoolDataSource : TerraformDataSource
{
    public AwsEc2PublicIpv4PoolDataSource(string name) : base("aws_ec2_public_ipv4_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolId is required")]
    [TerraformPropertyName("pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PoolId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("network_border_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkBorderGroup => new TerraformReference(this, "network_border_group");

    /// <summary>
    /// The pool_address_ranges attribute.
    /// </summary>
    [TerraformPropertyName("pool_address_ranges")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PoolAddressRanges => new TerraformReference(this, "pool_address_ranges");

    /// <summary>
    /// The total_address_count attribute.
    /// </summary>
    [TerraformPropertyName("total_address_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalAddressCount => new TerraformReference(this, "total_address_count");

    /// <summary>
    /// The total_available_address_count attribute.
    /// </summary>
    [TerraformPropertyName("total_available_address_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalAvailableAddressCount => new TerraformReference(this, "total_available_address_count");

}
