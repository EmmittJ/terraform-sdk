using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for on_exception_steps in AwsTransferWorkflow.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_exception_steps";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// CopyStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlock>? CopyStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlock>>("copy_step_details");
        set => SetArgument("copy_step_details", value);
    }

    /// <summary>
    /// CustomStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCustomStepDetailsBlock>? CustomStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCustomStepDetailsBlock>>("custom_step_details");
        set => SetArgument("custom_step_details", value);
    }

    /// <summary>
    /// DecryptStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DecryptStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlock>? DecryptStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlock>>("decrypt_step_details");
        set => SetArgument("decrypt_step_details", value);
    }

    /// <summary>
    /// DeleteStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDeleteStepDetailsBlock>? DeleteStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDeleteStepDetailsBlock>>("delete_step_details");
        set => SetArgument("delete_step_details", value);
    }

    /// <summary>
    /// TagStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockTagStepDetailsBlock>? TagStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockTagStepDetailsBlock>>("tag_step_details");
        set => SetArgument("tag_step_details", value);
    }

}

/// <summary>
/// Block type for copy_step_details in AwsTransferWorkflowOnExceptionStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "copy_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overwrite_existing attribute.
    /// </summary>
    public TerraformValue<string>? OverwriteExisting
    {
        get => GetArgument<TerraformValue<string>>("overwrite_existing");
        set => SetArgument("overwrite_existing", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// DestinationFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock>? DestinationFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock>>("destination_file_location");
        set => SetArgument("destination_file_location", value);
    }

}

/// <summary>
/// Block type for destination_file_location in AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_file_location";

    /// <summary>
    /// EfsFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>? EfsFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>>("efs_file_location");
        set => SetArgument("efs_file_location", value);
    }

    /// <summary>
    /// S3FileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3FileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>? S3FileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>>("s3_file_location");
        set => SetArgument("s3_file_location", value);
    }

}

/// <summary>
/// Block type for efs_file_location in AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_file_location";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for s3_file_location in AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_file_location";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for custom_step_details in AwsTransferWorkflowOnExceptionStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockCustomStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

}

/// <summary>
/// Block type for decrypt_step_details in AwsTransferWorkflowOnExceptionStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "decrypt_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overwrite_existing attribute.
    /// </summary>
    public TerraformValue<string>? OverwriteExisting
    {
        get => GetArgument<TerraformValue<string>>("overwrite_existing");
        set => SetArgument("overwrite_existing", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// DestinationFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock>? DestinationFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock>>("destination_file_location");
        set => SetArgument("destination_file_location", value);
    }

}

/// <summary>
/// Block type for destination_file_location in AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_file_location";

    /// <summary>
    /// EfsFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>? EfsFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>>("efs_file_location");
        set => SetArgument("efs_file_location", value);
    }

    /// <summary>
    /// S3FileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3FileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>? S3FileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>>("s3_file_location");
        set => SetArgument("s3_file_location", value);
    }

}

/// <summary>
/// Block type for efs_file_location in AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_file_location";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for s3_file_location in AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_file_location";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for delete_step_details in AwsTransferWorkflowOnExceptionStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockDeleteStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delete_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

}

/// <summary>
/// Block type for tag_step_details in AwsTransferWorkflowOnExceptionStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockTagStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Tags block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlockTagStepDetailsBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlockTagStepDetailsBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tags in AwsTransferWorkflowOnExceptionStepsBlockTagStepDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowOnExceptionStepsBlockTagStepDetailsBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for steps in AwsTransferWorkflow.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "steps";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// CopyStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CopyStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlock>? CopyStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlock>>("copy_step_details");
        set => SetArgument("copy_step_details", value);
    }

    /// <summary>
    /// CustomStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockCustomStepDetailsBlock>? CustomStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockCustomStepDetailsBlock>>("custom_step_details");
        set => SetArgument("custom_step_details", value);
    }

    /// <summary>
    /// DecryptStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DecryptStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlock>? DecryptStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlock>>("decrypt_step_details");
        set => SetArgument("decrypt_step_details", value);
    }

    /// <summary>
    /// DeleteStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockDeleteStepDetailsBlock>? DeleteStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockDeleteStepDetailsBlock>>("delete_step_details");
        set => SetArgument("delete_step_details", value);
    }

    /// <summary>
    /// TagStepDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagStepDetails block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockTagStepDetailsBlock>? TagStepDetails
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockTagStepDetailsBlock>>("tag_step_details");
        set => SetArgument("tag_step_details", value);
    }

}

/// <summary>
/// Block type for copy_step_details in AwsTransferWorkflowStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockCopyStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "copy_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overwrite_existing attribute.
    /// </summary>
    public TerraformValue<string>? OverwriteExisting
    {
        get => GetArgument<TerraformValue<string>>("overwrite_existing");
        set => SetArgument("overwrite_existing", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// DestinationFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock>? DestinationFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock>>("destination_file_location");
        set => SetArgument("destination_file_location", value);
    }

}

/// <summary>
/// Block type for destination_file_location in AwsTransferWorkflowStepsBlockCopyStepDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_file_location";

    /// <summary>
    /// EfsFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>? EfsFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>>("efs_file_location");
        set => SetArgument("efs_file_location", value);
    }

    /// <summary>
    /// S3FileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3FileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>? S3FileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>>("s3_file_location");
        set => SetArgument("s3_file_location", value);
    }

}

/// <summary>
/// Block type for efs_file_location in AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_file_location";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for s3_file_location in AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockCopyStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_file_location";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for custom_step_details in AwsTransferWorkflowStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockCustomStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

}

/// <summary>
/// Block type for decrypt_step_details in AwsTransferWorkflowStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockDecryptStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "decrypt_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The overwrite_existing attribute.
    /// </summary>
    public TerraformValue<string>? OverwriteExisting
    {
        get => GetArgument<TerraformValue<string>>("overwrite_existing");
        set => SetArgument("overwrite_existing", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// DestinationFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock>? DestinationFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock>>("destination_file_location");
        set => SetArgument("destination_file_location", value);
    }

}

/// <summary>
/// Block type for destination_file_location in AwsTransferWorkflowStepsBlockDecryptStepDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_file_location";

    /// <summary>
    /// EfsFileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsFileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>? EfsFileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock>>("efs_file_location");
        set => SetArgument("efs_file_location", value);
    }

    /// <summary>
    /// S3FileLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3FileLocation block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>? S3FileLocation
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock>>("s3_file_location");
        set => SetArgument("s3_file_location", value);
    }

}

/// <summary>
/// Block type for efs_file_location in AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockEfsFileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_file_location";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemId
    {
        get => GetArgument<TerraformValue<string>>("file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for s3_file_location in AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockDecryptStepDetailsBlockDestinationFileLocationBlockS3FileLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_file_location";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for delete_step_details in AwsTransferWorkflowStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockDeleteStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delete_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

}

/// <summary>
/// Block type for tag_step_details in AwsTransferWorkflowStepsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockTagStepDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_step_details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_file_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceFileLocation
    {
        get => GetArgument<TerraformValue<string>>("source_file_location");
        set => SetArgument("source_file_location", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Tags block(s) allowed")]
    public TerraformList<AwsTransferWorkflowStepsBlockTagStepDetailsBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowStepsBlockTagStepDetailsBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for tags in AwsTransferWorkflowStepsBlockTagStepDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWorkflowStepsBlockTagStepDetailsBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_transfer_workflow Terraform resource.
/// Manages a aws_transfer_workflow resource.
/// </summary>
public partial class AwsTransferWorkflow(string name) : TerraformResource("aws_transfer_workflow", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// OnExceptionSteps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 OnExceptionSteps block(s) allowed")]
    public TerraformList<AwsTransferWorkflowOnExceptionStepsBlock>? OnExceptionSteps
    {
        get => GetArgument<TerraformList<AwsTransferWorkflowOnExceptionStepsBlock>>("on_exception_steps");
        set => SetArgument("on_exception_steps", value);
    }

    /// <summary>
    /// Steps block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Steps is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Steps block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 Steps block(s) allowed")]
    public required TerraformList<AwsTransferWorkflowStepsBlock> Steps
    {
        get => GetRequiredArgument<TerraformList<AwsTransferWorkflowStepsBlock>>("steps");
        set => SetArgument("steps", value);
    }

}
