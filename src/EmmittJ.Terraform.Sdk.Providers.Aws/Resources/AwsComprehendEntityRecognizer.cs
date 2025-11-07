using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_comprehend_entity_recognizer resource.
/// </summary>
public class AwsComprehendEntityRecognizer : TerraformResource
{
    public AwsComprehendEntityRecognizer(string name) : base("aws_comprehend_entity_recognizer", name)
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
    public TerraformLiteralProperty<string>? DataAccessRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_access_role_arn");
        set => this.WithProperty("data_access_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The model_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ModelKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_kms_key_id");
        set => this.WithProperty("model_kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VersionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_name");
        set => this.WithProperty("version_name", value);
    }

    /// <summary>
    /// The version_name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VersionNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_name_prefix");
        set => this.WithProperty("version_name_prefix", value);
    }

    /// <summary>
    /// The volume_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VolumeKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_kms_key_id");
        set => this.WithProperty("volume_kms_key_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
