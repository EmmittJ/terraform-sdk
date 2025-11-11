using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_environment_blueprint_configuration resource.
/// </summary>
public class AwsDatazoneEnvironmentBlueprintConfiguration : TerraformResource
{
    public AwsDatazoneEnvironmentBlueprintConfiguration(string name) : base("aws_datazone_environment_blueprint_configuration", name)
    {
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    [TerraformPropertyName("domain_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainId { get; set; }

    /// <summary>
    /// The enabled_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledRegions is required")]
    [TerraformPropertyName("enabled_regions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? EnabledRegions { get; set; }

    /// <summary>
    /// The environment_blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintId is required")]
    [TerraformPropertyName("environment_blueprint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EnvironmentBlueprintId { get; set; }

    /// <summary>
    /// The manage_access_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("manage_access_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManageAccessRoleArn { get; set; }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProvisioningRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The regional_parameters attribute.
    /// </summary>
    [TerraformPropertyName("regional_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<TerraformMap<string>>? RegionalParameters { get; set; }

}
