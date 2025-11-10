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
        set => SetProperty("dedupe_string", value);
    }

    /// <summary>
    /// The impact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Impact is required")]
    public required TerraformProperty<double> Impact
    {
        set => SetProperty("impact", value);
    }

    /// <summary>
    /// The incident_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? IncidentTags
    {
        set => SetProperty("incident_tags", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformProperty<string>? Summary
    {
        set => SetProperty("summary", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformProperty<string> Title
    {
        set => SetProperty("title", value);
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
        SetOutput("arn");
        SetOutput("chat_channel");
        SetOutput("display_name");
        SetOutput("engagements");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ChatChannel
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("chat_channel");
        set => SetProperty("chat_channel", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Engagements
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("engagements");
        set => SetProperty("engagements", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public List<AwsSsmincidentsResponsePlanActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for incident_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncidentTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IncidentTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncidentTemplate block(s) allowed")]
    public List<AwsSsmincidentsResponsePlanIncidentTemplateBlock>? IncidentTemplate
    {
        set => SetProperty("incident_template", value);
    }

    /// <summary>
    /// Block for integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Integration block(s) allowed")]
    public List<AwsSsmincidentsResponsePlanIntegrationBlock>? Integration
    {
        set => SetProperty("integration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
