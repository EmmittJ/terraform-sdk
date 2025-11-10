using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanActionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for incident_template in .
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanIncidentTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The dedupe_string attribute.
    /// </summary>
    public TerraformProperty<string>? DedupeString
    {
        get => GetProperty<TerraformProperty<string>>("dedupe_string");
        set => WithProperty("dedupe_string", value);
    }

    /// <summary>
    /// The impact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Impact is required")]
    public required TerraformProperty<double> Impact
    {
        get => GetRequiredProperty<TerraformProperty<double>>("impact");
        set => WithProperty("impact", value);
    }

    /// <summary>
    /// The incident_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? IncidentTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("incident_tags");
        set => WithProperty("incident_tags", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformProperty<string>? Summary
    {
        get => GetProperty<TerraformProperty<string>>("summary");
        set => WithProperty("summary", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        get => GetRequiredProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

}

/// <summary>
/// Block type for integration in .
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanIntegrationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_ssmincidents_response_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmincidentsResponsePlan : TerraformResource
{
    public AwsSsmincidentsResponsePlan(string name) : base("aws_ssmincidents_response_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ChatChannel
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("chat_channel");
        set => this.WithProperty("chat_channel", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Engagements
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("engagements");
        set => this.WithProperty("engagements", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public List<AwsSsmincidentsResponsePlanActionBlock>? Action
    {
        get => GetProperty<List<AwsSsmincidentsResponsePlanActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for incident_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IncidentTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncidentTemplate block(s) allowed")]
    public List<AwsSsmincidentsResponsePlanIncidentTemplateBlock>? IncidentTemplate
    {
        get => GetProperty<List<AwsSsmincidentsResponsePlanIncidentTemplateBlock>>("incident_template");
        set => this.WithProperty("incident_template", value);
    }

    /// <summary>
    /// Block for integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Integration block(s) allowed")]
    public List<AwsSsmincidentsResponsePlanIntegrationBlock>? Integration
    {
        get => GetProperty<List<AwsSsmincidentsResponsePlanIntegrationBlock>>("integration");
        set => this.WithProperty("integration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
