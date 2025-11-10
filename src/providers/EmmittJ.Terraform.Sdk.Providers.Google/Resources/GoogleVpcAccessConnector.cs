using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class GoogleVpcAccessConnectorSubnetBlock : TerraformBlock
{
    /// <summary>
    /// Subnet name (relative, not fully qualified). E.g. if the full subnet selfLink is
    /// https://compute.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetName} the correct input for this field would be {subnetName}&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Project in which the subnet exists. If not set, this project is assumed to be the project for which the connector create request was issued.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        set => SetProperty("project_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVpcAccessConnectorTimeoutsBlock : TerraformBlock
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
/// Manages a google_vpc_access_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVpcAccessConnector : TerraformResource
{
    public GoogleVpcAccessConnector(string name) : base("google_vpc_access_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("connected_projects");
        SetOutput("self_link");
        SetOutput("state");
        SetOutput("id");
        SetOutput("ip_cidr_range");
        SetOutput("machine_type");
        SetOutput("max_instances");
        SetOutput("max_throughput");
        SetOutput("min_instances");
        SetOutput("min_throughput");
        SetOutput("name");
        SetOutput("network");
        SetOutput("project");
        SetOutput("region");
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
    /// The range of internal addresses that follows RFC 4632 notation. Example: &#39;10.132.0.0/28&#39;.
    /// </summary>
    public TerraformProperty<string> IpCidrRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_cidr_range");
        set => SetProperty("ip_cidr_range", value);
    }

    /// <summary>
    /// Machine type of VM Instance underlying connector. Default is e2-micro
    /// </summary>
    public TerraformProperty<string> MachineType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("machine_type");
        set => SetProperty("machine_type", value);
    }

    /// <summary>
    /// Maximum value of instances in autoscaling group underlying the connector. Value must be between 3 and 10, inclusive. Must be
    /// higher than the value specified by min_instances. Required alongside &#39;min_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    public TerraformProperty<double> MaxInstances
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_instances");
        set => SetProperty("max_instances", value);
    }

    /// <summary>
    /// Maximum throughput of the connector in Mbps, must be greater than &#39;min_throughput&#39;. Default is 300. Refers to the expected throughput
    /// when using an e2-micro machine type. Value must be a multiple of 100 from 300 through 1000. Must be higher than the value specified by
    /// min_throughput. Only one of &#39;max_throughput&#39; and &#39;max_instances&#39; can be specified. The use of max_throughput is discouraged in favor of max_instances.
    /// </summary>
    public TerraformProperty<double> MaxThroughput
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_throughput");
        set => SetProperty("max_throughput", value);
    }

    /// <summary>
    /// Minimum value of instances in autoscaling group underlying the connector. Value must be between 2 and 9, inclusive. Must be
    /// lower than the value specified by max_instances. Required alongside &#39;max_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    public TerraformProperty<double> MinInstances
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_instances");
        set => SetProperty("min_instances", value);
    }

    /// <summary>
    /// Minimum throughput of the connector in Mbps. Default and min is 200. Refers to the expected throughput when using an e2-micro machine type.
    /// Value must be a multiple of 100 from 200 through 900. Must be lower than the value specified by max_throughput.
    /// Only one of &#39;min_throughput&#39; and &#39;min_instances&#39; can be specified. The use of min_throughput is discouraged in favor of min_instances.
    /// </summary>
    public TerraformProperty<double> MinThroughput
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_throughput");
        set => SetProperty("min_throughput", value);
    }

    /// <summary>
    /// The name of the resource (Max 25 characters).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Name or self_link of the VPC network. Required if &#39;ip_cidr_range&#39; is set.
    /// </summary>
    public TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
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
    /// Region where the VPC Access connector resides. If it is not provided, the provider region is used.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subnet block(s) allowed")]
    public List<GoogleVpcAccessConnectorSubnetBlock>? Subnet
    {
        set => SetProperty("subnet", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleVpcAccessConnectorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
