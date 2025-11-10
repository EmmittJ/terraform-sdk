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
        get => GetProperty<TerraformProperty<string>>("vendor");
        set => WithProperty("vendor", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("latest");
        this.DeclareOutput("observability_configuration_revision");
        this.DeclareOutput("status");
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
    /// The observability_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityConfigurationName is required")]
    public required TerraformProperty<string> ObservabilityConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("observability_configuration_name");
        set => this.WithProperty("observability_configuration_name", value);
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
    /// Block for trace_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TraceConfiguration block(s) allowed")]
    public List<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock>? TraceConfiguration
    {
        get => GetProperty<List<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock>>("trace_configuration");
        set => this.WithProperty("trace_configuration", value);
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
