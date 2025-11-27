using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_data_config in AwsComprehendEntityRecognizer.
/// Nesting mode: list
/// </summary>
public class AwsComprehendEntityRecognizerInputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_data_config";

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformValue<string>? DataFormat
    {
        get => new TerraformReference<string>(this, "data_format");
        set => SetArgument("data_format", value);
    }

    /// <summary>
    /// Annotations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Annotations block(s) allowed")]
    public TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlockAnnotationsBlock>? Annotations
    {
        get => GetArgument<TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlockAnnotationsBlock>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// AugmentedManifests block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsComprehendEntityRecognizerInputDataConfigBlockAugmentedManifestsBlock>? AugmentedManifests
    {
        get => GetArgument<TerraformSet<AwsComprehendEntityRecognizerInputDataConfigBlockAugmentedManifestsBlock>>("augmented_manifests");
        set => SetArgument("augmented_manifests", value);
    }

    /// <summary>
    /// Documents block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Documents block(s) allowed")]
    public TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlockDocumentsBlock>? Documents
    {
        get => GetArgument<TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlockDocumentsBlock>>("documents");
        set => SetArgument("documents", value);
    }

    /// <summary>
    /// EntityList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntityList block(s) allowed")]
    public TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlockEntityListBlock>? EntityList
    {
        get => GetArgument<TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlockEntityListBlock>>("entity_list");
        set => SetArgument("entity_list", value);
    }

    /// <summary>
    /// EntityTypes block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntityTypes block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 EntityTypes block(s) allowed")]
    public required TerraformSet<AwsComprehendEntityRecognizerInputDataConfigBlockEntityTypesBlock> EntityTypes
    {
        get => GetRequiredArgument<TerraformSet<AwsComprehendEntityRecognizerInputDataConfigBlockEntityTypesBlock>>("entity_types");
        set => SetArgument("entity_types", value);
    }

}

/// <summary>
/// Block type for annotations in AwsComprehendEntityRecognizerInputDataConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsComprehendEntityRecognizerInputDataConfigBlockAnnotationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "annotations";

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

    /// <summary>
    /// The test_s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? TestS3Uri
    {
        get => new TerraformReference<string>(this, "test_s3_uri");
        set => SetArgument("test_s3_uri", value);
    }

}

/// <summary>
/// Block type for augmented_manifests in AwsComprehendEntityRecognizerInputDataConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsComprehendEntityRecognizerInputDataConfigBlockAugmentedManifestsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "augmented_manifests";

    /// <summary>
    /// The annotation_data_s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? AnnotationDataS3Uri
    {
        get => new TerraformReference<string>(this, "annotation_data_s3_uri");
        set => SetArgument("annotation_data_s3_uri", value);
    }

    /// <summary>
    /// The attribute_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeNames is required")]
    public TerraformList<string>? AttributeNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "attribute_names").ResolveNodes(ctx));
        set => SetArgument("attribute_names", value);
    }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    public TerraformValue<string>? DocumentType
    {
        get => new TerraformReference<string>(this, "document_type");
        set => SetArgument("document_type", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

    /// <summary>
    /// The source_documents_s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? SourceDocumentsS3Uri
    {
        get => new TerraformReference<string>(this, "source_documents_s3_uri");
        set => SetArgument("source_documents_s3_uri", value);
    }

    /// <summary>
    /// The split attribute.
    /// </summary>
    public TerraformValue<string>? Split
    {
        get => new TerraformReference<string>(this, "split");
        set => SetArgument("split", value);
    }

}

/// <summary>
/// Block type for documents in AwsComprehendEntityRecognizerInputDataConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsComprehendEntityRecognizerInputDataConfigBlockDocumentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "documents";

    /// <summary>
    /// The input_format attribute.
    /// </summary>
    public TerraformValue<string>? InputFormat
    {
        get => new TerraformReference<string>(this, "input_format");
        set => SetArgument("input_format", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

    /// <summary>
    /// The test_s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? TestS3Uri
    {
        get => new TerraformReference<string>(this, "test_s3_uri");
        set => SetArgument("test_s3_uri", value);
    }

}

/// <summary>
/// Block type for entity_list in AwsComprehendEntityRecognizerInputDataConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsComprehendEntityRecognizerInputDataConfigBlockEntityListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entity_list";

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => new TerraformReference<string>(this, "s3_uri");
        set => SetArgument("s3_uri", value);
    }

}

/// <summary>
/// Block type for entity_types in AwsComprehendEntityRecognizerInputDataConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsComprehendEntityRecognizerInputDataConfigBlockEntityTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entity_types";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsComprehendEntityRecognizer.
/// Nesting mode: single
/// </summary>
public class AwsComprehendEntityRecognizerTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_config in AwsComprehendEntityRecognizer.
/// Nesting mode: list
/// </summary>
public class AwsComprehendEntityRecognizerVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Represents a aws_comprehend_entity_recognizer Terraform resource.
/// Manages a aws_comprehend_entity_recognizer resource.
/// </summary>
public partial class AwsComprehendEntityRecognizer(string name) : TerraformResource("aws_comprehend_entity_recognizer", name)
{
    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessRoleArn is required")]
    public required TerraformValue<string> DataAccessRoleArn
    {
        get => new TerraformReference<string>(this, "data_access_role_arn");
        set => SetArgument("data_access_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The model_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? ModelKmsKeyId
    {
        get => new TerraformReference<string>(this, "model_kms_key_id");
        set => SetArgument("model_kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformValue<string> VersionName
    {
        get => new TerraformReference<string>(this, "version_name");
        set => SetArgument("version_name", value);
    }

    /// <summary>
    /// The version_name_prefix attribute.
    /// </summary>
    public TerraformValue<string> VersionNamePrefix
    {
        get => new TerraformReference<string>(this, "version_name_prefix");
        set => SetArgument("version_name_prefix", value);
    }

    /// <summary>
    /// The volume_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? VolumeKmsKeyId
    {
        get => new TerraformReference<string>(this, "volume_kms_key_id");
        set => SetArgument("volume_kms_key_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// InputDataConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputDataConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputDataConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputDataConfig block(s) allowed")]
    public required TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlock> InputDataConfig
    {
        get => GetRequiredArgument<TerraformList<AwsComprehendEntityRecognizerInputDataConfigBlock>>("input_data_config");
        set => SetArgument("input_data_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsComprehendEntityRecognizerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsComprehendEntityRecognizerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsComprehendEntityRecognizerVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsComprehendEntityRecognizerVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
