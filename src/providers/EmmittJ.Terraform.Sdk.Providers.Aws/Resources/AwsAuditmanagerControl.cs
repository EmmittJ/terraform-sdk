using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for control_mapping_sources in .
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerControlControlMappingSourcesBlock : TerraformBlock
{
    /// <summary>
    /// The source_description attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDescription
    {
        set => SetProperty("source_description", value);
    }

    /// <summary>
    /// The source_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? SourceFrequency
    {
        set => SetProperty("source_frequency", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceId
    {
        set => SetProperty("source_id", value);
    }

    /// <summary>
    /// The source_keyword attribute.
    /// </summary>
    public List<TerraformProperty<object>>? SourceKeyword
    {
        set => SetProperty("source_keyword", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformProperty<string> SourceName
    {
        set => SetProperty("source_name", value);
    }

    /// <summary>
    /// The source_set_up_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSetUpOption is required")]
    public required TerraformProperty<string> SourceSetUpOption
    {
        set => SetProperty("source_set_up_option", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformProperty<string> SourceType
    {
        set => SetProperty("source_type", value);
    }

    /// <summary>
    /// The troubleshooting_text attribute.
    /// </summary>
    public TerraformProperty<string>? TroubleshootingText
    {
        set => SetProperty("troubleshooting_text", value);
    }

}

/// <summary>
/// Manages a aws_auditmanager_control resource.
/// </summary>
public class AwsAuditmanagerControl : TerraformResource
{
    public AwsAuditmanagerControl(string name) : base("aws_auditmanager_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("type");
        SetOutput("action_plan_instructions");
        SetOutput("action_plan_title");
        SetOutput("description");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("testing_information");
    }

    /// <summary>
    /// The action_plan_instructions attribute.
    /// </summary>
    public TerraformProperty<string> ActionPlanInstructions
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action_plan_instructions");
        set => SetProperty("action_plan_instructions", value);
    }

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    public TerraformProperty<string> ActionPlanTitle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action_plan_title");
        set => SetProperty("action_plan_title", value);
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
    /// The testing_information attribute.
    /// </summary>
    public TerraformProperty<string> TestingInformation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("testing_information");
        set => SetProperty("testing_information", value);
    }

    /// <summary>
    /// Block for control_mapping_sources.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAuditmanagerControlControlMappingSourcesBlock>? ControlMappingSources
    {
        set => SetProperty("control_mapping_sources", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
