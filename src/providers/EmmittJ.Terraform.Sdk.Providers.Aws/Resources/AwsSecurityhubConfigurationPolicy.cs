using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration_policy in .
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The enabled_standard_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EnabledStandardArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("enabled_standard_arns");
        set => WithProperty("enabled_standard_arns", value);
    }

    /// <summary>
    /// The service_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceEnabled is required")]
    public required TerraformProperty<bool> ServiceEnabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("service_enabled");
        set => WithProperty("service_enabled", value);
    }

}

/// <summary>
/// Manages a aws_securityhub_configuration_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSecurityhubConfigurationPolicy : TerraformResource
{
    public AwsSecurityhubConfigurationPolicy(string name) : base("aws_securityhub_configuration_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
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
    /// Block for configuration_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConfigurationPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationPolicy block(s) allowed")]
    public List<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock>? ConfigurationPolicy
    {
        get => GetProperty<List<AwsSecurityhubConfigurationPolicyConfigurationPolicyBlock>>("configuration_policy");
        set => this.WithProperty("configuration_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
