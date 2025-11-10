using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointServiceDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("acceptance_required");
        SetOutput("arn");
        SetOutput("availability_zones");
        SetOutput("base_endpoint_dns_names");
        SetOutput("manages_vpc_endpoints");
        SetOutput("owner");
        SetOutput("private_dns_name");
        SetOutput("private_dns_names");
        SetOutput("region");
        SetOutput("service_id");
        SetOutput("service_region");
        SetOutput("supported_ip_address_types");
        SetOutput("vpc_endpoint_policy_supported");
        SetOutput("id");
        SetOutput("service");
        SetOutput("service_name");
        SetOutput("service_regions");
        SetOutput("service_type");
        SetOutput("tags");
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
    /// The service attribute.
    /// </summary>
    public TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// The service_regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ServiceRegions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("service_regions");
        set => SetProperty("service_regions", value);
    }

    /// <summary>
    /// The service_type attribute.
    /// </summary>
    public TerraformProperty<string> ServiceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_type");
        set => SetProperty("service_type", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcEndpointServiceDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcEndpointServiceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
    /// The service_region attribute.
    /// </summary>
    public TerraformExpression ServiceRegion => this["service_region"];

    /// <summary>
    /// The supported_ip_address_types attribute.
    /// </summary>
    public TerraformExpression SupportedIpAddressTypes => this["supported_ip_address_types"];

    /// <summary>
    /// The vpc_endpoint_policy_supported attribute.
    /// </summary>
    public TerraformExpression VpcEndpointPolicySupported => this["vpc_endpoint_policy_supported"];

}
