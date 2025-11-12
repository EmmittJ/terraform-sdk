using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVpcAccessConnectorSubnetBlock() : TerraformBlock("subnet")
{
    /// <summary>
    /// Subnet name (relative, not fully qualified). E.g. if the full subnet selfLink is
    /// https://compute.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetName} the correct input for this field would be {subnetName}&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Project in which the subnet exists. If not set, this project is assumed to be the project for which the connector create request was issued.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProjectId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVpcAccessConnectorTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_vpc_access_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVpcAccessConnector : TerraformResource
{
    public GoogleVpcAccessConnector(string name) : base("google_vpc_access_connector", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The range of internal addresses that follows RFC 4632 notation. Example: &#39;10.132.0.0/28&#39;.
    /// </summary>
    [TerraformProperty("ip_cidr_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpCidrRange { get; set; }

    /// <summary>
    /// Machine type of VM Instance underlying connector. Default is e2-micro
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MachineType { get; set; }

    /// <summary>
    /// Maximum value of instances in autoscaling group underlying the connector. Value must be between 3 and 10, inclusive. Must be
    /// higher than the value specified by min_instances. Required alongside &#39;min_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformProperty("max_instances")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxInstances { get; set; }

    /// <summary>
    /// Maximum throughput of the connector in Mbps, must be greater than &#39;min_throughput&#39;. Default is 300. Refers to the expected throughput
    /// when using an e2-micro machine type. Value must be a multiple of 100 from 300 through 1000. Must be higher than the value specified by
    /// min_throughput. Only one of &#39;max_throughput&#39; and &#39;max_instances&#39; can be specified. The use of max_throughput is discouraged in favor of max_instances.
    /// </summary>
    [TerraformProperty("max_throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxThroughput { get; set; }

    /// <summary>
    /// Minimum value of instances in autoscaling group underlying the connector. Value must be between 2 and 9, inclusive. Must be
    /// lower than the value specified by max_instances. Required alongside &#39;max_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformProperty("min_instances")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MinInstances { get; set; }

    /// <summary>
    /// Minimum throughput of the connector in Mbps. Default and min is 200. Refers to the expected throughput when using an e2-micro machine type.
    /// Value must be a multiple of 100 from 200 through 900. Must be lower than the value specified by max_throughput.
    /// Only one of &#39;min_throughput&#39; and &#39;min_instances&#39; can be specified. The use of min_throughput is discouraged in favor of min_instances.
    /// </summary>
    [TerraformProperty("min_throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MinThroughput { get; set; }

    /// <summary>
    /// The name of the resource (Max 25 characters).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Name or self_link of the VPC network. Required if &#39;ip_cidr_range&#39; is set.
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where the VPC Access connector resides. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subnet block(s) allowed")]
    [TerraformProperty("subnet")]
    public TerraformList<GoogleVpcAccessConnectorSubnetBlock> Subnet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleVpcAccessConnectorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// List of projects using the connector.
    /// </summary>
    [TerraformProperty("connected_projects")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ConnectedProjects { get; }

    /// <summary>
    /// The fully qualified name of this VPC connector
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// State of the VPC access connector.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
