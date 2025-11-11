using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamsDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_vpc_ipams.
/// </summary>
public class AwsVpcIpamsDataSource : TerraformDataSource
{
    public AwsVpcIpamsDataSource(string name) : base("aws_vpc_ipams", name)
    {
    }

    /// <summary>
    /// The ipam_ids attribute.
    /// </summary>
    [TerraformPropertyName("ipam_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IpamIds { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsVpcIpamsDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The ipams attribute.
    /// </summary>
    [TerraformPropertyName("ipams")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Ipams => new TerraformReference(this, "ipams");

}
