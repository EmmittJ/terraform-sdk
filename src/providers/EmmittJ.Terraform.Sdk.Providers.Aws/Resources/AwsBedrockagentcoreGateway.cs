using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock() : TerraformBlock("authorizer_configuration")
{
}

/// <summary>
/// Block type for protocol_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreGatewayProtocolConfigurationBlock() : TerraformBlock("protocol_configuration")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsBedrockagentcoreGatewayTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagentcore_gateway resource.
/// </summary>
public partial class AwsBedrockagentcoreGateway : TerraformResource
{
    public AwsBedrockagentcoreGateway(string name) : base("aws_bedrockagentcore_gateway", name)
    {
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    [TerraformProperty("authorizer_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthorizerType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The exception_level attribute.
    /// </summary>
    [TerraformProperty("exception_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExceptionLevel { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    [TerraformProperty("protocol_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProtocolType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for authorizer_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("authorizer_configuration")]
    public TerraformList<AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock> AuthorizerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for protocol_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("protocol_configuration")]
    public TerraformList<AwsBedrockagentcoreGatewayProtocolConfigurationBlock> ProtocolConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsBedrockagentcoreGatewayTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [TerraformProperty("gateway_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayArn { get; }

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformProperty("gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayId { get; }

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformProperty("gateway_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayUrl { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    [TerraformProperty("workload_identity_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WorkloadIdentityDetails { get; }

}
