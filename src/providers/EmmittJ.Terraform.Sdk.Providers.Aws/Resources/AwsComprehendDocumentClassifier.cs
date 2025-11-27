using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_data_config in AwsComprehendDocumentClassifier.
/// Nesting mode: list
/// </summary>
public class AwsComprehendDocumentClassifierInputDataConfigBlock : TerraformBlock
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
    /// The label_delimiter attribute.
    /// </summary>
    public TerraformValue<string> LabelDelimiter
    {
        get => new TerraformReference<string>(this, "label_delimiter");
        set => SetArgument("label_delimiter", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? S3Uri
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

    /// <summary>
    /// AugmentedManifests block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsComprehendDocumentClassifierInputDataConfigBlockAugmentedManifestsBlock>? AugmentedManifests
    {
        get => GetArgument<TerraformSet<AwsComprehendDocumentClassifierInputDataConfigBlockAugmentedManifestsBlock>>("augmented_manifests");
        set => SetArgument("augmented_manifests", value);
    }

}

/// <summary>
/// Block type for augmented_manifests in AwsComprehendDocumentClassifierInputDataConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsComprehendDocumentClassifierInputDataConfigBlockAugmentedManifestsBlock : TerraformBlock
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
/// Block type for output_data_config in AwsComprehendDocumentClassifier.
/// Nesting mode: list
/// </summary>
public class AwsComprehendDocumentClassifierOutputDataConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_data_config";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The output_s3_uri attribute.
    /// </summary>
    public TerraformValue<string> OutputS3Uri
    {
        get => new TerraformReference<string>(this, "output_s3_uri");
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

}


/// <summary>
/// Block type for timeouts in AwsComprehendDocumentClassifier.
/// Nesting mode: single
/// </summary>
public class AwsComprehendDocumentClassifierTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_config in AwsComprehendDocumentClassifier.
/// Nesting mode: list
/// </summary>
public class AwsComprehendDocumentClassifierVpcConfigBlock : TerraformBlock
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
/// Represents a aws_comprehend_document_classifier Terraform resource.
/// Manages a aws_comprehend_document_classifier resource.
/// </summary>
public partial class AwsComprehendDocumentClassifier(string name) : TerraformResource("aws_comprehend_document_classifier", name)
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
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
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
    public required TerraformList<AwsComprehendDocumentClassifierInputDataConfigBlock> InputDataConfig
    {
        get => GetRequiredArgument<TerraformList<AwsComprehendDocumentClassifierInputDataConfigBlock>>("input_data_config");
        set => SetArgument("input_data_config", value);
    }

    /// <summary>
    /// OutputDataConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputDataConfig block(s) allowed")]
    public TerraformList<AwsComprehendDocumentClassifierOutputDataConfigBlock>? OutputDataConfig
    {
        get => GetArgument<TerraformList<AwsComprehendDocumentClassifierOutputDataConfigBlock>>("output_data_config");
        set => SetArgument("output_data_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsComprehendDocumentClassifierTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsComprehendDocumentClassifierTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsComprehendDocumentClassifierVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsComprehendDocumentClassifierVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}
