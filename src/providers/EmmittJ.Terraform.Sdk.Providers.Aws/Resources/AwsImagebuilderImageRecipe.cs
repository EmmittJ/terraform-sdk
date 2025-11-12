using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mapping in .
/// Nesting mode: set
/// </summary>
public partial class AwsImagebuilderImageRecipeBlockDeviceMappingBlock() : TerraformBlock("block_device_mapping")
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformProperty("device_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformProperty("no_device")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> NoDevice { get; set; }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformProperty("virtual_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for component in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImageRecipeComponentBlock() : TerraformBlock("component")
{
    /// <summary>
    /// The component_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentArn is required")]
    [TerraformProperty("component_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ComponentArn { get; set; }

}

/// <summary>
/// Block type for systems_manager_agent in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderImageRecipeSystemsManagerAgentBlock() : TerraformBlock("systems_manager_agent")
{
    /// <summary>
    /// The uninstall_after_build attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UninstallAfterBuild is required")]
    [TerraformProperty("uninstall_after_build")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> UninstallAfterBuild { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_image_recipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsImagebuilderImageRecipe : TerraformResource
{
    public AwsImagebuilderImageRecipe(string name) : base("aws_imagebuilder_image_recipe", name)
    {
    }

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    [TerraformProperty("ami_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AmiTags { get; set; }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    [TerraformProperty("parent_image")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParentImage { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformProperty("user_data_base64")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserDataBase64 { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformProperty("working_directory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkingDirectory { get; set; }

    /// <summary>
    /// Block for block_device_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("block_device_mapping")]
    public TerraformSet<AwsImagebuilderImageRecipeBlockDeviceMappingBlock> BlockDeviceMapping { get; set; } = new();

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    [TerraformProperty("component")]
    public required TerraformList<AwsImagebuilderImageRecipeComponentBlock> Component { get; set; } = new();

    /// <summary>
    /// Block for systems_manager_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemsManagerAgent block(s) allowed")]
    [TerraformProperty("systems_manager_agent")]
    public TerraformList<AwsImagebuilderImageRecipeSystemsManagerAgentBlock> SystemsManagerAgent { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Owner { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Platform { get; }

}
