using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for model in .
/// Nesting mode: list
/// </summary>
public class AwsDatazoneFormTypeModelBlock : TerraformBlock
{
    /// <summary>
    /// The smithy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Smithy is required")]
    public required TerraformProperty<string> Smithy
    {
        set => SetProperty("smithy", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatazoneFormTypeTimeoutsBlock : TerraformBlock
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
/// Manages a aws_datazone_form_type resource.
/// </summary>
public class AwsDatazoneFormType : TerraformResource
{
    public AwsDatazoneFormType(string name) : base("aws_datazone_form_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("created_by");
        SetOutput("imports");
        SetOutput("origin_domain_id");
        SetOutput("origin_project_id");
        SetOutput("revision");
        SetOutput("description");
        SetOutput("domain_identifier");
        SetOutput("name");
        SetOutput("owning_project_identifier");
        SetOutput("region");
        SetOutput("status");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The owning_project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwningProjectIdentifier is required")]
    public required TerraformProperty<string> OwningProjectIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owning_project_identifier");
        set => SetProperty("owning_project_identifier", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
    }

    /// <summary>
    /// Block for model.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDatazoneFormTypeModelBlock>? Model
    {
        set => SetProperty("model", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatazoneFormTypeTimeoutsBlock? Timeouts
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
    /// The imports attribute.
    /// </summary>
    public TerraformExpression Imports => this["imports"];

    /// <summary>
    /// The origin_domain_id attribute.
    /// </summary>
    public TerraformExpression OriginDomainId => this["origin_domain_id"];

    /// <summary>
    /// The origin_project_id attribute.
    /// </summary>
    public TerraformExpression OriginProjectId => this["origin_project_id"];

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
