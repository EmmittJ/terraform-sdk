using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_endpoint_service.
/// </summary>
public class AwsVpcEndpointServiceDataSource : TerraformDataSource
{
    public AwsVpcEndpointServiceDataSource(string name) : base("aws_vpc_endpoint_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("acceptance_required");
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zones");
        this.DeclareOutput("base_endpoint_dns_names");
        this.DeclareOutput("manages_vpc_endpoints");
        this.DeclareOutput("owner");
        this.DeclareOutput("private_dns_name");
        this.DeclareOutput("private_dns_names");
        this.DeclareOutput("region");
        this.DeclareOutput("service_id");
        this.DeclareOutput("supported_ip_address_types");
        this.DeclareOutput("vpc_endpoint_policy_supported");
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
    /// The service attribute.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public string? ServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_name")?.Value;
        set => this.WithProperty("service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_regions attribute.
    /// </summary>
    public HashSet<string>? ServiceRegions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("service_regions")?.Value;
        set => this.WithProperty("service_regions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public string? ServiceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_type")?.Value;
        set => this.WithProperty("service_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The acceptance_required attribute.
    /// </summary>
    public TerraformExpression AcceptanceRequired => this["acceptance_required"];

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
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformExpression PrivateDnsName => this["private_dns_name"];

    /// <summary>
    /// The private_dns_names attribute.
    /// </summary>
    public TerraformExpression PrivateDnsNames => this["private_dns_names"];

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformExpression ServiceId => this["service_id"];

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    public TerraformExpression SupportedIpAddressTypes => this["supported_ip_address_types"];

    /// <summary>
    /// The vpc_endpoint_policy_supported attribute.
    /// </summary>
    public TerraformExpression VpcEndpointPolicySupported => this["vpc_endpoint_policy_supported"];

}
