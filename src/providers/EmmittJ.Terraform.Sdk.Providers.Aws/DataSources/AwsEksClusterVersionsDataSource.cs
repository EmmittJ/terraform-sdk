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
        get => GetArgument<TerraformValue<string>>("cluster_type");
        set => SetArgument("cluster_type", value);
    }

    /// <summary>
    /// The cluster_versions_only attribute.
    /// </summary>
    public TerraformList<string>? ClusterVersionsOnly
    {
        get => GetArgument<TerraformList<string>>("cluster_versions_only");
        set => SetArgument("cluster_versions_only", value);
    }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultOnly
    {
        get => GetArgument<TerraformValue<bool>>("default_only");
        set => SetArgument("default_only", value);
    }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeAll
    {
        get => GetArgument<TerraformValue<bool>>("include_all");
        set => SetArgument("include_all", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version_status attribute.
    /// </summary>
    public TerraformValue<string>? VersionStatus
    {
        get => GetArgument<TerraformValue<string>>("version_status");
        set => SetArgument("version_status", value);
    }

    /// <summary>
    /// The cluster_versions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterVersions
        => AsReference("cluster_versions");

}
