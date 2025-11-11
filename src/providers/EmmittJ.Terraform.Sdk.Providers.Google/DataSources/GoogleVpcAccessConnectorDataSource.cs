using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vpc_access_connector.
/// </summary>
public partial class GoogleVpcAccessConnectorDataSource : TerraformDataSource
{
    public GoogleVpcAccessConnectorDataSource(string name) : base("google_vpc_access_connector", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the resource (Max 25 characters).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Region where the VPC Access connector resides. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// List of projects using the connector.
    /// </summary>
    [TerraformProperty("connected_projects")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ConnectedProjects { get; }

    /// <summary>
    /// The range of internal addresses that follows RFC 4632 notation. Example: &#39;10.132.0.0/28&#39;.
    /// </summary>
    [TerraformProperty("ip_cidr_range")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpCidrRange { get; }

    /// <summary>
    /// Machine type of VM Instance underlying connector. Default is e2-micro
    /// </summary>
    [TerraformProperty("machine_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MachineType { get; }

    /// <summary>
    /// Maximum value of instances in autoscaling group underlying the connector. Value must be between 3 and 10, inclusive. Must be
    /// higher than the value specified by min_instances. Required alongside &#39;min_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformProperty("max_instances")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxInstances { get; }

    /// <summary>
    /// Maximum throughput of the connector in Mbps, must be greater than &#39;min_throughput&#39;. Default is 300. Refers to the expected throughput
    /// when using an e2-micro machine type. Value must be a multiple of 100 from 300 through 1000. Must be higher than the value specified by
    /// min_throughput. Only one of &#39;max_throughput&#39; and &#39;max_instances&#39; can be specified. The use of max_throughput is discouraged in favor of max_instances.
    /// </summary>
    [TerraformProperty("max_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxThroughput { get; }

    /// <summary>
    /// Minimum value of instances in autoscaling group underlying the connector. Value must be between 2 and 9, inclusive. Must be
    /// lower than the value specified by max_instances. Required alongside &#39;max_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformProperty("min_instances")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MinInstances { get; }

    /// <summary>
    /// Minimum throughput of the connector in Mbps. Default and min is 200. Refers to the expected throughput when using an e2-micro machine type.
    /// Value must be a multiple of 100 from 200 through 900. Must be lower than the value specified by max_throughput.
    /// Only one of &#39;min_throughput&#39; and &#39;min_instances&#39; can be specified. The use of min_throughput is discouraged in favor of min_instances.
    /// </summary>
    [TerraformProperty("min_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MinThroughput { get; }

    /// <summary>
    /// Name or self_link of the VPC network. Required if &#39;ip_cidr_range&#39; is set.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Network { get; }

    /// <summary>
    /// The fully qualified name of this VPC connector
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// State of the VPC access connector.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The subnet in which to house the connector
    /// </summary>
    [TerraformProperty("subnet")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Subnet { get; }

}
