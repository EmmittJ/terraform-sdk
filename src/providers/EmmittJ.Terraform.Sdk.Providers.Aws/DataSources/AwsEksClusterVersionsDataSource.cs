using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_cluster_versions.
/// </summary>
public class AwsEksClusterVersionsDataSource : TerraformDataSource
{
    public AwsEksClusterVersionsDataSource(string name) : base("aws_eks_cluster_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_versions");
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterType
    {
        get => GetProperty<TerraformProperty<string>>("cluster_type");
        set => this.WithProperty("cluster_type", value);
    }

    /// <summary>
    /// The cluster_versions_only attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ClusterVersionsOnly
    {
        get => GetProperty<List<TerraformProperty<string>>>("cluster_versions_only");
        set => this.WithProperty("cluster_versions_only", value);
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultOnly
    {
        get => GetProperty<TerraformProperty<bool>>("default_only");
        set => this.WithProperty("default_only", value);
    }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeAll
    {
        get => GetProperty<TerraformProperty<bool>>("include_all");
        set => this.WithProperty("include_all", value);
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
    /// The version_status attribute.
    /// </summary>
    public TerraformProperty<string>? VersionStatus
    {
        get => GetProperty<TerraformProperty<string>>("version_status");
        set => this.WithProperty("version_status", value);
    }

    /// <summary>
    /// The cluster_versions attribute.
    /// </summary>
    public TerraformExpression ClusterVersions => this["cluster_versions"];

}
