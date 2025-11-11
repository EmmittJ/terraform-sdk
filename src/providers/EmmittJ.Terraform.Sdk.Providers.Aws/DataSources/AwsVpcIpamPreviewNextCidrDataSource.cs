using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamPreviewNextCidrDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_ipam_preview_next_cidr.
/// </summary>
public class AwsVpcIpamPreviewNextCidrDataSource : TerraformDataSource
{
    public AwsVpcIpamPreviewNextCidrDataSource(string name) : base("aws_vpc_ipam_preview_next_cidr", name)
    {
    }

    /// <summary>
    /// The disallowed_cidrs attribute.
    /// </summary>
    [TerraformPropertyName("disallowed_cidrs")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DisallowedCidrs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    [TerraformPropertyName("ipam_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IpamPoolId { get; set; }

    /// <summary>
    /// The netmask_length attribute.
    /// </summary>
    [TerraformPropertyName("netmask_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NetmaskLength { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcIpamPreviewNextCidrDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Cidr => new TerraformReference(this, "cidr");

}
