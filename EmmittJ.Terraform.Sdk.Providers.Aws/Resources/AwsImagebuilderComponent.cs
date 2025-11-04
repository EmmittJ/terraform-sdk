using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_imagebuilder_component resource.
/// </summary>
public class AwsImagebuilderComponent : TerraformResource
{
    public AwsImagebuilderComponent(string name) : base("aws_imagebuilder_component", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("owner");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The change_description attribute.
    /// </summary>
    public string? ChangeDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("change_description")?.Value;
        set => this.WithProperty("change_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data attribute.
    /// </summary>
    public string? Data
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data")?.Value;
        set => this.WithProperty("data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The platform attribute.
    /// </summary>
    public string? Platform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform")?.Value;
        set => this.WithProperty("platform", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The supported_os_versions attribute.
    /// </summary>
    public HashSet<string>? SupportedOsVersions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("supported_os_versions")?.Value;
        set => this.WithProperty("supported_os_versions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The uri attribute.
    /// </summary>
    public string? Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("uri")?.Value;
        set => this.WithProperty("uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
