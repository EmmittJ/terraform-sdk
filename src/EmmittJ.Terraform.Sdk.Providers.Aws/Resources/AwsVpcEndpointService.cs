using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zones");
        this.DeclareOutput("base_endpoint_dns_names");
        this.DeclareOutput("manages_vpc_endpoints");
        this.DeclareOutput("private_dns_name_configuration");
        this.DeclareOutput("service_name");
        this.DeclareOutput("service_type");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The acceptance_required attribute.
    /// </summary>
    public TerraformProperty<bool>? AcceptanceRequired
    {
        get => GetProperty<TerraformProperty<bool>>("acceptance_required");
        set => this.WithProperty("acceptance_required", value);
    }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AllowedPrincipals
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("allowed_principals");
        set => this.WithProperty("allowed_principals", value);
    }

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? GatewayLoadBalancerArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("gateway_load_balancer_arns");
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
    public TerraformProperty<HashSet<string>>? NetworkLoadBalancerArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("network_load_balancer_arns");
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
    public TerraformProperty<HashSet<string>>? SupportedIpAddressTypes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("supported_ip_address_types");
        set => this.WithProperty("supported_ip_address_types", value);
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SupportedRegions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("supported_regions");
        set => this.WithProperty("supported_regions", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
