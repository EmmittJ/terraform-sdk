using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in AwsDataexchangeEventAction.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// ExportRevisionToS3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeEventActionActionBlockExportRevisionToS3Block>? ExportRevisionToS3
    {
        get => GetArgument<TerraformList<AwsDataexchangeEventActionActionBlockExportRevisionToS3Block>>("export_revision_to_s3");
        set => SetArgument("export_revision_to_s3", value);
    }

}

/// <summary>
/// Block type for export_revision_to_s3 in AwsDataexchangeEventActionActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionActionBlockExportRevisionToS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_revision_to_s3";

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeEventActionActionBlockExportRevisionToS3BlockEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<AwsDataexchangeEventActionActionBlockExportRevisionToS3BlockEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

    /// <summary>
    /// RevisionDestination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeEventActionActionBlockExportRevisionToS3BlockRevisionDestinationBlock>? RevisionDestination
    {
        get => GetArgument<TerraformList<AwsDataexchangeEventActionActionBlockExportRevisionToS3BlockRevisionDestinationBlock>>("revision_destination");
        set => SetArgument("revision_destination", value);
    }

}

/// <summary>
/// Block type for encryption in AwsDataexchangeEventActionActionBlockExportRevisionToS3Block.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionActionBlockExportRevisionToS3BlockEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for revision_destination in AwsDataexchangeEventActionActionBlockExportRevisionToS3Block.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionActionBlockExportRevisionToS3BlockRevisionDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "revision_destination";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key_pattern attribute.
    /// </summary>
    public TerraformValue<string> KeyPattern
    {
        get => new TerraformReference<string>(this, "key_pattern");
        set => SetArgument("key_pattern", value);
    }

}


/// <summary>
/// Block type for event in AwsDataexchangeEventAction.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionEventAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event";

    /// <summary>
    /// RevisionPublished block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeEventActionEventAttributeBlockRevisionPublishedBlock>? RevisionPublished
    {
        get => GetArgument<TerraformList<AwsDataexchangeEventActionEventAttributeBlockRevisionPublishedBlock>>("revision_published");
        set => SetArgument("revision_published", value);
    }

}

/// <summary>
/// Block type for revision_published in AwsDataexchangeEventActionEventAttributeBlock.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionEventAttributeBlockRevisionPublishedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "revision_published";

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformValue<string> DataSetId
    {
        get => new TerraformReference<string>(this, "data_set_id");
        set => SetArgument("data_set_id", value);
    }

}


/// <summary>
/// Represents a aws_dataexchange_event_action Terraform resource.
/// Manages a aws_dataexchange_event_action resource.
/// </summary>
public partial class AwsDataexchangeEventAction(string name) : TerraformResource("aws_dataexchange_event_action", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
    {
        get => new TerraformReference<string>(this, "updated_at");
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeEventActionActionBlock>? Action
    {
        get => GetArgument<TerraformList<AwsDataexchangeEventActionActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// EventAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeEventActionEventAttributeBlock>? EventAttribute
    {
        get => GetArgument<TerraformList<AwsDataexchangeEventActionEventAttributeBlock>>("event");
        set => SetArgument("event", value);
    }

}
