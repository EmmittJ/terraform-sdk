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
        SetOutput("cluster_versions");
        SetOutput("cluster_type");
        SetOutput("cluster_versions_only");
        SetOutput("default_only");
        SetOutput("include_all");
        SetOutput("region");
        SetOutput("version_status");
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformProperty<string> ClusterType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_type");
        set => SetProperty("cluster_type", value);
    }

    /// <summary>
    /// The cluster_versions_only attribute.
    /// </summary>
    public List<TerraformProperty<string>> ClusterVersionsOnly
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("cluster_versions_only");
        set => SetProperty("cluster_versions_only", value);
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_only");
        set => SetProperty("default_only", value);
    }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeAll
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_all");
        set => SetProperty("include_all", value);
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
    /// The version_status attribute.
    /// </summary>
    public TerraformProperty<string> VersionStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_status");
        set => SetProperty("version_status", value);
    }

    /// <summary>
    /// The cluster_versions attribute.
    /// </summary>
    public TerraformExpression ClusterVersions => this["cluster_versions"];

}
