using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_base_path_mapping resource.
/// </summary>
public partial class AwsApiGatewayBasePathMapping : TerraformResource
{
    public AwsApiGatewayBasePathMapping(string name) : base("aws_api_gateway_base_path_mapping", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The base_path attribute.
    /// </summary>
    [TerraformProperty("base_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BasePath { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    [TerraformProperty("domain_name_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainNameId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [TerraformProperty("stage_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StageName { get; set; }

}
