using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Retrieves information about a aws_route53_traffic_policy_document.
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSource : TerraformDataSource
{
    public AwsRoute53TrafficPolicyDocumentDataSource(string name) : base("aws_route53_traffic_policy_document", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The record_type attribute.
    /// </summary>
    [TerraformPropertyName("record_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RecordType { get; set; }

    /// <summary>
    /// The start_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("start_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartEndpoint { get; set; }

    /// <summary>
    /// The start_rule attribute.
    /// </summary>
    [TerraformPropertyName("start_rule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartRule { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("endpoint")]
    public TerraformSet<TerraformBlock<AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock>>? Endpoint { get; set; } = new();

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("rule")]
    public TerraformSet<TerraformBlock<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock>>? Rule { get; set; } = new();

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformPropertyName("json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Json => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "json");

}
