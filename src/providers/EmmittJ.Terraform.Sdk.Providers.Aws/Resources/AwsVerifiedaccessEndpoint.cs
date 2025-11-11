using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointCidrOptionsBlock
{
    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    [TerraformPropertyName("cidr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Cidr { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for load_balancer_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointLoadBalancerOptionsBlock
{
    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for network_interface_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock
{
    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkInterfaceId { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

}

/// <summary>
/// Block type for rds_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointRdsOptionsBlock
{
    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The rds_db_cluster_arn attribute.
    /// </summary>
    [TerraformPropertyName("rds_db_cluster_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RdsDbClusterArn { get; set; }

    /// <summary>
    /// The rds_db_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("rds_db_instance_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RdsDbInstanceArn { get; set; }

    /// <summary>
    /// The rds_db_proxy_arn attribute.
    /// </summary>
    [TerraformPropertyName("rds_db_proxy_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RdsDbProxyArn { get; set; }

    /// <summary>
    /// The rds_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("rds_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RdsEndpoint { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for sse_specification in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointSseSpecificationBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVerifiedaccessEndpointTimeoutsBlock
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
/// Manages a aws_verifiedaccess_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVerifiedaccessEndpoint : TerraformResource
{
    public AwsVerifiedaccessEndpoint(string name) : base("aws_verifiedaccess_endpoint", name)
    {
    }

    /// <summary>
    /// The application_domain attribute.
    /// </summary>
    [TerraformPropertyName("application_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplicationDomain { get; set; }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    [TerraformPropertyName("attachment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AttachmentType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DomainCertificateArn { get; set; }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_domain_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EndpointDomainPrefix { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [TerraformPropertyName("policy_document")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyDocument { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

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
    /// The verified_access_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedAccessGroupId is required")]
    [TerraformPropertyName("verified_access_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VerifiedAccessGroupId { get; set; }

    /// <summary>
    /// Block for cidr_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrOptions block(s) allowed")]
    [TerraformPropertyName("cidr_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointCidrOptionsBlock>>? CidrOptions { get; set; }

    /// <summary>
    /// Block for load_balancer_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerOptions block(s) allowed")]
    [TerraformPropertyName("load_balancer_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>>? LoadBalancerOptions { get; set; }

    /// <summary>
    /// Block for network_interface_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceOptions block(s) allowed")]
    [TerraformPropertyName("network_interface_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>>? NetworkInterfaceOptions { get; set; }

    /// <summary>
    /// Block for rds_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdsOptions block(s) allowed")]
    [TerraformPropertyName("rds_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointRdsOptionsBlock>>? RdsOptions { get; set; }

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    [TerraformPropertyName("sse_specification")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointSseSpecificationBlock>>? SseSpecification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVerifiedaccessEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The device_validation_domain attribute.
    /// </summary>
    [TerraformPropertyName("device_validation_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeviceValidationDomain => new TerraformReference(this, "device_validation_domain");

    /// <summary>
    /// The endpoint_domain attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointDomain => new TerraformReference(this, "endpoint_domain");

    /// <summary>
    /// The verified_access_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("verified_access_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VerifiedAccessInstanceId => new TerraformReference(this, "verified_access_instance_id");

}
