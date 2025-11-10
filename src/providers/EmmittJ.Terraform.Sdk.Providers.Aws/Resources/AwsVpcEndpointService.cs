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
        SetOutput("arn");
        SetOutput("availability_zones");
        SetOutput("base_endpoint_dns_names");
        SetOutput("manages_vpc_endpoints");
        SetOutput("private_dns_name_configuration");
        SetOutput("service_name");
        SetOutput("service_type");
        SetOutput("state");
        SetOutput("acceptance_required");
        SetOutput("allowed_principals");
        SetOutput("gateway_load_balancer_arns");
        SetOutput("id");
        SetOutput("network_load_balancer_arns");
        SetOutput("private_dns_name");
        SetOutput("region");
        SetOutput("supported_ip_address_types");
        SetOutput("supported_regions");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptanceRequired is required")]
    public required TerraformProperty<bool> AcceptanceRequired
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("acceptance_required");
        set => SetProperty("acceptance_required", value);
    }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AllowedPrincipals
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_principals");
        set => SetProperty("allowed_principals", value);
    }

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> GatewayLoadBalancerArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("gateway_load_balancer_arns");
        set => SetProperty("gateway_load_balancer_arns", value);
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
    /// The network_load_balancer_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> NetworkLoadBalancerArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("network_load_balancer_arns");
        set => SetProperty("network_load_balancer_arns", value);
    }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformProperty<string> PrivateDnsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_dns_name");
        set => SetProperty("private_dns_name", value);
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
    /// The supported_ip_address_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SupportedIpAddressTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("supported_ip_address_types");
        set => SetProperty("supported_ip_address_types", value);
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SupportedRegions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("supported_regions");
        set => SetProperty("supported_regions", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcEndpointServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
