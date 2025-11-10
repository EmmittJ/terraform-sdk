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
        get => GetProperty<TerraformProperty<string>>("source_description");
        set => WithProperty("source_description", value);
    }

    /// <summary>
    /// The source_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? SourceFrequency
    {
        get => GetProperty<TerraformProperty<string>>("source_frequency");
        set => WithProperty("source_frequency", value);
    }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_id");
        set => WithProperty("source_id", value);
    }

    /// <summary>
    /// The source_keyword attribute.
    /// </summary>
    public List<TerraformProperty<object>>? SourceKeyword
    {
        get => GetProperty<List<TerraformProperty<object>>>("source_keyword");
        set => WithProperty("source_keyword", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformProperty<string> SourceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_name");
        set => WithProperty("source_name", value);
    }

    /// <summary>
    /// The source_set_up_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSetUpOption is required")]
    public required TerraformProperty<string> SourceSetUpOption
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_set_up_option");
        set => WithProperty("source_set_up_option", value);
    }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    public required TerraformProperty<string> SourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_type");
        set => WithProperty("source_type", value);
    }

    /// <summary>
    /// The troubleshooting_text attribute.
    /// </summary>
    public TerraformProperty<string>? TroubleshootingText
    {
        get => GetProperty<TerraformProperty<string>>("troubleshooting_text");
        set => WithProperty("troubleshooting_text", value);
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
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("tags_all");
        this.WithOutput("type");
    }

    /// <summary>
    /// The action_plan_instructions attribute.
    /// </summary>
    public TerraformProperty<string>? ActionPlanInstructions
    {
        get => GetProperty<TerraformProperty<string>>("action_plan_instructions");
        set => this.WithProperty("action_plan_instructions", value);
    }

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    public TerraformProperty<string>? ActionPlanTitle
    {
        get => GetProperty<TerraformProperty<string>>("action_plan_title");
        set => this.WithProperty("action_plan_title", value);
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
    /// The testing_information attribute.
    /// </summary>
    public TerraformProperty<string>? TestingInformation
    {
        get => GetProperty<TerraformProperty<string>>("testing_information");
        set => this.WithProperty("testing_information", value);
    }

    /// <summary>
    /// Block for control_mapping_sources.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAuditmanagerControlControlMappingSourcesBlock>? ControlMappingSources
    {
        get => GetProperty<HashSet<AwsAuditmanagerControlControlMappingSourcesBlock>>("control_mapping_sources");
        set => this.WithProperty("control_mapping_sources", value);
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
