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
    public required TerraformValue<string> CacheNodeType { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformPropertyName("duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Duration { get; set; }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    [TerraformPropertyName("offering_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OfferingType { get; set; }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    [TerraformPropertyName("product_description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProductDescription { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformPropertyName("fixed_price")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> FixedPrice => new TerraformReference(this, "fixed_price");

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [TerraformPropertyName("offering_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OfferingId => new TerraformReference(this, "offering_id");

}
