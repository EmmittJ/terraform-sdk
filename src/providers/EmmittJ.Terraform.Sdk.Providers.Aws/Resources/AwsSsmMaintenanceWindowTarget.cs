using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmMaintenanceWindowTargetTargetsBlock() : TerraformBlock("targets")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Manages a aws_ssm_maintenance_window_target resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmMaintenanceWindowTarget : TerraformResource
{
    public AwsSsmMaintenanceWindowTarget(string name) : base("aws_ssm_maintenance_window_target", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The owner_information attribute.
    /// </summary>
    [TerraformProperty("owner_information")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OwnerInformation { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The window_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowId is required")]
    [TerraformProperty("window_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WindowId { get; set; }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Targets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Targets block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    [TerraformProperty("targets")]
    public required TerraformList<AwsSsmMaintenanceWindowTargetTargetsBlock> Targets { get; set; } = new();

}
