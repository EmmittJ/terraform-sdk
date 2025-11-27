using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cidr_options in AwsVerifiedaccessEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointCidrOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cidr_options";

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => new TerraformReference<string>(this, "cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortRange is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortRange block(s) required")]
    public required TerraformSet<AwsVerifiedaccessEndpointCidrOptionsBlockPortRangeBlock> PortRange
    {
        get => GetRequiredArgument<TerraformSet<AwsVerifiedaccessEndpointCidrOptionsBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for port_range in AwsVerifiedaccessEndpointCidrOptionsBlock.
/// Nesting mode: set
/// </summary>
public class AwsVerifiedaccessEndpointCidrOptionsBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for load_balancer_options in AwsVerifiedaccessEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointLoadBalancerOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer_options";

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerArn
    {
        get => new TerraformReference<string>(this, "load_balancer_arn");
        set => SetArgument("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVerifiedaccessEndpointLoadBalancerOptionsBlockPortRangeBlock>? PortRange
    {
        get => GetArgument<TerraformSet<AwsVerifiedaccessEndpointLoadBalancerOptionsBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for port_range in AwsVerifiedaccessEndpointLoadBalancerOptionsBlock.
/// Nesting mode: set
/// </summary>
public class AwsVerifiedaccessEndpointLoadBalancerOptionsBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for network_interface_options in AwsVerifiedaccessEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface_options";

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformValue<string>? NetworkInterfaceId
    {
        get => new TerraformReference<string>(this, "network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlockPortRangeBlock>? PortRange
    {
        get => GetArgument<TerraformSet<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for port_range in AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock.
/// Nesting mode: set
/// </summary>
public class AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for rds_options in AwsVerifiedaccessEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointRdsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rds_options";

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The rds_db_cluster_arn attribute.
    /// </summary>
    public TerraformValue<string>? RdsDbClusterArn
    {
        get => new TerraformReference<string>(this, "rds_db_cluster_arn");
        set => SetArgument("rds_db_cluster_arn", value);
    }

    /// <summary>
    /// The rds_db_instance_arn attribute.
    /// </summary>
    public TerraformValue<string>? RdsDbInstanceArn
    {
        get => new TerraformReference<string>(this, "rds_db_instance_arn");
        set => SetArgument("rds_db_instance_arn", value);
    }

    /// <summary>
    /// The rds_db_proxy_arn attribute.
    /// </summary>
    public TerraformValue<string>? RdsDbProxyArn
    {
        get => new TerraformReference<string>(this, "rds_db_proxy_arn");
        set => SetArgument("rds_db_proxy_arn", value);
    }

    /// <summary>
    /// The rds_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? RdsEndpoint
    {
        get => new TerraformReference<string>(this, "rds_endpoint");
        set => SetArgument("rds_endpoint", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Block type for sse_specification in AwsVerifiedaccessEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessEndpointSseSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_specification";

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerManagedKeyEnabled
    {
        get => new TerraformReference<bool>(this, "customer_managed_key_enabled");
        set => SetArgument("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVerifiedaccessEndpoint.
/// Nesting mode: single
/// </summary>
public class AwsVerifiedaccessEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_verifiedaccess_endpoint Terraform resource.
/// Manages a aws_verifiedaccess_endpoint resource.
/// </summary>
public partial class AwsVerifiedaccessEndpoint(string name) : TerraformResource("aws_verifiedaccess_endpoint", name)
{
    /// <summary>
    /// The application_domain attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationDomain
    {
        get => new TerraformReference<string>(this, "application_domain");
        set => SetArgument("application_domain", value);
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    public required TerraformValue<string> AttachmentType
    {
        get => new TerraformReference<string>(this, "attachment_type");
        set => SetArgument("attachment_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The domain_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? DomainCertificateArn
    {
        get => new TerraformReference<string>(this, "domain_certificate_arn");
        set => SetArgument("domain_certificate_arn", value);
    }

    /// <summary>
    /// The endpoint_domain_prefix attribute.
    /// </summary>
    public TerraformValue<string>? EndpointDomainPrefix
    {
        get => new TerraformReference<string>(this, "endpoint_domain_prefix");
        set => SetArgument("endpoint_domain_prefix", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public TerraformValue<string>? PolicyDocument
    {
        get => new TerraformReference<string>(this, "policy_document");
        set => SetArgument("policy_document", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The verified_access_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedAccessGroupId is required")]
    public required TerraformValue<string> VerifiedAccessGroupId
    {
        get => new TerraformReference<string>(this, "verified_access_group_id");
        set => SetArgument("verified_access_group_id", value);
    }

    /// <summary>
    /// The device_validation_domain attribute.
    /// </summary>
    public TerraformValue<string> DeviceValidationDomain
    {
        get => new TerraformReference<string>(this, "device_validation_domain");
    }

    /// <summary>
    /// The endpoint_domain attribute.
    /// </summary>
    public TerraformValue<string> EndpointDomain
    {
        get => new TerraformReference<string>(this, "endpoint_domain");
    }

    /// <summary>
    /// The verified_access_instance_id attribute.
    /// </summary>
    public TerraformValue<string> VerifiedAccessInstanceId
    {
        get => new TerraformReference<string>(this, "verified_access_instance_id");
    }

    /// <summary>
    /// CidrOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrOptions block(s) allowed")]
    public TerraformList<AwsVerifiedaccessEndpointCidrOptionsBlock>? CidrOptions
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessEndpointCidrOptionsBlock>>("cidr_options");
        set => SetArgument("cidr_options", value);
    }

    /// <summary>
    /// LoadBalancerOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerOptions block(s) allowed")]
    public TerraformList<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>? LoadBalancerOptions
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessEndpointLoadBalancerOptionsBlock>>("load_balancer_options");
        set => SetArgument("load_balancer_options", value);
    }

    /// <summary>
    /// NetworkInterfaceOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceOptions block(s) allowed")]
    public TerraformList<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>? NetworkInterfaceOptions
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessEndpointNetworkInterfaceOptionsBlock>>("network_interface_options");
        set => SetArgument("network_interface_options", value);
    }

    /// <summary>
    /// RdsOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RdsOptions block(s) allowed")]
    public TerraformList<AwsVerifiedaccessEndpointRdsOptionsBlock>? RdsOptions
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessEndpointRdsOptionsBlock>>("rds_options");
        set => SetArgument("rds_options", value);
    }

    /// <summary>
    /// SseSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    public TerraformList<AwsVerifiedaccessEndpointSseSpecificationBlock>? SseSpecification
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessEndpointSseSpecificationBlock>>("sse_specification");
        set => SetArgument("sse_specification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVerifiedaccessEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVerifiedaccessEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
