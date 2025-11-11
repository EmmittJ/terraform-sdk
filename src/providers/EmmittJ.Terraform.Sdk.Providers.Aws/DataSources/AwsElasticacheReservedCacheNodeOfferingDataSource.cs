using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_reserved_cache_node_offering.
/// </summary>
public partial class AwsElasticacheReservedCacheNodeOfferingDataSource : TerraformDataSource
{
    public AwsElasticacheReservedCacheNodeOfferingDataSource(string name) : base("aws_elasticache_reserved_cache_node_offering", name)
    {
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNodeType is required")]
    [TerraformProperty("cache_node_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CacheNodeType { get; set; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [TerraformProperty("duration")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Duration { get; set; }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    [TerraformProperty("offering_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OfferingType { get; set; }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    [TerraformProperty("product_description")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProductDescription { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformProperty("fixed_price")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> FixedPrice { get; }

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    [TerraformProperty("offering_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OfferingId { get; }

}
