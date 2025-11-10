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
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("cluster_endpoint_identifier");
        SetOutput("cluster_identifier");
        SetOutput("custom_endpoint_type");
        SetOutput("excluded_members");
        SetOutput("id");
        SetOutput("region");
        SetOutput("static_members");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The cluster_endpoint_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterEndpointIdentifier is required")]
    public required TerraformProperty<string> ClusterEndpointIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_endpoint_identifier");
        set => SetProperty("cluster_endpoint_identifier", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The custom_endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomEndpointType is required")]
    public required TerraformProperty<string> CustomEndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_endpoint_type");
        set => SetProperty("custom_endpoint_type", value);
    }

    /// <summary>
    /// The excluded_members attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExcludedMembers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("excluded_members");
        set => SetProperty("excluded_members", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The static_members attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> StaticMembers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("static_members");
        set => SetProperty("static_members", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
