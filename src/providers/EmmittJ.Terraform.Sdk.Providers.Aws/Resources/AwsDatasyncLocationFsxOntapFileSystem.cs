using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protocol in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationFsxOntapFileSystemProtocolBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_datasync_location_fsx_ontap_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncLocationFsxOntapFileSystem : TerraformResource
{
    public AwsDatasyncLocationFsxOntapFileSystem(string name) : base("aws_datasync_location_fsx_ontap_file_system", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    [TerraformPropertyName("security_group_arns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupArns { get; set; }

    /// <summary>
    /// The storage_virtual_machine_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageVirtualMachineArn is required")]
    [TerraformPropertyName("storage_virtual_machine_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageVirtualMachineArn { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformPropertyName("subdirectory")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Subdirectory { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subdirectory");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for protocol.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Protocol block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protocol block(s) allowed")]
    [TerraformPropertyName("protocol")]
    public TerraformList<TerraformBlock<AwsDatasyncLocationFsxOntapFileSystemProtocolBlock>>? Protocol { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// The fsx_filesystem_arn attribute.
    /// </summary>
    [TerraformPropertyName("fsx_filesystem_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FsxFilesystemArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fsx_filesystem_arn");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uri");

}
