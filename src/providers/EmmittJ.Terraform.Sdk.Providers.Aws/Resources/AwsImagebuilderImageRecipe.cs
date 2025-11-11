using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderImageRecipeBlockDeviceMappingBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [TerraformPropertyName("device_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeviceName { get; set; }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    [TerraformPropertyName("no_device")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> NoDevice { get; set; } = default!;

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [TerraformPropertyName("virtual_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualName { get; set; }

}

/// <summary>
/// Block type for component in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageRecipeComponentBlock
{
    /// <summary>
    /// The component_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentArn is required")]
    [TerraformPropertyName("component_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ComponentArn { get; set; }

}

/// <summary>
/// Block type for systems_manager_agent in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageRecipeSystemsManagerAgentBlock
{
    /// <summary>
    /// The uninstall_after_build attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UninstallAfterBuild is required")]
    [TerraformPropertyName("uninstall_after_build")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> UninstallAfterBuild { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_image_recipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderImageRecipe : TerraformResource
{
    public AwsImagebuilderImageRecipe(string name) : base("aws_imagebuilder_image_recipe", name)
    {
    }

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    [TerraformPropertyName("ami_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? AmiTags { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    [TerraformPropertyName("parent_image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ParentImage { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserDataBase64 { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformPropertyName("working_directory")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WorkingDirectory { get; set; }

    /// <summary>
    /// Block for block_device_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("block_device_mapping")]
    public TerraformSet<TerraformBlock<AwsImagebuilderImageRecipeBlockDeviceMappingBlock>>? BlockDeviceMapping { get; set; }

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    [TerraformPropertyName("component")]
    public TerraformList<TerraformBlock<AwsImagebuilderImageRecipeComponentBlock>>? Component { get; set; }

    /// <summary>
    /// Block for systems_manager_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemsManagerAgent block(s) allowed")]
    [TerraformPropertyName("systems_manager_agent")]
    public TerraformList<TerraformBlock<AwsImagebuilderImageRecipeSystemsManagerAgentBlock>>? SystemsManagerAgent { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateCreated => new TerraformReference(this, "date_created");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Platform => new TerraformReference(this, "platform");

}
