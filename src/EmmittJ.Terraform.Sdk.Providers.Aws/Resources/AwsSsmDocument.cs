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
    public string? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content")?.Value;
        set => this.WithProperty("content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public string? DocumentFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_format")?.Value;
        set => this.WithProperty("document_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    public string? DocumentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("document_type")?.Value;
        set => this.WithProperty("document_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public Dictionary<string, string>? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("permissions")?.Value;
        set => this.WithProperty("permissions", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_type attribute.
    /// </summary>
    public string? TargetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_type")?.Value;
        set => this.WithProperty("target_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
