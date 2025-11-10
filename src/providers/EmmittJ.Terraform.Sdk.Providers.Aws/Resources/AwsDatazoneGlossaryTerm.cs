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
        set => SetProperty("classifies", value);
    }

    /// <summary>
    /// The is_a attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IsA
    {
        set => SetProperty("is_a", value);
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
        set => SetProperty("create", value);
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
        SetOutput("created_at");
        SetOutput("created_by");
        SetOutput("id");
        SetOutput("domain_identifier");
        SetOutput("glossary_identifier");
        SetOutput("long_description");
        SetOutput("name");
        SetOutput("region");
        SetOutput("short_description");
        SetOutput("status");
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    public TerraformProperty<string> DomainIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_identifier");
        set => SetProperty("domain_identifier", value);
    }

    /// <summary>
    /// The glossary_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlossaryIdentifier is required")]
    public required TerraformProperty<string> GlossaryIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("glossary_identifier");
        set => SetProperty("glossary_identifier", value);
    }

    /// <summary>
    /// The long_description attribute.
    /// </summary>
    public TerraformProperty<string> LongDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("long_description");
        set => SetProperty("long_description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The short_description attribute.
    /// </summary>
    public TerraformProperty<string> ShortDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("short_description");
        set => SetProperty("short_description", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for term_relations.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDatazoneGlossaryTermTermRelationsBlock>? TermRelations
    {
        set => SetProperty("term_relations", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatazoneGlossaryTermTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
