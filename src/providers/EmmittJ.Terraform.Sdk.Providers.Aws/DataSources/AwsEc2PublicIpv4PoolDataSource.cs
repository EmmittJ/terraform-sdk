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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolId is required")]
    [TerraformPropertyName("pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PoolId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    [TerraformPropertyName("network_border_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkBorderGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_border_group");

    /// <summary>
    /// The pool_address_ranges attribute.
    /// </summary>
    [TerraformPropertyName("pool_address_ranges")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PoolAddressRanges => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "pool_address_ranges");

    /// <summary>
    /// The total_address_count attribute.
    /// </summary>
    [TerraformPropertyName("total_address_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalAddressCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_address_count");

    /// <summary>
    /// The total_available_address_count attribute.
    /// </summary>
    [TerraformPropertyName("total_available_address_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalAvailableAddressCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_available_address_count");

}
