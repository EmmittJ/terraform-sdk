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
    public bool? AcceptanceRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("acceptance_required")?.Value;
        set => this.WithProperty("acceptance_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allowed_principals attribute.
    /// </summary>
    public HashSet<string>? AllowedPrincipals
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_principals")?.Value;
        set => this.WithProperty("allowed_principals", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The gateway_load_balancer_arns attribute.
    /// </summary>
    public HashSet<string>? GatewayLoadBalancerArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("gateway_load_balancer_arns")?.Value;
        set => this.WithProperty("gateway_load_balancer_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_load_balancer_arns attribute.
    /// </summary>
    public HashSet<string>? NetworkLoadBalancerArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("network_load_balancer_arns")?.Value;
        set => this.WithProperty("network_load_balancer_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public string? PrivateDnsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_dns_name")?.Value;
        set => this.WithProperty("private_dns_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    public HashSet<string>? SupportedIpAddressTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("supported_ip_address_types")?.Value;
        set => this.WithProperty("supported_ip_address_types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    public HashSet<string>? SupportedRegions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("supported_regions")?.Value;
        set => this.WithProperty("supported_regions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
