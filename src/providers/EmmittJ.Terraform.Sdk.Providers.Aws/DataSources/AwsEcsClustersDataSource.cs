using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecs_clusters Terraform data source.
/// Retrieves information about a aws_ecs_clusters.
/// </summary>
public partial class AwsEcsClustersDataSource(string name) : TerraformDataSource("aws_ecs_clusters", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The cluster_arns attribute.
    /// </summary>
    public TerraformList<string> ClusterArns
        => CreateReference("cluster_arns");

}
