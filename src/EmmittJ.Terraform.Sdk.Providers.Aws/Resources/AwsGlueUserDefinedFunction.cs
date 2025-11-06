using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_user_defined_function resource.
/// </summary>
public class AwsGlueUserDefinedFunction : TerraformResource
{
    public AwsGlueUserDefinedFunction(string name) : base("aws_glue_user_defined_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The class_name attribute.
    /// </summary>
    public string? ClassName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("class_name")?.Value;
        set => this.WithProperty("class_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The owner_name attribute.
    /// </summary>
    public string? OwnerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_name")?.Value;
        set => this.WithProperty("owner_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner_type attribute.
    /// </summary>
    public string? OwnerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_type")?.Value;
        set => this.WithProperty("owner_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
