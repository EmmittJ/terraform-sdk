using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_eks_cluster_versions Terraform data source.
/// Retrieves information about a aws_eks_cluster_versions.
/// </summary>
public partial class AwsEksClusterVersionsDataSource(string name) : TerraformDataSource("aws_eks_cluster_versions", name)
{
    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string>? ClusterType
    {
        get => new TerraformReference<string>(this, "cluster_type");
        set => SetArgument("cluster_type", value);
    }

    /// <summary>
    /// The cluster_versions_only attribute.
    /// </summary>
    public TerraformList<string>? ClusterVersionsOnly
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cluster_versions_only").ResolveNodes(ctx));
        set => SetArgument("cluster_versions_only", value);
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultOnly
    {
        get => new TerraformReference<bool>(this, "default_only");
        set => SetArgument("default_only", value);
    }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeAll
    {
        get => new TerraformReference<bool>(this, "include_all");
        set => SetArgument("include_all", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version_status attribute.
    /// </summary>
    public TerraformValue<string>? VersionStatus
    {
        get => new TerraformReference<string>(this, "version_status");
        set => SetArgument("version_status", value);
    }

    /// <summary>
    /// The cluster_versions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterVersions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_versions").ResolveNodes(ctx));
    }

}
