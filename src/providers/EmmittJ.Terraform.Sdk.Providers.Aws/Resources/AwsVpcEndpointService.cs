using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcEndpointServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_endpoint_service resource.
/// </summary>
public partial class AwsVpcEndpointService : TerraformResource
{
    public AwsVpcEndpointService(string name) : base("aws_vpc_endpoint_service", name)
    {
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptanceRequired is required")]
    [TerraformProperty("acceptance_required")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AcceptanceRequired { get; set; }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    [TerraformProperty("allowed_principals")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> AllowedPrincipals { get; set; }

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    [TerraformProperty("gateway_load_balancer_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? GatewayLoadBalancerArns { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The network_load_balancer_arns attribute.
    /// </summary>
    [TerraformProperty("network_load_balancer_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? NetworkLoadBalancerArns { get; set; }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    [TerraformProperty("private_dns_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateDnsName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    [TerraformProperty("supported_ip_address_types")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SupportedIpAddressTypes { get; set; }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    [TerraformProperty("supported_regions")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SupportedRegions { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsVpcEndpointServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AvailabilityZones { get; }

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    [TerraformProperty("base_endpoint_dns_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> BaseEndpointDnsNames { get; }

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    [TerraformProperty("manages_vpc_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ManagesVpcEndpoints { get; }

    /// <summary>
    /// The private_dns_name_configuration attribute.
    /// </summary>
    [TerraformProperty("private_dns_name_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrivateDnsNameConfiguration { get; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformProperty("service_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceName { get; }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    [TerraformProperty("service_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceType { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
