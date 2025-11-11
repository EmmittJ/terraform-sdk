using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3 in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxDataRepositoryAssociationS3Block : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxDataRepositoryAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_fsx_data_repository_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxDataRepositoryAssociation : TerraformResource
{
    public AwsFsxDataRepositoryAssociation(string name) : base("aws_fsx_data_repository_association", name)
    {
    }

    /// <summary>
    /// The batch_import_meta_data_on_create attribute.
    /// </summary>
    [TerraformProperty("batch_import_meta_data_on_create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BatchImportMetaDataOnCreate { get; set; }

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    [TerraformProperty("data_repository_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataRepositoryPath { get; set; }

    /// <summary>
    /// The delete_data_in_filesystem attribute.
    /// </summary>
    [TerraformProperty("delete_data_in_filesystem")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteDataInFilesystem { get; set; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    [TerraformProperty("file_system_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileSystemId { get; set; }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemPath is required")]
    [TerraformProperty("file_system_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FileSystemPath { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    [TerraformProperty("imported_file_chunk_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ImportedFileChunkSize { get; set; }

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
    /// Block for s3.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    [TerraformProperty("s3")]
    public partial TerraformList<TerraformBlock<AwsFsxDataRepositoryAssociationS3Block>>? S3 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsFsxDataRepositoryAssociationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationId { get; }

}
