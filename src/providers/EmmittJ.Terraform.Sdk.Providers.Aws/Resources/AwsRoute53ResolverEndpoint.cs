using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ip_address in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53ResolverEndpointIpAddressBlock : TerraformBlock
{
    /// <summary>
    /// The ip attribute.
    /// </summary>
    public TerraformProperty<string>? Ip
    {
        get => GetProperty<TerraformProperty<string>>("ip");
        set => WithProperty("ip", value);
    }

    /// <summary>
    /// The ip_id attribute.
    /// </summary>
    public TerraformProperty<string>? IpId
    {
        get => GetProperty<TerraformProperty<string>>("ip_id");
        set => WithProperty("ip_id", value);
    }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6
    {
        get => GetProperty<TerraformProperty<string>>("ipv6");
        set => WithProperty("ipv6", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53ResolverEndpointTimeoutsBlock : TerraformBlock
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
/// Manages a aws_route53_resolver_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRoute53ResolverEndpoint : TerraformResource
{
    public AwsRoute53ResolverEndpoint(string name) : base("aws_route53_resolver_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("host_vpc_id");
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformProperty<string> Direction
    {
        get => GetRequiredProperty<TerraformProperty<string>>("direction");
        set => this.WithProperty("direction", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Protocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("protocols");
        set => this.WithProperty("protocols", value);
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
    /// The resolver_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResolverEndpointType
    {
        get => GetProperty<TerraformProperty<string>>("resolver_endpoint_type");
        set => this.WithProperty("resolver_endpoint_type", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
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
    /// Block for ip_address.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 IpAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 IpAddress block(s) allowed")]
    public HashSet<AwsRoute53ResolverEndpointIpAddressBlock>? IpAddress
    {
        get => GetProperty<HashSet<AwsRoute53ResolverEndpointIpAddressBlock>>("ip_address");
        set => this.WithProperty("ip_address", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53ResolverEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53ResolverEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The host_vpc_id attribute.
    /// </summary>
    public TerraformExpression HostVpcId => this["host_vpc_id"];

}
