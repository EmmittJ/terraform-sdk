using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vpc_access_connector.
/// </summary>
public class GoogleVpcAccessConnectorDataSource : TerraformDataSource
{
    public GoogleVpcAccessConnectorDataSource(string name) : base("google_vpc_access_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connected_projects");
        this.DeclareOutput("ip_cidr_range");
        this.DeclareOutput("machine_type");
        this.DeclareOutput("max_instances");
        this.DeclareOutput("max_throughput");
        this.DeclareOutput("min_instances");
        this.DeclareOutput("min_throughput");
        this.DeclareOutput("network");
        this.DeclareOutput("self_link");
        this.DeclareOutput("state");
        this.DeclareOutput("subnet");
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
    /// The name of the resource (Max 25 characters).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Region where the VPC Access connector resides. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// List of projects using the connector.
    /// </summary>
    public TerraformExpression ConnectedProjects => this["connected_projects"];

    /// <summary>
    /// The range of internal addresses that follows RFC 4632 notation. Example: &#39;10.132.0.0/28&#39;.
    /// </summary>
    public TerraformExpression IpCidrRange => this["ip_cidr_range"];

    /// <summary>
    /// Machine type of VM Instance underlying connector. Default is e2-micro
    /// </summary>
    public TerraformExpression MachineType => this["machine_type"];

    /// <summary>
    /// Maximum value of instances in autoscaling group underlying the connector. Value must be between 3 and 10, inclusive. Must be
    /// higher than the value specified by min_instances. Required alongside &#39;min_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    public TerraformExpression MaxInstances => this["max_instances"];

    /// <summary>
    /// Maximum throughput of the connector in Mbps, must be greater than &#39;min_throughput&#39;. Default is 300. Refers to the expected throughput
    /// when using an e2-micro machine type. Value must be a multiple of 100 from 300 through 1000. Must be higher than the value specified by
    /// min_throughput. Only one of &#39;max_throughput&#39; and &#39;max_instances&#39; can be specified. The use of max_throughput is discouraged in favor of max_instances.
    /// </summary>
    public TerraformExpression MaxThroughput => this["max_throughput"];

    /// <summary>
    /// Minimum value of instances in autoscaling group underlying the connector. Value must be between 2 and 9, inclusive. Must be
    /// lower than the value specified by max_instances. Required alongside &#39;max_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    public TerraformExpression MinInstances => this["min_instances"];

    /// <summary>
    /// Minimum throughput of the connector in Mbps. Default and min is 200. Refers to the expected throughput when using an e2-micro machine type.
    /// Value must be a multiple of 100 from 200 through 900. Must be lower than the value specified by max_throughput.
    /// Only one of &#39;min_throughput&#39; and &#39;min_instances&#39; can be specified. The use of min_throughput is discouraged in favor of min_instances.
    /// </summary>
    public TerraformExpression MinThroughput => this["min_throughput"];

    /// <summary>
    /// Name or self_link of the VPC network. Required if &#39;ip_cidr_range&#39; is set.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// The fully qualified name of this VPC connector
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// State of the VPC access connector.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The subnet in which to house the connector
    /// </summary>
    public TerraformExpression Subnet => this["subnet"];

}
