using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessEndpointCidrOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    [TerraformProperty("cidr")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cidr { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for load_balancer_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessEndpointLoadBalancerOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [TerraformProperty("load_balancer_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for network_interface_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [TerraformProperty("network_interface_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkInterfaceId { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

}

/// <summary>
/// Block type for rds_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessEndpointRdsOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The rds_db_cluster_arn attribute.
    /// </summary>
    [TerraformProperty("rds_db_cluster_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RdsDbClusterArn { get; set; }

    /// <summary>
    /// The rds_db_instance_arn attribute.
    /// </summary>
    [TerraformProperty("rds_db_instance_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RdsDbInstanceArn { get; set; }

    /// <summary>
    /// The rds_db_proxy_arn attribute.
    /// </summary>
    [TerraformProperty("rds_db_proxy_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RdsDbProxyArn { get; set; }

    /// <summary>
    /// The rds_endpoint attribute.
    /// </summary>
    [TerraformProperty("rds_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RdsEndpoint { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }

}

/// <summary>
/// Block type for sse_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessEndpointSseSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVerifiedaccessEndpointTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_verifiedaccess_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVerifiedaccessEndpoint : TerraformResource
{
    public AwsVerifiedaccessEndpoint(string name) : base("aws_verifiedaccess_endpoint", name)
    {
    }

    /// <summary>
    /// The application_domain attribute.
    /// </summary>
    [TerraformProperty("application_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationDomain { get; set; }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    [TerraformProperty("attachment_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AttachmentType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("domain_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainCertificateArn { get; set; }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    [TerraformProperty("endpoint_domain_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndpointDomainPrefix { get; set; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    [TerraformProperty("endpoint_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    [TerraformProperty("policy_document")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyDocument { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

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
    /// The verified_access_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedAccessGroupId is required")]
    [TerraformProperty("verified_access_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VerifiedAccessGroupId { get; set; }

    /// <summary>
    /// Block for cidr_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrOptions block(s) allowed")]
    [TerraformProperty("cidr_options")]
    public partial TerraformList<TerraformBlock<AwsVerifiedaccessEndpointCidrOptionsBlock>>? CidrOptions { get; set; }

    /// <summary>
    /// Block for load_balancer_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerOptions block(s) allowed")]
    [TerraformProperty("load_balancer_options")]
    public partial TerraformList<TerraformBlock<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>>? LoadBalancerOptions { get; set; }

    /// <summary>
    /// Block for network_interface_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceOptions block(s) allowed")]
    [TerraformProperty("network_interface_options")]
    public partial TerraformList<TerraformBlock<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>>? NetworkInterfaceOptions { get; set; }

    /// <summary>
    /// Block for rds_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdsOptions block(s) allowed")]
    [TerraformProperty("rds_options")]
    public partial TerraformList<TerraformBlock<AwsVerifiedaccessEndpointRdsOptionsBlock>>? RdsOptions { get; set; }

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    [TerraformProperty("sse_specification")]
    public partial TerraformList<TerraformBlock<AwsVerifiedaccessEndpointSseSpecificationBlock>>? SseSpecification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsVerifiedaccessEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The device_validation_domain attribute.
    /// </summary>
    [TerraformProperty("device_validation_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeviceValidationDomain { get; }

    /// <summary>
    /// The endpoint_domain attribute.
    /// </summary>
    [TerraformProperty("endpoint_domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointDomain { get; }

    /// <summary>
    /// The verified_access_instance_id attribute.
    /// </summary>
    [TerraformProperty("verified_access_instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VerifiedAccessInstanceId { get; }

}
