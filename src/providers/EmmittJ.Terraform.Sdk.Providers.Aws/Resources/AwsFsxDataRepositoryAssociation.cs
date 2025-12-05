using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3 in AwsFsxDataRepositoryAssociation.
/// Nesting mode: list
/// </summary>
public class AwsFsxDataRepositoryAssociationS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// AutoExportPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoExportPolicy block(s) allowed")]
    public TerraformList<AwsFsxDataRepositoryAssociationS3BlockAutoExportPolicyBlock>? AutoExportPolicy
    {
        get => GetArgument<TerraformList<AwsFsxDataRepositoryAssociationS3BlockAutoExportPolicyBlock>>("auto_export_policy");
        set => SetArgument("auto_export_policy", value);
    }

    /// <summary>
    /// AutoImportPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoImportPolicy block(s) allowed")]
    public TerraformList<AwsFsxDataRepositoryAssociationS3BlockAutoImportPolicyBlock>? AutoImportPolicy
    {
        get => GetArgument<TerraformList<AwsFsxDataRepositoryAssociationS3BlockAutoImportPolicyBlock>>("auto_import_policy");
        set => SetArgument("auto_import_policy", value);
    }

}

/// <summary>
/// Block type for auto_export_policy in AwsFsxDataRepositoryAssociationS3Block.
/// Nesting mode: list
/// </summary>
public class AwsFsxDataRepositoryAssociationS3BlockAutoExportPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_export_policy";

    /// <summary>
    /// The events attribute.
    /// </summary>
    public TerraformList<string> Events
    {
        get => GetArgument<TerraformList<string>>("events") ?? CreateReference("events");
        set => SetArgument("events", value);
    }

}

/// <summary>
/// Block type for auto_import_policy in AwsFsxDataRepositoryAssociationS3Block.
/// Nesting mode: list
/// </summary>
public class AwsFsxDataRepositoryAssociationS3BlockAutoImportPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_import_policy";

    /// <summary>
    /// The events attribute.
    /// </summary>
    public TerraformList<string> Events
    {
        get => GetArgument<TerraformList<string>>("events") ?? CreateReference("events");
        set => SetArgument("events", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxDataRepositoryAssociation.
/// Nesting mode: single
/// </summary>
public class AwsFsxDataRepositoryAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_fsx_data_repository_association Terraform resource.
/// Manages a aws_fsx_data_repository_association resource.
/// </summary>
public partial class AwsFsxDataRepositoryAssociation(string name) : TerraformResource("aws_fsx_data_repository_association", name)
{
    /// <summary>
    /// The batch_import_meta_data_on_create attribute.
    /// </summary>
    public TerraformValue<bool>? BatchImportMetaDataOnCreate
    {
        get => GetArgument<TerraformValue<bool>>("batch_import_meta_data_on_create");
        set => SetArgument("batch_import_meta_data_on_create", value);
    }

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataRepositoryPath is required")]
    public required TerraformValue<string> DataRepositoryPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_repository_path");
        set => SetArgument("data_repository_path", value);
    }

    /// <summary>
    /// The delete_data_in_filesystem attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteDataInFilesystem
    {
        get => GetArgument<TerraformValue<bool>>("delete_data_in_filesystem");
        set => SetArgument("delete_data_in_filesystem", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemPath is required")]
    public required TerraformValue<string> FileSystemPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_system_path");
        set => SetArgument("file_system_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformValue<double> ImportedFileChunkSize
    {
        get => GetArgument<TerraformValue<double>>("imported_file_chunk_size") ?? CreateReference("imported_file_chunk_size");
        set => SetArgument("imported_file_chunk_size", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => CreateReference("association_id");

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsFsxDataRepositoryAssociationS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsFsxDataRepositoryAssociationS3Block>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxDataRepositoryAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxDataRepositoryAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
