using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachments_source in .
/// Nesting mode: list
/// </summary>
public class AwsSsmDocumentAttachmentsSourceBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Manages a aws_ssm_document resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmDocument : TerraformResource
{
    public AwsSsmDocument(string name) : base("aws_ssm_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_date");
        SetOutput("default_version");
        SetOutput("description");
        SetOutput("document_version");
        SetOutput("hash");
        SetOutput("hash_type");
        SetOutput("latest_version");
        SetOutput("owner");
        SetOutput("parameter");
        SetOutput("platform_types");
        SetOutput("schema_version");
        SetOutput("status");
        SetOutput("content");
        SetOutput("document_format");
        SetOutput("document_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("permissions");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_type");
        SetOutput("version_name");
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformProperty<string> Content
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content");
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    public TerraformProperty<string> DocumentFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_format");
        set => SetProperty("document_format", value);
    }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DocumentType is required")]
    public required TerraformProperty<string> DocumentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_type");
        set => SetProperty("document_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Permissions
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("permissions");
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformProperty<string> TargetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_type");
        set => SetProperty("target_type", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformProperty<string> VersionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_name");
        set => SetProperty("version_name", value);
    }

    /// <summary>
    /// Block for attachments_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 AttachmentsSource block(s) allowed")]
    public List<AwsSsmDocumentAttachmentsSourceBlock>? AttachmentsSource
    {
        set => SetProperty("attachments_source", value);
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
