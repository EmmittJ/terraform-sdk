using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNeptunegraphGraphTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vector_search_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNeptunegraphGraphVectorSearchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the number of dimensions for vector embeddings.  Value must be between 1 and 65,535.
    /// </summary>
    public TerraformProperty<double>? VectorSearchDimension
    {
        get => GetProperty<TerraformProperty<double>>("vector_search_dimension");
        set => WithProperty("vector_search_dimension", value);
    }

}

/// <summary>
/// Manages a aws_neptunegraph_graph resource.
/// </summary>
public class AwsNeptunegraphGraph : TerraformResource
{
    public AwsNeptunegraphGraph(string name) : base("aws_neptunegraph_graph", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("endpoint");
        this.WithOutput("id");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// A value that indicates whether the graph has deletion protection enabled. The graph can&#39;t be deleted when deletion protection is enabled.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The graph name. For example: my-graph-1.
    /// 								The name must contain from 1 to 63 letters, numbers, or hyphens, 
    /// 								and its first character must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
    /// 								If you don&#39;t specify a graph name, a unique graph name is generated for you using the prefix graph-for, 
    /// 								followed by a combination of Stack Name and a UUID.
    /// </summary>
    public TerraformProperty<string>? GraphName
    {
        get => GetProperty<TerraformProperty<string>>("graph_name");
        set => this.WithProperty("graph_name", value);
    }

    /// <summary>
    /// Allows user to specify name prefix and have remainder of name automatically generated.
    /// </summary>
    public TerraformProperty<string>? GraphNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("graph_name_prefix");
        set => this.WithProperty("graph_name_prefix", value);
    }

    /// <summary>
    /// Specifies a KMS key to use to encrypt data in the new graph.  Value must be ARN of KMS Key.
    /// </summary>
    public TerraformProperty<string>? KmsKeyIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_identifier");
        set => this.WithProperty("kms_key_identifier", value);
    }

    /// <summary>
    /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedMemory is required")]
    public required TerraformProperty<double> ProvisionedMemory
    {
        get => GetRequiredProperty<TerraformProperty<double>>("provisioned_memory");
        set => this.WithProperty("provisioned_memory", value);
    }

    /// <summary>
    /// Specifies whether or not the graph can be reachable over the internet. 
    /// 								All access to graphs is IAM authenticated.
    /// 								When the graph is publicly available, its domain name system (DNS) endpoint resolves to 
    /// 								the public IP address from the internet. When the graph isn&#39;t publicly available, you need 
    /// 								to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private 
    /// 								IP address that is reachable from the VPC.
    /// </summary>
    public TerraformProperty<bool>? PublicConnectivity
    {
        get => GetProperty<TerraformProperty<bool>>("public_connectivity");
        set => this.WithProperty("public_connectivity", value);
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
    /// The number of replicas in other AZs.  Value must be between 0 and 2.
    /// </summary>
    public TerraformProperty<double>? ReplicaCount
    {
        get => GetProperty<TerraformProperty<double>>("replica_count");
        set => this.WithProperty("replica_count", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNeptunegraphGraphTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNeptunegraphGraphTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vector_search_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNeptunegraphGraphVectorSearchConfigurationBlock>? VectorSearchConfiguration
    {
        get => GetProperty<List<AwsNeptunegraphGraphVectorSearchConfigurationBlock>>("vector_search_configuration");
        set => this.WithProperty("vector_search_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
