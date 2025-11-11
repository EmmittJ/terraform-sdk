using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsGuarddutyOrganizationConfigurationDatasourcesBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_guardduty_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGuarddutyOrganizationConfiguration : TerraformResource
{
    public AwsGuarddutyOrganizationConfiguration(string name) : base("aws_guardduty_organization_configuration", name)
    {
    }

    /// <summary>
    /// The auto_enable_organization_members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnableOrganizationMembers is required")]
    [TerraformProperty("auto_enable_organization_members")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoEnableOrganizationMembers { get; set; }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    [TerraformProperty("detector_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DetectorId { get; set; }

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
    /// Block for datasources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("datasources")]
    public partial TerraformList<TerraformBlock<AwsGuarddutyOrganizationConfigurationDatasourcesBlock>>? Datasources { get; set; }

}
