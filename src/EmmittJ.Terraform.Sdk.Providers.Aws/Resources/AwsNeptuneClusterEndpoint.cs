using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_neptune_cluster_endpoint resource.
/// </summary>
public class AwsNeptuneClusterEndpoint : TerraformResource
{
    public AwsNeptuneClusterEndpoint(string name) : base("aws_neptune_cluster_endpoint", name)
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
    public TerraformProperty<string>? ClusterEndpointIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_endpoint_identifier");
        set => this.WithProperty("cluster_endpoint_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => this.WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The excluded_members attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ExcludedMembers
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("excluded_members");
        set => this.WithProperty("excluded_members", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The static_members attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? StaticMembers
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("static_members");
        set => this.WithProperty("static_members", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
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
