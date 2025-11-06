using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_schema resource.
/// </summary>
public class AwsGlueSchema : TerraformResource
{
    public AwsGlueSchema(string name) : base("aws_glue_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("latest_schema_version");
        this.DeclareOutput("next_schema_version");
        this.DeclareOutput("registry_name");
        this.DeclareOutput("schema_checkpoint");
    }

    /// <summary>
    /// The compatibility attribute.
    /// </summary>
    public string? Compatibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compatibility")?.Value;
        set => this.WithProperty("compatibility", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public string? DataFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_format")?.Value;
        set => this.WithProperty("data_format", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    public string? RegistryArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_arn")?.Value;
        set => this.WithProperty("registry_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schema_definition attribute.
    /// </summary>
    public string? SchemaDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_definition")?.Value;
        set => this.WithProperty("schema_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public string? SchemaName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_name")?.Value;
        set => this.WithProperty("schema_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The latest_schema_version attribute.
    /// </summary>
    public TerraformExpression LatestSchemaVersion => this["latest_schema_version"];

    /// <summary>
    /// The next_schema_version attribute.
    /// </summary>
    public TerraformExpression NextSchemaVersion => this["next_schema_version"];

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    public TerraformExpression RegistryName => this["registry_name"];

    /// <summary>
    /// The schema_checkpoint attribute.
    /// </summary>
    public TerraformExpression SchemaCheckpoint => this["schema_checkpoint"];

}
