using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_endpoint_service resource.
/// </summary>
public class AwsVpcEndpointService : TerraformResource
{
    public AwsVpcEndpointService(string name) : base("aws_vpc_endpoint_service", name)
    {
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptanceRequired is required")]
    [TerraformPropertyName("acceptance_required")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> AcceptanceRequired { get; set; }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    [TerraformPropertyName("allowed_principals")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> AllowedPrincipals { get; set; } = default!;

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("gateway_load_balancer_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The network_load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("network_load_balancer_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateDnsName { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    [TerraformPropertyName("supported_ip_address_types")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SupportedIpAddressTypes { get; set; } = default!;

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    [TerraformPropertyName("supported_regions")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SupportedRegions { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcEndpointServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AvailabilityZones => new TerraformReference(this, "availability_zones");

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    [TerraformPropertyName("base_endpoint_dns_names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> BaseEndpointDnsNames => new TerraformReference(this, "base_endpoint_dns_names");

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("manages_vpc_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ManagesVpcEndpoints => new TerraformReference(this, "manages_vpc_endpoints");

    /// <summary>
    /// The private_dns_name_configuration attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_name_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivateDnsNameConfiguration => new TerraformReference(this, "private_dns_name_configuration");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceName => new TerraformReference(this, "service_name");

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformPropertyName("service_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceType => new TerraformReference(this, "service_type");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
