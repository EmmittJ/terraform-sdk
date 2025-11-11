using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iot_endpoint.
/// </summary>
public partial class AwsIotEndpointDataSource : TerraformDataSource
{
    public AwsIotEndpointDataSource(string name) : base("aws_iot_endpoint", name)
    {
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndpointType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The endpoint_address attribute.
    /// </summary>
    [TerraformProperty("endpoint_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointAddress { get; }

}
