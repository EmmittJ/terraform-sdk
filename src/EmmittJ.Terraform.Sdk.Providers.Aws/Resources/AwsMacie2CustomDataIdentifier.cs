using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_macie2_custom_data_identifier resource.
/// </summary>
public class AwsMacie2CustomDataIdentifier : TerraformResource
{
    public AwsMacie2CustomDataIdentifier(string name) : base("aws_macie2_custom_data_identifier", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
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
    /// The ignore_words attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? IgnoreWords
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ignore_words");
        set => this.WithProperty("ignore_words", value);
    }

    /// <summary>
    /// The keywords attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Keywords
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("keywords");
        set => this.WithProperty("keywords", value);
    }

    /// <summary>
    /// The maximum_match_distance attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaximumMatchDistance
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_match_distance");
        set => this.WithProperty("maximum_match_distance", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Regex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("regex");
        set => this.WithProperty("regex", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

}
