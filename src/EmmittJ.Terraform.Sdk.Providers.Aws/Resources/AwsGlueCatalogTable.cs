using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_catalog_table resource.
/// </summary>
public class AwsGlueCatalogTable : TerraformResource
{
    public AwsGlueCatalogTable(string name) : base("aws_glue_catalog_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Owner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner");
        set => this.WithProperty("owner", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
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
    /// The retention attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Retention
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention");
        set => this.WithProperty("retention", value);
    }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_type");
        set => this.WithProperty("table_type", value);
    }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ViewExpandedText
    {
        get => GetProperty<TerraformLiteralProperty<string>>("view_expanded_text");
        set => this.WithProperty("view_expanded_text", value);
    }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ViewOriginalText
    {
        get => GetProperty<TerraformLiteralProperty<string>>("view_original_text");
        set => this.WithProperty("view_original_text", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
