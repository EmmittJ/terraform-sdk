using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2CustomDataIdentifierTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("created_at");
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
    /// The ignore_words attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IgnoreWords
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ignore_words");
        set => this.WithProperty("ignore_words", value);
    }

    /// <summary>
    /// The keywords attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Keywords
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("keywords");
        set => this.WithProperty("keywords", value);
    }

    /// <summary>
    /// The maximum_match_distance attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumMatchDistance
    {
        get => GetProperty<TerraformProperty<double>>("maximum_match_distance");
        set => this.WithProperty("maximum_match_distance", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    public TerraformProperty<string>? Regex
    {
        get => GetProperty<TerraformProperty<string>>("regex");
        set => this.WithProperty("regex", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMacie2CustomDataIdentifierTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMacie2CustomDataIdentifierTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
