using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_vpc_access_connector resource.
/// </summary>
public class GoogleVpcAccessConnector : TerraformResource
{
    public GoogleVpcAccessConnector(string name) : base("google_vpc_access_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connected_projects");
        this.DeclareOutput("self_link");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The range of internal addresses that follows RFC 4632 notation. Example: &#39;10.132.0.0/28&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? IpCidrRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_cidr_range");
        set => this.WithProperty("ip_cidr_range", value);
    }

    /// <summary>
    /// Machine type of VM Instance underlying connector. Default is e2-micro
    /// </summary>
    public TerraformLiteralProperty<string>? MachineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("machine_type");
        set => this.WithProperty("machine_type", value);
    }

    /// <summary>
    /// Maximum value of instances in autoscaling group underlying the connector. Value must be between 3 and 10, inclusive. Must be
    /// higher than the value specified by min_instances. Required alongside &#39;min_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxInstances
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_instances");
        set => this.WithProperty("max_instances", value);
    }

    /// <summary>
    /// Maximum throughput of the connector in Mbps, must be greater than &#39;min_throughput&#39;. Default is 300. Refers to the expected throughput
    /// when using an e2-micro machine type. Value must be a multiple of 100 from 300 through 1000. Must be higher than the value specified by
    /// min_throughput. Only one of &#39;max_throughput&#39; and &#39;max_instances&#39; can be specified. The use of max_throughput is discouraged in favor of max_instances.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxThroughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_throughput");
        set => this.WithProperty("max_throughput", value);
    }

    /// <summary>
    /// Minimum value of instances in autoscaling group underlying the connector. Value must be between 2 and 9, inclusive. Must be
    /// lower than the value specified by max_instances. Required alongside &#39;max_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    public TerraformLiteralProperty<double>? MinInstances
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_instances");
        set => this.WithProperty("min_instances", value);
    }

    /// <summary>
    /// Minimum throughput of the connector in Mbps. Default and min is 200. Refers to the expected throughput when using an e2-micro machine type.
    /// Value must be a multiple of 100 from 200 through 900. Must be lower than the value specified by max_throughput.
    /// Only one of &#39;min_throughput&#39; and &#39;min_instances&#39; can be specified. The use of min_throughput is discouraged in favor of min_instances.
    /// </summary>
    public TerraformLiteralProperty<double>? MinThroughput
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_throughput");
        set => this.WithProperty("min_throughput", value);
    }

    /// <summary>
    /// The name of the resource (Max 25 characters).
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Name or self_link of the VPC network. Required if &#39;ip_cidr_range&#39; is set.
    /// </summary>
    public TerraformLiteralProperty<string>? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where the VPC Access connector resides. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// List of projects using the connector.
    /// </summary>
    public TerraformExpression ConnectedProjects => this["connected_projects"];

    /// <summary>
    /// The fully qualified name of this VPC connector
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// State of the VPC access connector.
    /// </summary>
    public TerraformExpression State => this["state"];

}
