using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: set
/// </summary>
public partial class AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public partial class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Retrieves information about a aws_route53_traffic_policy_document.
/// </summary>
public partial class AwsRoute53TrafficPolicyDocumentDataSource : TerraformDataSource
{
    public AwsRoute53TrafficPolicyDocumentDataSource(string name) : base("aws_route53_traffic_policy_document", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The record_type attribute.
    /// </summary>
    [TerraformProperty("record_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RecordType { get; set; }

    /// <summary>
    /// The start_endpoint attribute.
    /// </summary>
    [TerraformProperty("start_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartEndpoint { get; set; }

    /// <summary>
    /// The start_rule attribute.
    /// </summary>
    [TerraformProperty("start_rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartRule { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("endpoint")]
    public partial TerraformSet<TerraformBlock<AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock>>? Endpoint { get; set; }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("rule")]
    public partial TerraformSet<TerraformBlock<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock>>? Rule { get; set; }

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformProperty("json")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Json { get; }

}
