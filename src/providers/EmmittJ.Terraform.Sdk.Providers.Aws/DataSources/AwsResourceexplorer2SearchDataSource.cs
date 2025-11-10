using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_resourceexplorer2_search.
/// </summary>
public class AwsResourceexplorer2SearchDataSource : TerraformDataSource
{
    public AwsResourceexplorer2SearchDataSource(string name) : base("aws_resourceexplorer2_search", name)
    {
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    [TerraformPropertyName("query_string")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The view_arn attribute.
    /// </summary>
    [TerraformPropertyName("view_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ViewArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "view_arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    [TerraformPropertyName("resource_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ResourceCount => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resource_count");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Resources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resources");

}
