using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_reserved_cache_node_offering.
/// </summary>
public class AwsElasticacheReservedCacheNodeOfferingDataSource : TerraformDataSource
{
    public AwsElasticacheReservedCacheNodeOfferingDataSource(string name) : base("aws_elasticache_reserved_cache_node_offering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fixed_price");
        SetOutput("offering_id");
        SetOutput("cache_node_type");
        SetOutput("duration");
        SetOutput("offering_type");
        SetOutput("product_description");
        SetOutput("region");
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheNodeType is required")]
    public required TerraformProperty<string> CacheNodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_node_type");
        set => SetProperty("cache_node_type", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformProperty<string> Duration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("duration");
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OfferingType is required")]
    public required TerraformProperty<string> OfferingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("offering_type");
        set => SetProperty("offering_type", value);
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductDescription is required")]
    public required TerraformProperty<string> ProductDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("product_description");
        set => SetProperty("product_description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformExpression FixedPrice => this["fixed_price"];

    /// <summary>
    /// The offering_id attribute.
    /// </summary>
    public TerraformExpression OfferingId => this["offering_id"];

}
