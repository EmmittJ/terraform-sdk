using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_appmesh_route.
/// </summary>
public partial class AwsAppmeshRouteDataSource : TerraformDataSource
{
    public AwsAppmeshRouteDataSource(string name) : base("aws_appmesh_route", name)
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
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The virtual_router_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualRouterName is required")]
    [TerraformProperty("virtual_router_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualRouterName { get; set; }

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

    /// <summary>
    /// The spec attribute.
    /// </summary>
    [TerraformProperty("spec")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Spec { get; }

}
