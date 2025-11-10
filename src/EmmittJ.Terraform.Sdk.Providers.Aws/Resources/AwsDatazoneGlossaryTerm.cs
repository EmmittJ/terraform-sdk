using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for term_relations in .
/// Nesting mode: list
/// </summary>
public class AwsDatazoneGlossaryTermTermRelationsBlock : TerraformBlock
{
    /// <summary>
    /// The classifies attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Classifies
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("classifies");
        set => WithProperty("classifies", value);
    }

    /// <summary>
    /// The is_a attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IsA
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("is_a");
        set => WithProperty("is_a", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatazoneGlossaryTermTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_datazone_glossary_term resource.
/// </summary>
public class AwsDatazoneGlossaryTerm : TerraformResource
{
    public AwsDatazoneGlossaryTerm(string name) : base("aws_datazone_glossary_term", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("created_by");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DomainIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("domain_identifier");
        set => this.WithProperty("domain_identifier", value);
    }

    /// <summary>
    /// The glossary_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlossaryIdentifier is required")]
    public required TerraformProperty<string> GlossaryIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("glossary_identifier");
        set => this.WithProperty("glossary_identifier", value);
    }

    /// <summary>
    /// The long_description attribute.
    /// </summary>
    public TerraformProperty<string>? LongDescription
    {
        get => GetProperty<TerraformProperty<string>>("long_description");
        set => this.WithProperty("long_description", value);
    }

    /// <summary>
    /// The name attribute.
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
    /// The short_description attribute.
    /// </summary>
    public TerraformProperty<string>? ShortDescription
    {
        get => GetProperty<TerraformProperty<string>>("short_description");
        set => this.WithProperty("short_description", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for term_relations.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDatazoneGlossaryTermTermRelationsBlock>? TermRelations
    {
        get => GetProperty<List<AwsDatazoneGlossaryTermTermRelationsBlock>>("term_relations");
        set => this.WithProperty("term_relations", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatazoneGlossaryTermTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDatazoneGlossaryTermTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
