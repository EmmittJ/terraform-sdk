using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vpc_access_connector.
/// </summary>
public class GoogleVpcAccessConnectorDataSource : TerraformDataSource
{
    public GoogleVpcAccessConnectorDataSource(string name) : base("google_vpc_access_connector", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the resource (Max 25 characters).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Region where the VPC Access connector resides. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// List of projects using the connector.
    /// </summary>
    [TerraformPropertyName("connected_projects")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ConnectedProjects => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "connected_projects");

    /// <summary>
    /// The range of internal addresses that follows RFC 4632 notation. Example: &#39;10.132.0.0/28&#39;.
    /// </summary>
    [TerraformPropertyName("ip_cidr_range")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpCidrRange => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_cidr_range");

    /// <summary>
    /// Machine type of VM Instance underlying connector. Default is e2-micro
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MachineType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "machine_type");

    /// <summary>
    /// Maximum value of instances in autoscaling group underlying the connector. Value must be between 3 and 10, inclusive. Must be
    /// higher than the value specified by min_instances. Required alongside &#39;min_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformPropertyName("max_instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxInstances => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_instances");

    /// <summary>
    /// Maximum throughput of the connector in Mbps, must be greater than &#39;min_throughput&#39;. Default is 300. Refers to the expected throughput
    /// when using an e2-micro machine type. Value must be a multiple of 100 from 300 through 1000. Must be higher than the value specified by
    /// min_throughput. Only one of &#39;max_throughput&#39; and &#39;max_instances&#39; can be specified. The use of max_throughput is discouraged in favor of max_instances.
    /// </summary>
    [TerraformPropertyName("max_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_throughput");

    /// <summary>
    /// Minimum value of instances in autoscaling group underlying the connector. Value must be between 2 and 9, inclusive. Must be
    /// lower than the value specified by max_instances. Required alongside &#39;max_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformPropertyName("min_instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinInstances => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_instances");

    /// <summary>
    /// Minimum throughput of the connector in Mbps. Default and min is 200. Refers to the expected throughput when using an e2-micro machine type.
    /// Value must be a multiple of 100 from 200 through 900. Must be lower than the value specified by max_throughput.
    /// Only one of &#39;min_throughput&#39; and &#39;min_instances&#39; can be specified. The use of min_throughput is discouraged in favor of min_instances.
    /// </summary>
    [TerraformPropertyName("min_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_throughput");

    /// <summary>
    /// Name or self_link of the VPC network. Required if &#39;ip_cidr_range&#39; is set.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The fully qualified name of this VPC connector
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// State of the VPC access connector.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The subnet in which to house the connector
    /// </summary>
    [TerraformPropertyName("subnet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Subnet => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "subnet");

}
