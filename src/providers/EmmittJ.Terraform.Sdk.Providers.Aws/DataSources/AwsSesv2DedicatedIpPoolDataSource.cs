using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_sesv2_dedicated_ip_pool.
/// </summary>
public class AwsSesv2DedicatedIpPoolDataSource : TerraformDataSource
{
    public AwsSesv2DedicatedIpPoolDataSource(string name) : base("aws_sesv2_dedicated_ip_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    [TerraformPropertyName("pool_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PoolName { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The dedicated_ips attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DedicatedIps => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dedicated_ips");

    /// <summary>
    /// The scaling_mode attribute.
    /// </summary>
    [TerraformPropertyName("scaling_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScalingMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scaling_mode");

}
