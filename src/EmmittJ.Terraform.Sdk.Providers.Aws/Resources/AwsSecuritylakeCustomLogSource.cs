using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeCustomLogSourceConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_securitylake_custom_log_source resource.
/// </summary>
public class AwsSecuritylakeCustomLogSource : TerraformResource
{
    public AwsSecuritylakeCustomLogSource(string name) : base("aws_securitylake_custom_log_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attributes");
        this.DeclareOutput("id");
        this.DeclareOutput("provider_details");
    }

    /// <summary>
    /// The event_classes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EventClasses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("event_classes");
        set => this.WithProperty("event_classes", value);
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
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformProperty<string> SourceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_name");
        set => this.WithProperty("source_name", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVersion
    {
        get => GetProperty<TerraformProperty<string>>("source_version");
        set => this.WithProperty("source_version", value);
    }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSecuritylakeCustomLogSourceConfigurationBlock>? Configuration
    {
        get => GetProperty<List<AwsSecuritylakeCustomLogSourceConfigurationBlock>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformExpression Attributes => this["attributes"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    public TerraformExpression ProviderDetails => this["provider_details"];

}
