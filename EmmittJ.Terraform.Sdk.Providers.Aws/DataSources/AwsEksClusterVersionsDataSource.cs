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
    public string? ClusterType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_type")?.Value;
        set => this.WithProperty("cluster_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_versions_only attribute.
    /// </summary>
    public List<string>? ClusterVersionsOnly
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cluster_versions_only")?.Value;
        set => this.WithProperty("cluster_versions_only", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public bool? DefaultOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_only")?.Value;
        set => this.WithProperty("default_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    public bool? IncludeAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_all")?.Value;
        set => this.WithProperty("include_all", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_status attribute.
    /// </summary>
    public string? VersionStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_status")?.Value;
        set => this.WithProperty("version_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_versions attribute.
    /// </summary>
    public TerraformExpression ClusterVersions => this["cluster_versions"];

}
