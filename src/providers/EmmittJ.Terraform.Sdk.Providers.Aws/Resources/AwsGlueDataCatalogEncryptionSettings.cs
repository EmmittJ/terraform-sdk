using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_catalog_encryption_settings in AwsGlueDataCatalogEncryptionSettings.
/// Nesting mode: list
/// </summary>
public class AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_catalog_encryption_settings";

    /// <summary>
    /// ConnectionPasswordEncryption block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPasswordEncryption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionPasswordEncryption block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPasswordEncryption block(s) allowed")]
    public required TerraformList<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlockConnectionPasswordEncryptionBlock> ConnectionPasswordEncryption
    {
        get => GetRequiredArgument<TerraformList<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlockConnectionPasswordEncryptionBlock>>("connection_password_encryption");
        set => SetArgument("connection_password_encryption", value);
    }

    /// <summary>
    /// EncryptionAtRest block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAtRest is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionAtRest block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionAtRest block(s) allowed")]
    public required TerraformList<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlockEncryptionAtRestBlock> EncryptionAtRest
    {
        get => GetRequiredArgument<TerraformList<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlockEncryptionAtRestBlock>>("encryption_at_rest");
        set => SetArgument("encryption_at_rest", value);
    }

}

/// <summary>
/// Block type for connection_password_encryption in AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlockConnectionPasswordEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_password_encryption";

    /// <summary>
    /// The aws_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? AwsKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("aws_kms_key_id");
        set => SetArgument("aws_kms_key_id", value);
    }

    /// <summary>
    /// The return_connection_password_encrypted attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReturnConnectionPasswordEncrypted is required")]
    public required TerraformValue<bool> ReturnConnectionPasswordEncrypted
    {
        get => GetRequiredArgument<TerraformValue<bool>>("return_connection_password_encrypted");
        set => SetArgument("return_connection_password_encrypted", value);
    }

}

/// <summary>
/// Block type for encryption_at_rest in AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlockEncryptionAtRestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_at_rest";

    /// <summary>
    /// The catalog_encryption_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogEncryptionMode is required")]
    public required TerraformValue<string> CatalogEncryptionMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("catalog_encryption_mode");
        set => SetArgument("catalog_encryption_mode", value);
    }

    /// <summary>
    /// The catalog_encryption_service_role attribute.
    /// </summary>
    public TerraformValue<string>? CatalogEncryptionServiceRole
    {
        get => GetArgument<TerraformValue<string>>("catalog_encryption_service_role");
        set => SetArgument("catalog_encryption_service_role", value);
    }

    /// <summary>
    /// The sse_aws_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? SseAwsKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("sse_aws_kms_key_id");
        set => SetArgument("sse_aws_kms_key_id", value);
    }

}


/// <summary>
/// Represents a aws_glue_data_catalog_encryption_settings Terraform resource.
/// Manages a aws_glue_data_catalog_encryption_settings resource.
/// </summary>
public partial class AwsGlueDataCatalogEncryptionSettings(string name) : TerraformResource("aws_glue_data_catalog_encryption_settings", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id") ?? AsReference("catalog_id");
        set => SetArgument("catalog_id", value);
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
    /// DataCatalogEncryptionSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataCatalogEncryptionSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataCatalogEncryptionSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCatalogEncryptionSettings block(s) allowed")]
    public required TerraformList<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock> DataCatalogEncryptionSettings
    {
        get => GetRequiredArgument<TerraformList<AwsGlueDataCatalogEncryptionSettingsDataCatalogEncryptionSettingsBlock>>("data_catalog_encryption_settings");
        set => SetArgument("data_catalog_encryption_settings", value);
    }

}
