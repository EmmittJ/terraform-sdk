using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatazoneProjectTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_datazone_project resource.
/// </summary>
public class AwsDatazoneProject : TerraformResource
{
    public AwsDatazoneProject(string name) : base("aws_datazone_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("created_by");
        SetOutput("failure_reasons");
        SetOutput("id");
        SetOutput("last_updated_at");
        SetOutput("project_status");
        SetOutput("description");
        SetOutput("domain_identifier");
        SetOutput("glossary_terms");
        SetOutput("name");
        SetOutput("region");
        SetOutput("skip_deletion_check");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    public required TerraformProperty<string> DomainIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_identifier");
        set => SetProperty("domain_identifier", value);
    }

    /// <summary>
    /// The glossary_terms attribute.
    /// </summary>
    public List<TerraformProperty<string>> GlossaryTerms
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("glossary_terms");
        set => SetProperty("glossary_terms", value);
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
    /// The skip_deletion_check attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDeletionCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_deletion_check");
        set => SetProperty("skip_deletion_check", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatazoneProjectTimeoutsBlock? Timeouts
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
    /// The failure_reasons attribute.
    /// </summary>
    public TerraformExpression FailureReasons => this["failure_reasons"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    public TerraformExpression LastUpdatedAt => this["last_updated_at"];

    /// <summary>
    /// The project_status attribute.
    /// </summary>
    public TerraformExpression ProjectStatus => this["project_status"];

}
