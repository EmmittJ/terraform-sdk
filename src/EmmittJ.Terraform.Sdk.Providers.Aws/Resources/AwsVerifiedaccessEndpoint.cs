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
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => WithProperty("cidr", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
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
        get => GetProperty<TerraformProperty<string>>("load_balancer_arn");
        set => WithProperty("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
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
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => WithProperty("network_interface_id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
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
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The rds_db_cluster_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RdsDbClusterArn
    {
        get => GetProperty<TerraformProperty<string>>("rds_db_cluster_arn");
        set => WithProperty("rds_db_cluster_arn", value);
    }

    /// <summary>
    /// The rds_db_instance_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RdsDbInstanceArn
    {
        get => GetProperty<TerraformProperty<string>>("rds_db_instance_arn");
        set => WithProperty("rds_db_instance_arn", value);
    }

    /// <summary>
    /// The rds_db_proxy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RdsDbProxyArn
    {
        get => GetProperty<TerraformProperty<string>>("rds_db_proxy_arn");
        set => WithProperty("rds_db_proxy_arn", value);
    }

    /// <summary>
    /// The rds_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? RdsEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("rds_endpoint");
        set => WithProperty("rds_endpoint", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
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
        get => GetProperty<TerraformProperty<bool>>("customer_managed_key_enabled");
        set => WithProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_verifiedaccess_endpoint resource.
/// </summary>
public class AwsVerifiedaccessEndpoint : TerraformResource
{
    public AwsVerifiedaccessEndpoint(string name) : base("aws_verifiedaccess_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("device_validation_domain");
        this.DeclareOutput("endpoint_domain");
        this.DeclareOutput("verified_access_instance_id");
    }

    /// <summary>
    /// The application_domain attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationDomain
    {
        get => GetProperty<TerraformProperty<string>>("application_domain");
        set => this.WithProperty("application_domain", value);
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    public required TerraformProperty<string> AttachmentType
    {
        get => GetProperty<TerraformProperty<string>>("attachment_type");
        set => this.WithProperty("attachment_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The domain_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DomainCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("domain_certificate_arn");
        set => this.WithProperty("domain_certificate_arn", value);
    }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointDomainPrefix
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_domain_prefix");
        set => this.WithProperty("endpoint_domain_prefix", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The verified_access_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedAccessGroupId is required")]
    public required TerraformProperty<string> VerifiedAccessGroupId
    {
        get => GetProperty<TerraformProperty<string>>("verified_access_group_id");
        set => this.WithProperty("verified_access_group_id", value);
    }

    /// <summary>
    /// Block for cidr_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointCidrOptionsBlock>? CidrOptions
    {
        get => GetProperty<List<AwsVerifiedaccessEndpointCidrOptionsBlock>>("cidr_options");
        set => this.WithProperty("cidr_options", value);
    }

    /// <summary>
    /// Block for load_balancer_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>? LoadBalancerOptions
    {
        get => GetProperty<List<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>>("load_balancer_options");
        set => this.WithProperty("load_balancer_options", value);
    }

    /// <summary>
    /// Block for network_interface_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>? NetworkInterfaceOptions
    {
        get => GetProperty<List<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>>("network_interface_options");
        set => this.WithProperty("network_interface_options", value);
    }

    /// <summary>
    /// Block for rds_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdsOptions block(s) allowed")]
    public List<AwsVerifiedaccessEndpointRdsOptionsBlock>? RdsOptions
    {
        get => GetProperty<List<AwsVerifiedaccessEndpointRdsOptionsBlock>>("rds_options");
        set => this.WithProperty("rds_options", value);
    }

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    public List<AwsVerifiedaccessEndpointSseSpecificationBlock>? SseSpecification
    {
        get => GetProperty<List<AwsVerifiedaccessEndpointSseSpecificationBlock>>("sse_specification");
        set => this.WithProperty("sse_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVerifiedaccessEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVerifiedaccessEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
