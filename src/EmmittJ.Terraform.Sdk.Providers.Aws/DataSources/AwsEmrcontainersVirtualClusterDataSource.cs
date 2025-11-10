using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_emrcontainers_virtual_cluster.
/// </summary>
public class AwsEmrcontainersVirtualClusterDataSource : TerraformDataSource
{
    public AwsEmrcontainersVirtualClusterDataSource(string name) : base("aws_emrcontainers_virtual_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("container_provider");
        this.DeclareOutput("created_at");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualClusterId is required")]
    public required TerraformProperty<string> VirtualClusterId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_cluster_id");
        set => this.WithProperty("virtual_cluster_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The container_provider attribute.
    /// </summary>
    public TerraformExpression ContainerProvider => this["container_provider"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
