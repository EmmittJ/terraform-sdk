using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_document resource.
/// </summary>
public class AwsSsmDocument : TerraformResource
{
    public AwsSsmDocument(string name) : base("aws_ssm_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_date");
        this.DeclareOutput("default_version");
        this.DeclareOutput("description");
        this.DeclareOutput("document_version");
        this.DeclareOutput("hash");
        this.DeclareOutput("hash_type");
        this.DeclareOutput("latest_version");
        this.DeclareOutput("owner");
        this.DeclareOutput("parameter");
        this.DeclareOutput("platform_types");
        this.DeclareOutput("schema_version");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformProperty<string>? Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentFormat
    {
        get => GetProperty<TerraformProperty<string>>("document_format");
        set => this.WithProperty("document_format", value);
    }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentType
    {
        get => GetProperty<TerraformProperty<string>>("document_type");
        set => this.WithProperty("document_type", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformMapProperty<string>? Permissions
    {
        get => GetProperty<TerraformMapProperty<string>>("permissions");
        set => this.WithProperty("permissions", value);
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
    /// The target_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetType
    {
        get => GetProperty<TerraformProperty<string>>("target_type");
        set => this.WithProperty("target_type", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformExpression DefaultVersion => this["default_version"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformExpression DocumentVersion => this["document_version"];

    /// <summary>
    /// The hash attribute.
    /// </summary>
    public TerraformExpression Hash => this["hash"];

    /// <summary>
    /// The hash_type attribute.
    /// </summary>
    public TerraformExpression HashType => this["hash_type"];

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformExpression LatestVersion => this["latest_version"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    public TerraformExpression Parameter => this["parameter"];

    /// <summary>
    /// The platform_types attribute.
    /// </summary>
    public TerraformExpression PlatformTypes => this["platform_types"];

    /// <summary>
    /// The schema_version attribute.
    /// </summary>
    public TerraformExpression SchemaVersion => this["schema_version"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
