using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trace_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsApprunnerObservabilityConfigurationTraceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformProperty<string>? Vendor
    {
        set => SetProperty("vendor", value);
    }

}

/// <summary>
/// Manages a aws_apprunner_observability_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsApprunnerObservabilityConfiguration : TerraformResource
{
    public AwsApprunnerObservabilityConfiguration(string name) : base("aws_apprunner_observability_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("latest");
        SetOutput("observability_configuration_revision");
        SetOutput("status");
        SetOutput("id");
        SetOutput("observability_configuration_name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The observability_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityConfigurationName is required")]
    public required TerraformProperty<string> ObservabilityConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("observability_configuration_name");
        set => SetProperty("observability_configuration_name", value);
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
    /// Block for trace_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TraceConfiguration block(s) allowed")]
    public List<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock>? TraceConfiguration
    {
        set => SetProperty("trace_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformExpression Latest => this["latest"];

    /// <summary>
    /// The observability_configuration_revision attribute.
    /// </summary>
    public TerraformExpression ObservabilityConfigurationRevision => this["observability_configuration_revision"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
