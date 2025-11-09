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
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The owner attribute.
    /// </summary>
    public TerraformProperty<string>? Owner
    {
        get => GetProperty<TerraformProperty<string>>("owner");
        set => this.WithProperty("owner", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
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
    /// The retention attribute.
    /// </summary>
    public TerraformProperty<double>? Retention
    {
        get => GetProperty<TerraformProperty<double>>("retention");
        set => this.WithProperty("retention", value);
    }

    /// <summary>
    /// The table_type attribute.
    /// </summary>
    public TerraformProperty<string>? TableType
    {
        get => GetProperty<TerraformProperty<string>>("table_type");
        set => this.WithProperty("table_type", value);
    }

    /// <summary>
    /// The view_expanded_text attribute.
    /// </summary>
    public TerraformProperty<string>? ViewExpandedText
    {
        get => GetProperty<TerraformProperty<string>>("view_expanded_text");
        set => this.WithProperty("view_expanded_text", value);
    }

    /// <summary>
    /// The view_original_text attribute.
    /// </summary>
    public TerraformProperty<string>? ViewOriginalText
    {
        get => GetProperty<TerraformProperty<string>>("view_original_text");
        set => this.WithProperty("view_original_text", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
