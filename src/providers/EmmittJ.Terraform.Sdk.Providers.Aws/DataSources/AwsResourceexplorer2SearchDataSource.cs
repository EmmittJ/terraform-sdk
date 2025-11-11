using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_resourceexplorer2_search.
/// </summary>
public partial class AwsResourceexplorer2SearchDataSource : TerraformDataSource
{
    public AwsResourceexplorer2SearchDataSource(string name) : base("aws_resourceexplorer2_search", name)
    {
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    [TerraformProperty("query_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueryString { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The view_arn attribute.
    /// </summary>
    [TerraformProperty("view_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ViewArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    [TerraformProperty("resource_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ResourceCount { get; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Resources { get; }

}
