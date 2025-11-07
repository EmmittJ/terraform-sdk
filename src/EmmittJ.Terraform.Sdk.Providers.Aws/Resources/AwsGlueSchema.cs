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
    public TerraformLiteralProperty<string>? Compatibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compatibility");
        set => this.WithProperty("compatibility", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_format");
        set => this.WithProperty("data_format", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RegistryArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("registry_arn");
        set => this.WithProperty("registry_arn", value);
    }

    /// <summary>
    /// The schema_definition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SchemaDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_definition");
        set => this.WithProperty("schema_definition", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SchemaName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_name");
        set => this.WithProperty("schema_name", value);
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
