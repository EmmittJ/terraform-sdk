using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for expression in .
/// Nesting mode: set
/// </summary>
public class AwsLakeformationLfTagExpressionExpressionBlock : TerraformBlock
{
    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    public required TerraformProperty<string> TagKey
    {
        get => GetProperty<TerraformProperty<string>>("tag_key");
        set => WithProperty("tag_key", value);
    }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    public HashSet<TerraformProperty<string>>? TagValues
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tag_values");
        set => WithProperty("tag_values", value);
    }

}

/// <summary>
/// Manages an AWS Lake Formation Tag Expression.
/// </summary>
public class AwsLakeformationLfTagExpression : TerraformResource
{
    public AwsLakeformationLfTagExpression(string name) : base("aws_lakeformation_lf_tag_expression", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// A description of the LF-Tag Expression.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name of the LF-Tag Expression.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for expression.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLakeformationLfTagExpressionExpressionBlock>? Expression
    {
        get => GetProperty<HashSet<AwsLakeformationLfTagExpressionExpressionBlock>>("expression");
        set => this.WithProperty("expression", value);
    }

}
