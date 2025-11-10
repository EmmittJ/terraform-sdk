using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class GoogleVpcAccessConnectorSubnetBlock : ITerraformBlock
{
    /// <summary>
    /// Subnet name (relative, not fully qualified). E.g. if the full subnet selfLink is
    /// https://compute.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetName} the correct input for this field would be {subnetName}&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Project in which the subnet exists. If not set, this project is assumed to be the project for which the connector create request was issued.
    /// </summary>
    [TerraformPropertyName("project_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "project_id");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleVpcAccessConnectorTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_vpc_access_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleVpcAccessConnector : TerraformResource
{
    public GoogleVpcAccessConnector(string name) : base("google_vpc_access_connector", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The range of internal addresses that follows RFC 4632 notation. Example: &#39;10.132.0.0/28&#39;.
    /// </summary>
    [TerraformPropertyName("ip_cidr_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpCidrRange { get; set; }

    /// <summary>
    /// Machine type of VM Instance underlying connector. Default is e2-micro
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MachineType { get; set; }

    /// <summary>
    /// Maximum value of instances in autoscaling group underlying the connector. Value must be between 3 and 10, inclusive. Must be
    /// higher than the value specified by min_instances. Required alongside &#39;min_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformPropertyName("max_instances")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxInstances { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_instances");

    /// <summary>
    /// Maximum throughput of the connector in Mbps, must be greater than &#39;min_throughput&#39;. Default is 300. Refers to the expected throughput
    /// when using an e2-micro machine type. Value must be a multiple of 100 from 300 through 1000. Must be higher than the value specified by
    /// min_throughput. Only one of &#39;max_throughput&#39; and &#39;max_instances&#39; can be specified. The use of max_throughput is discouraged in favor of max_instances.
    /// </summary>
    [TerraformPropertyName("max_throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxThroughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_throughput");

    /// <summary>
    /// Minimum value of instances in autoscaling group underlying the connector. Value must be between 2 and 9, inclusive. Must be
    /// lower than the value specified by max_instances. Required alongside &#39;max_instances&#39; if not using &#39;min_throughput&#39;/&#39;max_throughput&#39;.
    /// </summary>
    [TerraformPropertyName("min_instances")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinInstances { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_instances");

    /// <summary>
    /// Minimum throughput of the connector in Mbps. Default and min is 200. Refers to the expected throughput when using an e2-micro machine type.
    /// Value must be a multiple of 100 from 200 through 900. Must be lower than the value specified by max_throughput.
    /// Only one of &#39;min_throughput&#39; and &#39;min_instances&#39; can be specified. The use of min_throughput is discouraged in favor of min_instances.
    /// </summary>
    [TerraformPropertyName("min_throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MinThroughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_throughput");

    /// <summary>
    /// The name of the resource (Max 25 characters).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Name or self_link of the VPC network. Required if &#39;ip_cidr_range&#39; is set.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Network { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Region where the VPC Access connector resides. If it is not provided, the provider region is used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subnet block(s) allowed")]
    [TerraformPropertyName("subnet")]
    public TerraformList<TerraformBlock<GoogleVpcAccessConnectorSubnetBlock>>? Subnet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleVpcAccessConnectorTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// List of projects using the connector.
    /// </summary>
    [TerraformPropertyName("connected_projects")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ConnectedProjects => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "connected_projects");

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

}
