using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for term_relations in AwsDatazoneGlossaryTerm.
/// Nesting mode: list
/// </summary>
public class AwsDatazoneGlossaryTermTermRelationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "term_relations";

    /// <summary>
    /// The classifies attribute.
    /// </summary>
    public TerraformSet<string>? Classifies
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "classifies").ResolveNodes(ctx));
        set => SetArgument("classifies", value);
    }

    /// <summary>
    /// The is_a attribute.
    /// </summary>
    public TerraformSet<string>? IsA
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "is_a").ResolveNodes(ctx));
        set => SetArgument("is_a", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDatazoneGlossaryTerm.
/// Nesting mode: single
/// </summary>
public class AwsDatazoneGlossaryTermTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_datazone_glossary_term Terraform resource.
/// Manages a aws_datazone_glossary_term resource.
/// </summary>
public partial class AwsDatazoneGlossaryTerm(string name) : TerraformResource("aws_datazone_glossary_term", name)
{
    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    public TerraformValue<string>? DomainIdentifier
    {
        get => new TerraformReference<string>(this, "domain_identifier");
        set => SetArgument("domain_identifier", value);
    }

    /// <summary>
    /// The glossary_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlossaryIdentifier is required")]
    public required TerraformValue<string> GlossaryIdentifier
    {
        get => new TerraformReference<string>(this, "glossary_identifier");
        set => SetArgument("glossary_identifier", value);
    }

    /// <summary>
    /// The long_description attribute.
    /// </summary>
    public TerraformValue<string>? LongDescription
    {
        get => new TerraformReference<string>(this, "long_description");
        set => SetArgument("long_description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The short_description attribute.
    /// </summary>
    public TerraformValue<string>? ShortDescription
    {
        get => new TerraformReference<string>(this, "short_description");
        set => SetArgument("short_description", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// TermRelations block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDatazoneGlossaryTermTermRelationsBlock>? TermRelations
    {
        get => GetArgument<TerraformList<AwsDatazoneGlossaryTermTermRelationsBlock>>("term_relations");
        set => SetArgument("term_relations", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatazoneGlossaryTermTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatazoneGlossaryTermTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
