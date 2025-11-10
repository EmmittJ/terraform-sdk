using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNeptunegraphGraphTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vector_search_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNeptunegraphGraphVectorSearchConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the number of dimensions for vector embeddings.  Value must be between 1 and 65,535.
    /// </summary>
    [TerraformPropertyName("vector_search_dimension")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VectorSearchDimension { get; set; }

}

/// <summary>
/// Manages a aws_neptunegraph_graph resource.
/// </summary>
public class AwsNeptunegraphGraph : TerraformResource
{
    public AwsNeptunegraphGraph(string name) : base("aws_neptunegraph_graph", name)
    {
    }

    /// <summary>
    /// A value that indicates whether the graph has deletion protection enabled. The graph can&#39;t be deleted when deletion protection is enabled.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// The graph name. For example: my-graph-1.
    /// 								The name must contain from 1 to 63 letters, numbers, or hyphens, 
    /// 								and its first character must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
    /// 								If you don&#39;t specify a graph name, a unique graph name is generated for you using the prefix graph-for, 
    /// 								followed by a combination of Stack Name and a UUID.
    /// </summary>
    [TerraformPropertyName("graph_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GraphName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "graph_name");

    /// <summary>
    /// Allows user to specify name prefix and have remainder of name automatically generated.
    /// </summary>
    [TerraformPropertyName("graph_name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GraphNamePrefix { get; set; }

    /// <summary>
    /// Specifies a KMS key to use to encrypt data in the new graph.  Value must be ARN of KMS Key.
    /// </summary>
    [TerraformPropertyName("kms_key_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_identifier");

    /// <summary>
    /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedMemory is required")]
    [TerraformPropertyName("provisioned_memory")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ProvisionedMemory { get; set; }

    /// <summary>
    /// Specifies whether or not the graph can be reachable over the internet. 
    /// 								All access to graphs is IAM authenticated.
    /// 								When the graph is publicly available, its domain name system (DNS) endpoint resolves to 
    /// 								the public IP address from the internet. When the graph isn&#39;t publicly available, you need 
    /// 								to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private 
    /// 								IP address that is reachable from the VPC.
    /// </summary>
    [TerraformPropertyName("public_connectivity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PublicConnectivity { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public_connectivity");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The number of replicas in other AZs.  Value must be between 0 and 2.
    /// </summary>
    [TerraformPropertyName("replica_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ReplicaCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "replica_count");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNeptunegraphGraphTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vector_search_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("vector_search_configuration")]
    public TerraformList<TerraformBlock<AwsNeptunegraphGraphVectorSearchConfigurationBlock>>? VectorSearchConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
