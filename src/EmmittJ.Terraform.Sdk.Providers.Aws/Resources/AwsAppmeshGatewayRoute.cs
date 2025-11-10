using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public class AwsAppmeshGatewayRouteSpecBlock : TerraformBlock
{
    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Manages a aws_appmesh_gateway_route resource.
/// </summary>
public class AwsAppmeshGatewayRoute : TerraformResource
{
    public AwsAppmeshGatewayRoute(string name) : base("aws_appmesh_gateway_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_date");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("resource_owner");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshName is required")]
    public required TerraformProperty<string> MeshName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The virtual_gateway_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualGatewayName is required")]
    public required TerraformProperty<string> VirtualGatewayName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_gateway_name");
        set => this.WithProperty("virtual_gateway_name", value);
    }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public List<AwsAppmeshGatewayRouteSpecBlock>? Spec
    {
        get => GetProperty<List<AwsAppmeshGatewayRouteSpecBlock>>("spec");
        set => this.WithProperty("spec", value);
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

}
