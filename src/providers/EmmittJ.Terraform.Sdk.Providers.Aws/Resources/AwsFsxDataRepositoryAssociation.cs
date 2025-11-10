using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3 in .
/// Nesting mode: list
/// </summary>
public class AwsFsxDataRepositoryAssociationS3Block : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxDataRepositoryAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_fsx_data_repository_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxDataRepositoryAssociation : TerraformResource
{
    public AwsFsxDataRepositoryAssociation(string name) : base("aws_fsx_data_repository_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("association_id");
        SetOutput("batch_import_meta_data_on_create");
        SetOutput("data_repository_path");
        SetOutput("delete_data_in_filesystem");
        SetOutput("file_system_id");
        SetOutput("file_system_path");
        SetOutput("id");
        SetOutput("imported_file_chunk_size");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The batch_import_meta_data_on_create attribute.
    /// </summary>
    public TerraformProperty<bool> BatchImportMetaDataOnCreate
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("batch_import_meta_data_on_create");
        set => SetProperty("batch_import_meta_data_on_create", value);
    }

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    public required TerraformProperty<string> DataRepositoryPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_repository_path");
        set => SetProperty("data_repository_path", value);
    }

    /// <summary>
    /// The delete_data_in_filesystem attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteDataInFilesystem
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_data_in_filesystem");
        set => SetProperty("delete_data_in_filesystem", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformProperty<string> FileSystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_id");
        set => SetProperty("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemPath is required")]
    public required TerraformProperty<string> FileSystemPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_path");
        set => SetProperty("file_system_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformProperty<double> ImportedFileChunkSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("imported_file_chunk_size");
        set => SetProperty("imported_file_chunk_size", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for s3.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public List<AwsFsxDataRepositoryAssociationS3Block>? S3
    {
        set => SetProperty("s3", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxDataRepositoryAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

}
