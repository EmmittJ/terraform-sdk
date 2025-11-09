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
    public TerraformProperty<string>? DataAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("data_access_role_arn");
        set => this.WithProperty("data_access_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The model_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ModelKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("model_kms_key_id");
        set => this.WithProperty("model_kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformProperty<string>? VersionName
    {
        get => GetProperty<TerraformProperty<string>>("version_name");
        set => this.WithProperty("version_name", value);
    }

    /// <summary>
    /// The version_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? VersionNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("version_name_prefix");
        set => this.WithProperty("version_name_prefix", value);
    }

    /// <summary>
    /// The volume_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("volume_kms_key_id");
        set => this.WithProperty("volume_kms_key_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
