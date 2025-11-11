using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_api_keys.
/// </summary>
public class AwsApiGatewayApiKeysDataSource : TerraformDataSource
{
    public AwsApiGatewayApiKeysDataSource(string name) : base("aws_api_gateway_api_keys", name)
    {
    }

    /// <summary>
    /// The customer_id attribute.
    /// </summary>
    [TerraformPropertyName("customer_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerId { get; set; }

    /// <summary>
    /// The include_values attribute.
    /// </summary>
    [TerraformPropertyName("include_values")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeValues { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The items attribute.
    /// </summary>
    [TerraformPropertyName("items")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Items => new TerraformReference(this, "items");

}
