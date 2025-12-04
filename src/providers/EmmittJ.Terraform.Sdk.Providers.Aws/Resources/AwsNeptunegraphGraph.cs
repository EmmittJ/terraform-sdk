using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNeptunegraphGraph.
/// Nesting mode: single
/// </summary>
public class AwsNeptunegraphGraphTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vector_search_configuration in AwsNeptunegraphGraph.
/// Nesting mode: list
/// </summary>
public class AwsNeptunegraphGraphVectorSearchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vector_search_configuration";

    /// <summary>
    /// Specifies the number of dimensions for vector embeddings.  Value must be between 1 and 65,535.
    /// </summary>
    public TerraformValue<double>? VectorSearchDimension
    {
        get => GetArgument<TerraformValue<double>>("vector_search_dimension");
        set => SetArgument("vector_search_dimension", value);
    }

}


/// <summary>
/// Represents a aws_neptunegraph_graph Terraform resource.
/// Manages a aws_neptunegraph_graph resource.
/// </summary>
public partial class AwsNeptunegraphGraph(string name) : TerraformResource("aws_neptunegraph_graph", name)
{
    /// <summary>
    /// A value that indicates whether the graph has deletion protection enabled. The graph can&#39;t be deleted when deletion protection is enabled.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The graph name. For example: my-graph-1.
    /// 								The name must contain from 1 to 63 letters, numbers, or hyphens, 
    /// 								and its first character must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
    /// 								If you don&#39;t specify a graph name, a unique graph name is generated for you using the prefix graph-for, 
    /// 								followed by a combination of Stack Name and a UUID.
    /// </summary>
    public TerraformValue<string>? GraphName
    {
        get => GetArgument<TerraformValue<string>>("graph_name");
        set => SetArgument("graph_name", value);
    }

    /// <summary>
    /// Allows user to specify name prefix and have remainder of name automatically generated.
    /// </summary>
    public TerraformValue<string>? GraphNamePrefix
    {
        get => GetArgument<TerraformValue<string>>("graph_name_prefix");
        set => SetArgument("graph_name_prefix", value);
    }

    /// <summary>
    /// Specifies a KMS key to use to encrypt data in the new graph.  Value must be ARN of KMS Key.
    /// </summary>
    public TerraformValue<string>? KmsKeyIdentifier
    {
        get => GetArgument<TerraformValue<string>>("kms_key_identifier");
        set => SetArgument("kms_key_identifier", value);
    }

    /// <summary>
    /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedMemory is required")]
    public required TerraformValue<double> ProvisionedMemory
    {
        get => GetArgument<TerraformValue<double>>("provisioned_memory");
        set => SetArgument("provisioned_memory", value);
    }

    /// <summary>
    /// Specifies whether or not the graph can be reachable over the internet. 
    /// 								All access to graphs is IAM authenticated.
    /// 								When the graph is publicly available, its domain name system (DNS) endpoint resolves to 
    /// 								the public IP address from the internet. When the graph isn&#39;t publicly available, you need 
    /// 								to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private 
    /// 								IP address that is reachable from the VPC.
    /// </summary>
    public TerraformValue<bool>? PublicConnectivity
    {
        get => GetArgument<TerraformValue<bool>>("public_connectivity");
        set => SetArgument("public_connectivity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The number of replicas in other AZs.  Value must be between 0 and 2.
    /// </summary>
    public TerraformValue<double>? ReplicaCount
    {
        get => GetArgument<TerraformValue<double>>("replica_count");
        set => SetArgument("replica_count", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNeptunegraphGraphTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNeptunegraphGraphTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VectorSearchConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNeptunegraphGraphVectorSearchConfigurationBlock>? VectorSearchConfiguration
    {
        get => GetArgument<TerraformList<AwsNeptunegraphGraphVectorSearchConfigurationBlock>>("vector_search_configuration");
        set => SetArgument("vector_search_configuration", value);
    }

}
