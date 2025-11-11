using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsNeptunegraphGraphTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vector_search_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsNeptunegraphGraphVectorSearchConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the number of dimensions for vector embeddings.  Value must be between 1 and 65,535.
    /// </summary>
    [TerraformProperty("vector_search_dimension")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VectorSearchDimension { get; set; }

}

/// <summary>
/// Manages a aws_neptunegraph_graph resource.
/// </summary>
public partial class AwsNeptunegraphGraph : TerraformResource
{
    public AwsNeptunegraphGraph(string name) : base("aws_neptunegraph_graph", name)
    {
    }

    /// <summary>
    /// A value that indicates whether the graph has deletion protection enabled. The graph can&#39;t be deleted when deletion protection is enabled.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DeletionProtection { get; set; }

    /// <summary>
    /// The graph name. For example: my-graph-1.
    /// 								The name must contain from 1 to 63 letters, numbers, or hyphens, 
    /// 								and its first character must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
    /// 								If you don&#39;t specify a graph name, a unique graph name is generated for you using the prefix graph-for, 
    /// 								followed by a combination of Stack Name and a UUID.
    /// </summary>
    [TerraformProperty("graph_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GraphName { get; set; }

    /// <summary>
    /// Allows user to specify name prefix and have remainder of name automatically generated.
    /// </summary>
    [TerraformProperty("graph_name_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GraphNamePrefix { get; set; }

    /// <summary>
    /// Specifies a KMS key to use to encrypt data in the new graph.  Value must be ARN of KMS Key.
    /// </summary>
    [TerraformProperty("kms_key_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedMemory is required")]
    [TerraformProperty("provisioned_memory")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ProvisionedMemory { get; set; }

    /// <summary>
    /// Specifies whether or not the graph can be reachable over the internet. 
    /// 								All access to graphs is IAM authenticated.
    /// 								When the graph is publicly available, its domain name system (DNS) endpoint resolves to 
    /// 								the public IP address from the internet. When the graph isn&#39;t publicly available, you need 
    /// 								to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private 
    /// 								IP address that is reachable from the VPC.
    /// </summary>
    [TerraformProperty("public_connectivity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PublicConnectivity { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The number of replicas in other AZs.  Value must be between 0 and 2.
    /// </summary>
    [TerraformProperty("replica_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ReplicaCount { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsNeptunegraphGraphTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vector_search_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("vector_search_configuration")]
    public partial TerraformList<TerraformBlock<AwsNeptunegraphGraphVectorSearchConfigurationBlock>>? VectorSearchConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
