using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_base_path_mapping resource.
/// </summary>
public class AwsApiGatewayBasePathMapping : TerraformResource
{
    public AwsApiGatewayBasePathMapping(string name) : base("aws_api_gateway_base_path_mapping", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The base_path attribute.
    /// </summary>
    [TerraformPropertyName("base_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BasePath { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_name_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainNameId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [TerraformPropertyName("stage_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StageName { get; set; }

}
