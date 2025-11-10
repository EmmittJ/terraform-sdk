using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointCidrOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    [TerraformPropertyName("cidr")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cidr { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for load_balancer_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointLoadBalancerOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for network_interface_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NetworkInterfaceId { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

}

/// <summary>
/// Block type for rds_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointRdsOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

    /// <summary>
    /// The rds_db_cluster_arn attribute.
    /// </summary>
    [TerraformPropertyName("rds_db_cluster_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RdsDbClusterArn { get; set; }

    /// <summary>
    /// The rds_db_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("rds_db_instance_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RdsDbInstanceArn { get; set; }

    /// <summary>
    /// The rds_db_proxy_arn attribute.
    /// </summary>
    [TerraformPropertyName("rds_db_proxy_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RdsDbProxyArn { get; set; }

    /// <summary>
    /// The rds_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("rds_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RdsEndpoint { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for sse_specification in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointSseSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVerifiedaccessEndpointTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? ApplicationDomain { get; set; }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    [TerraformPropertyName("attachment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AttachmentType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The domain_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("domain_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainCertificateArn { get; set; }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_domain_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndpointDomainPrefix { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformPropertyName("endpoint_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [TerraformPropertyName("policy_document")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyDocument { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The verified_access_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedAccessGroupId is required")]
    [TerraformPropertyName("verified_access_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VerifiedAccessGroupId { get; set; }

    /// <summary>
    /// Block for cidr_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrOptions block(s) allowed")]
    [TerraformPropertyName("cidr_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointCidrOptionsBlock>>? CidrOptions { get; set; } = new();

    /// <summary>
    /// Block for load_balancer_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerOptions block(s) allowed")]
    [TerraformPropertyName("load_balancer_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>>? LoadBalancerOptions { get; set; } = new();

    /// <summary>
    /// Block for network_interface_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceOptions block(s) allowed")]
    [TerraformPropertyName("network_interface_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>>? NetworkInterfaceOptions { get; set; } = new();

    /// <summary>
    /// Block for rds_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdsOptions block(s) allowed")]
    [TerraformPropertyName("rds_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointRdsOptionsBlock>>? RdsOptions { get; set; } = new();

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    [TerraformPropertyName("sse_specification")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessEndpointSseSpecificationBlock>>? SseSpecification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVerifiedaccessEndpointTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The device_validation_domain attribute.
    /// </summary>
    [TerraformPropertyName("device_validation_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeviceValidationDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "device_validation_domain");

    /// <summary>
    /// The endpoint_domain attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_domain");

    /// <summary>
    /// The verified_access_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("verified_access_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VerifiedAccessInstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "verified_access_instance_id");

}
