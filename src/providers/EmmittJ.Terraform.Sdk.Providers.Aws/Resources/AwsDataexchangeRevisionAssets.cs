using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for asset in AwsDataexchangeRevisionAssets.
/// Nesting mode: set
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "asset";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// CreateS3DataAccessFromS3Bucket block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlock>? CreateS3DataAccessFromS3Bucket
    {
        get => GetArgument<TerraformList<AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlock>>("create_s3_data_access_from_s3_bucket");
        set => SetArgument("create_s3_data_access_from_s3_bucket", value);
    }

    /// <summary>
    /// ImportAssetsFromS3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromS3Block>? ImportAssetsFromS3
    {
        get => GetArgument<TerraformList<AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromS3Block>>("import_assets_from_s3");
        set => SetArgument("import_assets_from_s3", value);
    }

    /// <summary>
    /// ImportAssetsFromSignedUrl block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromSignedUrlBlock>? ImportAssetsFromSignedUrl
    {
        get => GetArgument<TerraformList<AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromSignedUrlBlock>>("import_assets_from_signed_url");
        set => SetArgument("import_assets_from_signed_url", value);
    }

}

/// <summary>
/// Block type for create_s3_data_access_from_s3_bucket in AwsDataexchangeRevisionAssetsAssetBlock.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_s3_data_access_from_s3_bucket";

    /// <summary>
    /// The access_point_alias attribute.
    /// </summary>
    public TerraformValue<string> AccessPointAlias
        => AsReference("access_point_alias");

    /// <summary>
    /// The access_point_arn attribute.
    /// </summary>
    public TerraformValue<string> AccessPointArn
        => AsReference("access_point_arn");

    /// <summary>
    /// AssetSource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlockAssetSourceBlock>? AssetSource
    {
        get => GetArgument<TerraformList<AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlockAssetSourceBlock>>("asset_source");
        set => SetArgument("asset_source", value);
    }

}

/// <summary>
/// Block type for asset_source in AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlock.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlockAssetSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "asset_source";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? KeyPrefixes
    {
        get => GetArgument<TerraformSet<string>>("key_prefixes");
        set => SetArgument("key_prefixes", value);
    }

    /// <summary>
    /// The keys attribute.
    /// </summary>
    public TerraformSet<string>? KeysAttribute
    {
        get => GetArgument<TerraformSet<string>>("keys");
        set => SetArgument("keys", value);
    }

    /// <summary>
    /// KmsKeysToGrant block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlockAssetSourceBlockKmsKeysToGrantBlock>? KmsKeysToGrant
    {
        get => GetArgument<TerraformList<AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlockAssetSourceBlockKmsKeysToGrantBlock>>("kms_keys_to_grant");
        set => SetArgument("kms_keys_to_grant", value);
    }

}

/// <summary>
/// Block type for kms_keys_to_grant in AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlockAssetSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlockCreateS3DataAccessFromS3BucketBlockAssetSourceBlockKmsKeysToGrantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_keys_to_grant";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformValue<string> KmsKeyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for import_assets_from_s3 in AwsDataexchangeRevisionAssetsAssetBlock.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "import_assets_from_s3";

    /// <summary>
    /// AssetSource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromS3BlockAssetSourceBlock>? AssetSource
    {
        get => GetArgument<TerraformList<AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromS3BlockAssetSourceBlock>>("asset_source");
        set => SetArgument("asset_source", value);
    }

}

/// <summary>
/// Block type for asset_source in AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromS3Block.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromS3BlockAssetSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "asset_source";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for import_assets_from_signed_url in AwsDataexchangeRevisionAssetsAssetBlock.
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlockImportAssetsFromSignedUrlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "import_assets_from_signed_url";

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filename is required")]
    public required TerraformValue<string> Filename
    {
        get => GetRequiredArgument<TerraformValue<string>>("filename");
        set => SetArgument("filename", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDataexchangeRevisionAssets.
/// Nesting mode: single
/// </summary>
public class AwsDataexchangeRevisionAssetsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_dataexchange_revision_assets Terraform resource.
/// Manages a aws_dataexchange_revision_assets resource.
/// </summary>
public partial class AwsDataexchangeRevisionAssets(string name) : TerraformResource("aws_dataexchange_revision_assets", name)
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformValue<string> DataSetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_set_id");
        set => SetArgument("data_set_id", value);
    }

    /// <summary>
    /// The finalized attribute.
    /// </summary>
    public TerraformValue<bool> Finalized
    {
        get => GetArgument<TerraformValue<bool>>("finalized") ?? AsReference("finalized");
        set => SetArgument("finalized", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// Asset block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDataexchangeRevisionAssetsAssetBlock>? Asset
    {
        get => GetArgument<TerraformSet<AwsDataexchangeRevisionAssetsAssetBlock>>("asset");
        set => SetArgument("asset", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDataexchangeRevisionAssetsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDataexchangeRevisionAssetsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
