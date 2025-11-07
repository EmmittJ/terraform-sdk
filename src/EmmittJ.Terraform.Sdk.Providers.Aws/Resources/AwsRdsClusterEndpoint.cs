using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster_endpoint resource.
/// </summary>
public class AwsRdsClusterEndpoint : TerraformResource
{
    public AwsRdsClusterEndpoint(string name) : base("aws_rds_cluster_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
    }

    /// <summary>
    /// The cluster_endpoint_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterEndpointIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_endpoint_identifier");
        set => this.WithProperty("cluster_endpoint_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The custom_endpoint_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomEndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_endpoint_type");
        set => this.WithProperty("custom_endpoint_type", value);
    }

    /// <summary>
    /// The excluded_members attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ExcludedMembers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("excluded_members");
        set => this.WithProperty("excluded_members", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The static_members attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? StaticMembers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("static_members");
        set => this.WithProperty("static_members", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

}
