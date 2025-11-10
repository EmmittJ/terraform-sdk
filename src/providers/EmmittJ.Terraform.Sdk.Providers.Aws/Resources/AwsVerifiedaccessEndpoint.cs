using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointCidrOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformProperty<string> Cidr
    {
        set => SetProperty("cidr", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Block type for load_balancer_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointLoadBalancerOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerArn
    {
        set => SetProperty("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Block type for network_interface_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInterfaceId
    {
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

}

/// <summary>
/// Block type for rds_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointRdsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The rds_db_cluster_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RdsDbClusterArn
    {
        set => SetProperty("rds_db_cluster_arn", value);
    }

    /// <summary>
    /// The rds_db_instance_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RdsDbInstanceArn
    {
        set => SetProperty("rds_db_instance_arn", value);
    }

    /// <summary>
    /// The rds_db_proxy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RdsDbProxyArn
    {
        set => SetProperty("rds_db_proxy_arn", value);
    }

    /// <summary>
    /// The rds_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? RdsEndpoint
    {
        set => SetProperty("rds_endpoint", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Block type for sse_specification in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointSseSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomerManagedKeyEnabled
    {
        set => SetProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVerifiedaccessEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_verifiedaccess_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVerifiedaccessEndpoint : TerraformResource
{
    public AwsVerifiedaccessEndpoint(string name) : base("aws_verifiedaccess_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("device_validation_domain");
        SetOutput("endpoint_domain");
        SetOutput("verified_access_instance_id");
        SetOutput("application_domain");
        SetOutput("attachment_type");
        SetOutput("description");
        SetOutput("domain_certificate_arn");
        SetOutput("endpoint_domain_prefix");
        SetOutput("endpoint_type");
        SetOutput("id");
        SetOutput("policy_document");
        SetOutput("region");
        SetOutput("security_group_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("verified_access_group_id");
    }

    /// <summary>
    /// The application_domain attribute.
    /// </summary>
    public TerraformProperty<string> ApplicationDomain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_domain");
        set => SetProperty("application_domain", value);
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    public required TerraformProperty<string> AttachmentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("attachment_type");
        set => SetProperty("attachment_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The domain_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string> DomainCertificateArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_certificate_arn");
        set => SetProperty("domain_certificate_arn", value);
    }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    public TerraformProperty<string> EndpointDomainPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_domain_prefix");
        set => SetProperty("endpoint_domain_prefix", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_type");
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public TerraformProperty<string> PolicyDocument
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_document");
        set => SetProperty("policy_document", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The verified_access_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedAccessGroupId is required")]
    public required TerraformProperty<string> VerifiedAccessGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("verified_access_group_id");
        set => SetProperty("verified_access_group_id", value);
    }

    /// <summary>
    /// Block for cidr_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointCidrOptionsBlock>? CidrOptions
    {
        set => SetProperty("cidr_options", value);
    }

    /// <summary>
    /// Block for load_balancer_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>? LoadBalancerOptions
    {
        set => SetProperty("load_balancer_options", value);
    }

    /// <summary>
    /// Block for network_interface_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>? NetworkInterfaceOptions
    {
        set => SetProperty("network_interface_options", value);
    }

    /// <summary>
    /// Block for rds_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdsOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointRdsOptionsBlock>? RdsOptions
    {
        set => SetProperty("rds_options", value);
    }

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    public List<AwsVerifiedaccessEndpointSseSpecificationBlock>? SseSpecification
    {
        set => SetProperty("sse_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVerifiedaccessEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The device_validation_domain attribute.
    /// </summary>
    public TerraformExpression DeviceValidationDomain => this["device_validation_domain"];

    /// <summary>
    /// The endpoint_domain attribute.
    /// </summary>
    public TerraformExpression EndpointDomain => this["endpoint_domain"];

    /// <summary>
    /// The verified_access_instance_id attribute.
    /// </summary>
    public TerraformExpression VerifiedAccessInstanceId => this["verified_access_instance_id"];

}
