using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_comprehend_document_classifier resource.
/// </summary>
public class AwsComprehendDocumentClassifier : TerraformResource
{
    public AwsComprehendDocumentClassifier(string name) : base("aws_comprehend_document_classifier", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    public string? DataAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_access_role_arn")?.Value;
        set => this.WithProperty("data_access_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public string? LanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_code")?.Value;
        set => this.WithProperty("language_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The model_kms_key_id attribute.
    /// </summary>
    public string? ModelKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_kms_key_id")?.Value;
        set => this.WithProperty("model_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public string? VersionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_name")?.Value;
        set => this.WithProperty("version_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_name_prefix attribute.
    /// </summary>
    public string? VersionNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_name_prefix")?.Value;
        set => this.WithProperty("version_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The volume_kms_key_id attribute.
    /// </summary>
    public string? VolumeKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_kms_key_id")?.Value;
        set => this.WithProperty("volume_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
