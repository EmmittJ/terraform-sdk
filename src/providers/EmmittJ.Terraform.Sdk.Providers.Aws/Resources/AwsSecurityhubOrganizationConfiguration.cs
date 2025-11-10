using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for organization_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubOrganizationConfigurationOrganizationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The configuration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationType is required")]
    public required TerraformProperty<string> ConfigurationType
    {
        set => SetProperty("configuration_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSecurityhubOrganizationConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_securityhub_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSecurityhubOrganizationConfiguration : TerraformResource
{
    public AwsSecurityhubOrganizationConfiguration(string name) : base("aws_securityhub_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_enable");
        SetOutput("auto_enable_standards");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    public required TerraformProperty<bool> AutoEnable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_enable");
        set => SetProperty("auto_enable", value);
    }

    /// <summary>
    /// The auto_enable_standards attribute.
    /// </summary>
    public TerraformProperty<string> AutoEnableStandards
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_enable_standards");
        set => SetProperty("auto_enable_standards", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for organization_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationConfiguration block(s) allowed")]
    public List<AwsSecurityhubOrganizationConfigurationOrganizationConfigurationBlock>? OrganizationConfiguration
    {
        set => SetProperty("organization_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSecurityhubOrganizationConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
