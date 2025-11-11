using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_api_keys.
/// </summary>
public partial class AwsApiGatewayApiKeysDataSource : TerraformDataSource
{
    public AwsApiGatewayApiKeysDataSource(string name) : base("aws_api_gateway_api_keys", name)
    {
    }

    /// <summary>
    /// The customer_id attribute.
    /// </summary>
    [TerraformProperty("customer_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomerId { get; set; }

    /// <summary>
    /// The include_values attribute.
    /// </summary>
    [TerraformProperty("include_values")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeValues { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The items attribute.
    /// </summary>
    [TerraformProperty("items")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Items { get; }

}
