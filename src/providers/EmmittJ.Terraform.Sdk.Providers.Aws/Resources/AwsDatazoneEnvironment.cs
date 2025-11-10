using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatazoneEnvironmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for user_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsDatazoneEnvironmentUserParametersBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_datazone_environment resource.
/// </summary>
public class AwsDatazoneEnvironment : TerraformResource
{
    public AwsDatazoneEnvironment(string name) : base("aws_datazone_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("created_by");
        SetOutput("id");
        SetOutput("last_deployment");
        SetOutput("provider_environment");
        SetOutput("provisioned_resources");
        SetOutput("account_identifier");
        SetOutput("account_region");
        SetOutput("blueprint_identifier");
        SetOutput("description");
        SetOutput("domain_identifier");
        SetOutput("glossary_terms");
        SetOutput("name");
        SetOutput("profile_identifier");
        SetOutput("project_identifier");
        SetOutput("region");
    }

    /// <summary>
    /// The account_identifier attribute.
    /// </summary>
    public TerraformProperty<string> AccountIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_identifier");
        set => SetProperty("account_identifier", value);
    }

    /// <summary>
    /// The account_region attribute.
    /// </summary>
    public TerraformProperty<string> AccountRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_region");
        set => SetProperty("account_region", value);
    }

    /// <summary>
    /// The blueprint_identifier attribute.
    /// </summary>
    public TerraformProperty<string> BlueprintIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blueprint_identifier");
        set => SetProperty("blueprint_identifier", value);
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
    /// The profile_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileIdentifier is required")]
    public required TerraformProperty<string> ProfileIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_identifier");
        set => SetProperty("profile_identifier", value);
    }

    /// <summary>
    /// The project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectIdentifier is required")]
    public required TerraformProperty<string> ProjectIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_identifier");
        set => SetProperty("project_identifier", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatazoneEnvironmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_parameters.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDatazoneEnvironmentUserParametersBlock>? UserParameters
    {
        set => SetProperty("user_parameters", value);
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

    /// <summary>
    /// The last_deployment attribute.
    /// </summary>
    public TerraformExpression LastDeployment => this["last_deployment"];

    /// <summary>
    /// The provider_environment attribute.
    /// </summary>
    public TerraformExpression ProviderEnvironment => this["provider_environment"];

    /// <summary>
    /// The provisioned_resources attribute.
    /// </summary>
    public TerraformExpression ProvisionedResources => this["provisioned_resources"];

}
