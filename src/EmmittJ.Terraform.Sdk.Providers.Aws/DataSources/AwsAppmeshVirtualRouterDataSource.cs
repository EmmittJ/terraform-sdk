using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_appmesh_virtual_router.
/// </summary>
public class AwsAppmeshVirtualRouterDataSource : TerraformDataSource
{
    public AwsAppmeshVirtualRouterDataSource(string name) : base("aws_appmesh_virtual_router", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_date");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("resource_owner");
        this.DeclareOutput("spec");
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
    /// The mesh_name attribute.
    /// </summary>
    public TerraformProperty<string>? MeshName
    {
        get => GetProperty<TerraformProperty<string>>("mesh_name");
        set => this.WithProperty("mesh_name", value);
    }

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    public TerraformProperty<string>? MeshOwner
    {
        get => GetProperty<TerraformProperty<string>>("mesh_owner");
        set => this.WithProperty("mesh_owner", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformExpression ResourceOwner => this["resource_owner"];

    /// <summary>
    /// The spec attribute.
    /// </summary>
    public TerraformExpression Spec => this["spec"];

}
