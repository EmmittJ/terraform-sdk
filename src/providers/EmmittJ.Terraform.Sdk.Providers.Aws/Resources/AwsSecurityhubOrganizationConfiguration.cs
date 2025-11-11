using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for organization_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecurityhubOrganizationConfigurationOrganizationConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The configuration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationType is required")]
    [TerraformProperty("configuration_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigurationType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsSecurityhubOrganizationConfigurationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_securityhub_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSecurityhubOrganizationConfiguration : TerraformResource
{
    public AwsSecurityhubOrganizationConfiguration(string name) : base("aws_securityhub_organization_configuration", name)
    {
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnable is required")]
    [TerraformProperty("auto_enable")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AutoEnable { get; set; }

    /// <summary>
    /// The auto_enable_standards attribute.
    /// </summary>
    [TerraformProperty("auto_enable_standards")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AutoEnableStandards { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for organization_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationConfiguration block(s) allowed")]
    [TerraformProperty("organization_configuration")]
    public partial TerraformList<TerraformBlock<AwsSecurityhubOrganizationConfigurationOrganizationConfigurationBlock>>? OrganizationConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsSecurityhubOrganizationConfigurationTimeoutsBlock>? Timeouts { get; set; }

}
