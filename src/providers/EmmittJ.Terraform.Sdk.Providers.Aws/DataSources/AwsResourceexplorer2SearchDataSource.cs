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
    public required TerraformValue<string> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The view_arn attribute.
    /// </summary>
    [TerraformPropertyName("view_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ViewArn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    [TerraformPropertyName("resource_count")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ResourceCount => new TerraformReference(this, "resource_count");

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Resources => new TerraformReference(this, "resources");

}
