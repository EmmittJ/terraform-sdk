using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsRdsClustersDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRdsClustersDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_rds_clusters Terraform data source.
/// Retrieves information about a aws_rds_clusters.
/// </summary>
public partial class AwsRdsClustersDataSource(string name) : TerraformDataSource("aws_rds_clusters", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The cluster_arns attribute.
    /// </summary>
    public TerraformSet<string> ClusterArns
        => AsReference("cluster_arns");

    /// <summary>
    /// The cluster_identifiers attribute.
    /// </summary>
    public TerraformSet<string> ClusterIdentifiers
        => AsReference("cluster_identifiers");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRdsClustersDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsRdsClustersDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
