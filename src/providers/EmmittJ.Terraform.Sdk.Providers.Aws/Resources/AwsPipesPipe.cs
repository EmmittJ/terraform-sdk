using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for enrichment_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeEnrichmentParametersBlock : TerraformBlock
{
    /// <summary>
    /// The input_template attribute.
    /// </summary>
    public TerraformProperty<string>? InputTemplate
    {
        set => SetProperty("input_template", value);
    }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The include_execution_data attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludeExecutionData
    {
        set => SetProperty("include_execution_data", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Level is required")]
    public required TerraformProperty<string> Level
    {
        set => SetProperty("level", value);
    }

}

/// <summary>
/// Block type for source_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlock : TerraformBlock
{
}

/// <summary>
/// Block type for target_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlock : TerraformBlock
{
    /// <summary>
    /// The input_template attribute.
    /// </summary>
    public TerraformProperty<string>? InputTemplate
    {
        set => SetProperty("input_template", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPipesPipeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_pipes_pipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsPipesPipe : TerraformResource
{
    public AwsPipesPipe(string name) : base("aws_pipes_pipe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("desired_state");
        SetOutput("enrichment");
        SetOutput("id");
        SetOutput("kms_key_identifier");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("source");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target");
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
    /// The desired_state attribute.
    /// </summary>
    public TerraformProperty<string> DesiredState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_state");
        set => SetProperty("desired_state", value);
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    public TerraformProperty<string> Enrichment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("enrichment");
        set => SetProperty("enrichment", value);
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
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_identifier");
        set => SetProperty("kms_key_identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
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
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target");
        set => SetProperty("target", value);
    }

    /// <summary>
    /// Block for enrichment_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnrichmentParameters block(s) allowed")]
    public List<AwsPipesPipeEnrichmentParametersBlock>? EnrichmentParameters
    {
        set => SetProperty("enrichment_parameters", value);
    }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public List<AwsPipesPipeLogConfigurationBlock>? LogConfiguration
    {
        set => SetProperty("log_configuration", value);
    }

    /// <summary>
    /// Block for source_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceParameters block(s) allowed")]
    public List<AwsPipesPipeSourceParametersBlock>? SourceParameters
    {
        set => SetProperty("source_parameters", value);
    }

    /// <summary>
    /// Block for target_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetParameters block(s) allowed")]
    public List<AwsPipesPipeTargetParametersBlock>? TargetParameters
    {
        set => SetProperty("target_parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsPipesPipeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
