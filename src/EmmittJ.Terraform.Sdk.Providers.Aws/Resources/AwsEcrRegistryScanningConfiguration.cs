using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: set
/// </summary>
public class AwsEcrRegistryScanningConfigurationRuleBlock : TerraformBlock
{
    /// <summary>
    /// The scan_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanFrequency is required")]
    public required TerraformProperty<string> ScanFrequency
    {
        get => GetProperty<TerraformProperty<string>>("scan_frequency");
        set => WithProperty("scan_frequency", value);
    }

}

/// <summary>
/// Manages a aws_ecr_registry_scanning_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcrRegistryScanningConfiguration : TerraformResource
{
    public AwsEcrRegistryScanningConfiguration(string name) : base("aws_ecr_registry_scanning_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("registry_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The scan_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanType is required")]
    public required TerraformProperty<string> ScanType
    {
        get => GetProperty<TerraformProperty<string>>("scan_type");
        set => this.WithProperty("scan_type", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Rule block(s) allowed")]
    public HashSet<AwsEcrRegistryScanningConfigurationRuleBlock>? Rule
    {
        get => GetProperty<HashSet<AwsEcrRegistryScanningConfigurationRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformExpression RegistryId => this["registry_id"];

}
