using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_node_groups.
/// </summary>
public class AwsEksNodeGroupsDataSource : TerraformDataSource
{
    public AwsEksNodeGroupsDataSource(string name) : base("aws_eks_node_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("names");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
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
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

}
