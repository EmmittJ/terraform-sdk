using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_subnetwork.
/// </summary>
public class GoogleComputeSubnetworkDataSource : TerraformDataSource
{
    public GoogleComputeSubnetworkDataSource(string name) : base("google_compute_subnetwork", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("external_ipv6_prefix");
        SetOutput("gateway_address");
        SetOutput("internal_ipv6_prefix");
        SetOutput("ip_cidr_range");
        SetOutput("ipv6_access_type");
        SetOutput("network");
        SetOutput("private_ip_google_access");
        SetOutput("secondary_ip_range");
        SetOutput("stack_type");
        SetOutput("subnetwork_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
        SetOutput("self_link");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformProperty<string> SelfLink
    {
        get => GetRequiredOutput<TerraformProperty<string>>("self_link");
        set => SetProperty("self_link", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The external_ipv6_prefix attribute.
    /// </summary>
    public TerraformExpression ExternalIpv6Prefix => this["external_ipv6_prefix"];

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    public TerraformExpression GatewayAddress => this["gateway_address"];

    /// <summary>
    /// The internal_ipv6_prefix attribute.
    /// </summary>
    public TerraformExpression InternalIpv6Prefix => this["internal_ipv6_prefix"];

    /// <summary>
    /// The ip_cidr_range attribute.
    /// </summary>
    public TerraformExpression IpCidrRange => this["ip_cidr_range"];

    /// <summary>
    /// The ipv6_access_type attribute.
    /// </summary>
    public TerraformExpression Ipv6AccessType => this["ipv6_access_type"];

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// The private_ip_google_access attribute.
    /// </summary>
    public TerraformExpression PrivateIpGoogleAccess => this["private_ip_google_access"];

    /// <summary>
    /// The secondary_ip_range attribute.
    /// </summary>
    public TerraformExpression SecondaryIpRange => this["secondary_ip_range"];

    /// <summary>
    /// The stack_type attribute.
    /// </summary>
    public TerraformExpression StackType => this["stack_type"];

    /// <summary>
    /// The subnetwork_id attribute.
    /// </summary>
    public TerraformExpression SubnetworkId => this["subnetwork_id"];

}
