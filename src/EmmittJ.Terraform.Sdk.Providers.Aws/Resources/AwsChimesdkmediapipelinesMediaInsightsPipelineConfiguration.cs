using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elements in .
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for real_time_alert_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => WithProperty("disabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_chimesdkmediapipelines_media_insights_pipeline_configuration resource.
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration : TerraformResource
{
    public AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration(string name) : base("aws_chimesdkmediapipelines_media_insights_pipeline_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
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
    /// The resource_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAccessRoleArn is required")]
    public required TerraformProperty<string> ResourceAccessRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_access_role_arn");
        set => this.WithProperty("resource_access_role_arn", value);
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
    /// Block for elements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Elements block(s) required")]
    public List<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock>? Elements
    {
        get => GetProperty<List<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock>>("elements");
        set => this.WithProperty("elements", value);
    }

    /// <summary>
    /// Block for real_time_alert_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RealTimeAlertConfiguration block(s) allowed")]
    public List<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock>? RealTimeAlertConfiguration
    {
        get => GetProperty<List<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock>>("real_time_alert_configuration");
        set => this.WithProperty("real_time_alert_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
