using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_resource.
/// </summary>
public partial class AwsApiGatewayResourceDataSource : TerraformDataSource
{
    public AwsApiGatewayResourceDataSource(string name) : base("aws_api_gateway_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [TerraformProperty("parent_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ParentId { get; }

    /// <summary>
    /// The path_part attribute.
    /// </summary>
    [TerraformProperty("path_part")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PathPart { get; }

}
