using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in .
/// Nesting mode: list
/// </summary>
public partial class AwsAppmeshVirtualRouterSpecBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_appmesh_virtual_router resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAppmeshVirtualRouter : TerraformResource
{
    public AwsAppmeshVirtualRouter(string name) : base("aws_appmesh_virtual_router", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mesh_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshName is required")]
    [TerraformProperty("mesh_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MeshName { get; set; }

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    [TerraformProperty("mesh_owner")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MeshOwner { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    [TerraformProperty("spec")]
    public TerraformList<TerraformBlock<AwsAppmeshVirtualRouterSpecBlock>>? Spec { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformProperty("last_updated_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedDate { get; }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    [TerraformProperty("resource_owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceOwner { get; }

}
