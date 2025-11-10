using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authorizer_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for protocol_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayProtocolConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreGatewayTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagentcore_gateway resource.
/// </summary>
public class AwsBedrockagentcoreGateway : TerraformResource
{
    public AwsBedrockagentcoreGateway(string name) : base("aws_bedrockagentcore_gateway", name)
    {
    }

    /// <summary>
    /// The authorizer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerType is required")]
    [TerraformPropertyName("authorizer_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthorizerType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The exception_level attribute.
    /// </summary>
    [TerraformPropertyName("exception_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExceptionLevel { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    [TerraformPropertyName("protocol_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProtocolType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for authorizer_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("authorizer_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreGatewayAuthorizerConfigurationBlock>>? AuthorizerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for protocol_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("protocol_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreGatewayProtocolConfigurationBlock>>? ProtocolConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsBedrockagentcoreGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The gateway_arn attribute.
    /// </summary>
    [TerraformPropertyName("gateway_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_arn");

    /// <summary>
    /// The gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_id");

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    [TerraformPropertyName("gateway_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_url");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The workload_identity_details attribute.
    /// </summary>
    [TerraformPropertyName("workload_identity_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WorkloadIdentityDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "workload_identity_details");

}
