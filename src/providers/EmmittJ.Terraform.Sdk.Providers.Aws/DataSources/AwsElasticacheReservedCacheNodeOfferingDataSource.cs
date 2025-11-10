using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_reserved_cache_node_offering.
/// </summary>
public class AwsElasticacheReservedCacheNodeOfferingDataSource : TerraformDataSource
{
    public AwsElasticacheReservedCacheNodeOfferingDataSource(string name) : base("aws_elasticache_reserved_cache_node_offering", name)
    {
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNodeType is required")]
    [TerraformPropertyName("cache_node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CacheNodeType { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Duration { get; set; }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    [TerraformPropertyName("offering_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OfferingType { get; set; }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    [TerraformPropertyName("product_description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProductDescription { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformPropertyName("fixed_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> FixedPrice => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "fixed_price");

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [TerraformPropertyName("offering_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OfferingId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "offering_id");

}
