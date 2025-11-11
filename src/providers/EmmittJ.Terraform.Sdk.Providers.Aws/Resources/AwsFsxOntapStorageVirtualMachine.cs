using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for active_directory_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The netbios_name attribute.
    /// </summary>
    [TerraformProperty("netbios_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetbiosName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxOntapStorageVirtualMachineTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_fsx_ontap_storage_virtual_machine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxOntapStorageVirtualMachine : TerraformResource
{
    public AwsFsxOntapStorageVirtualMachine(string name) : base("aws_fsx_ontap_storage_virtual_machine", name)
    {
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    [TerraformProperty("file_system_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FileSystemId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// The root_volume_security_style attribute.
    /// </summary>
    [TerraformProperty("root_volume_security_style")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RootVolumeSecurityStyle { get; set; }

    /// <summary>
    /// The svm_admin_password attribute.
    /// </summary>
    [TerraformProperty("svm_admin_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SvmAdminPassword { get; set; }

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
    /// Block for active_directory_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryConfiguration block(s) allowed")]
    [TerraformProperty("active_directory_configuration")]
    public TerraformList<TerraformBlock<AwsFsxOntapStorageVirtualMachineActiveDirectoryConfigurationBlock>>? ActiveDirectoryConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsFsxOntapStorageVirtualMachineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Endpoints { get; }

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    [TerraformProperty("subtype")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Subtype { get; }

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    [TerraformProperty("uuid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uuid { get; }

}
