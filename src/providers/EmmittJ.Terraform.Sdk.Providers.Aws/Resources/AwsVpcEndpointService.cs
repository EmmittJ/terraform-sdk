using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceTimeoutsBlock : TerraformBlock
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
/// Manages a aws_vpc_endpoint_service resource.
/// </summary>
public class AwsVpcEndpointService : TerraformResource
{
    public AwsVpcEndpointService(string name) : base("aws_vpc_endpoint_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("availability_zones");
        this.WithOutput("base_endpoint_dns_names");
        this.WithOutput("manages_vpc_endpoints");
        this.WithOutput("private_dns_name_configuration");
        this.WithOutput("service_name");
        this.WithOutput("service_type");
        this.WithOutput("state");
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptanceRequired is required")]
    public required TerraformProperty<bool> AcceptanceRequired
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("acceptance_required");
        set => this.WithProperty("acceptance_required", value);
    }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedPrincipals
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_principals");
        set => this.WithProperty("allowed_principals", value);
    }

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? GatewayLoadBalancerArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("gateway_load_balancer_arns");
        set => this.WithProperty("gateway_load_balancer_arns", value);
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
    /// The network_load_balancer_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NetworkLoadBalancerArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("network_load_balancer_arns");
        set => this.WithProperty("network_load_balancer_arns", value);
    }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateDnsName
    {
        get => GetProperty<TerraformProperty<string>>("private_dns_name");
        set => this.WithProperty("private_dns_name", value);
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
    /// The supported_ip_address_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SupportedIpAddressTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("supported_ip_address_types");
        set => this.WithProperty("supported_ip_address_types", value);
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SupportedRegions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("supported_regions");
        set => this.WithProperty("supported_regions", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcEndpointServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcEndpointServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

    /// <summary>
    /// The base_endpoint_dns_names attribute.
    /// </summary>
    public TerraformExpression BaseEndpointDnsNames => this["base_endpoint_dns_names"];

    /// <summary>
    /// The manages_vpc_endpoints attribute.
    /// </summary>
    public TerraformExpression ManagesVpcEndpoints => this["manages_vpc_endpoints"];

    /// <summary>
    /// The private_dns_name_configuration attribute.
    /// </summary>
    public TerraformExpression PrivateDnsNameConfiguration => this["private_dns_name_configuration"];

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformExpression ServiceName => this["service_name"];

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformExpression ServiceType => this["service_type"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
