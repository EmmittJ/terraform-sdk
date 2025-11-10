using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_devopsguru_resource_collection.
/// </summary>
public class AwsDevopsguruResourceCollectionDataSource : TerraformDataSource
{
    public AwsDevopsguruResourceCollectionDataSource(string name) : base("aws_devopsguru_resource_collection", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The cloudformation attribute.
    /// </summary>
    [TerraformPropertyName("cloudformation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Cloudformation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cloudformation");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Tags => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tags");

}
