using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_guardduty_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGuarddutyOrganizationConfiguration : TerraformResource
{
    public AwsGuarddutyOrganizationConfiguration(string name) : base("aws_guardduty_organization_configuration", name)
    {
    }

    /// <summary>
    /// The auto_enable_organization_members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnableOrganizationMembers is required")]
    [TerraformPropertyName("auto_enable_organization_members")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutoEnableOrganizationMembers { get; set; }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    [TerraformPropertyName("detector_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DetectorId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for datasources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("datasources")]
    public TerraformList<TerraformBlock<AwsGuarddutyOrganizationConfigurationDatasourcesBlock>>? Datasources { get; set; } = new();

}
