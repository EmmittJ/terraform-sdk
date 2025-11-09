using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opensearch_domain resource.
/// </summary>
public class AwsOpensearchDomain : TerraformResource
{
    public AwsOpensearchDomain(string name) : base("aws_opensearch_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dashboard_endpoint");
        this.DeclareOutput("dashboard_endpoint_v2");
        this.DeclareOutput("domain_endpoint_v2_hosted_zone_id");
        this.DeclareOutput("domain_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("endpoint_v2");
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformProperty<string>? AccessPolicies
    {
        get => GetProperty<TerraformProperty<string>>("access_policies");
        set => this.WithProperty("access_policies", value);
    }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public TerraformMapProperty<string>? AdvancedOptions
    {
        get => GetProperty<TerraformMapProperty<string>>("advanced_options");
        set => this.WithProperty("advanced_options", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string>? EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    public TerraformExpression DashboardEndpoint => this["dashboard_endpoint"];

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    public TerraformExpression DashboardEndpointV2 => this["dashboard_endpoint_v2"];

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression DomainEndpointV2HostedZoneId => this["domain_endpoint_v2_hosted_zone_id"];

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformExpression DomainId => this["domain_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    public TerraformExpression EndpointV2 => this["endpoint_v2"];

}
