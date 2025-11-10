using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for hierarchy_structure in .
/// Nesting mode: list
/// </summary>
public class AwsConnectUserHierarchyStructureHierarchyStructureBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_connect_user_hierarchy_structure resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConnectUserHierarchyStructure : TerraformResource
{
    public AwsConnectUserHierarchyStructure(string name) : base("aws_connect_user_hierarchy_structure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
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
    /// Block for hierarchy_structure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HierarchyStructure block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HierarchyStructure block(s) allowed")]
    public List<AwsConnectUserHierarchyStructureHierarchyStructureBlock>? HierarchyStructure
    {
        get => GetProperty<List<AwsConnectUserHierarchyStructureHierarchyStructureBlock>>("hierarchy_structure");
        set => this.WithProperty("hierarchy_structure", value);
    }

}
