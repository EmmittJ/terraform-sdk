using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_region_settings resource.
/// </summary>
public class AwsBackupRegionSettings : TerraformResource
{
    public AwsBackupRegionSettings(string name) : base("aws_backup_region_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_type_management_preference attribute.
    /// </summary>
    [TerraformPropertyName("resource_type_management_preference")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<bool> ResourceTypeManagementPreference { get; set; } = default!;

    /// <summary>
    /// The resource_type_opt_in_preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeOptInPreference is required")]
    [TerraformPropertyName("resource_type_opt_in_preference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformMap<bool> ResourceTypeOptInPreference { get; set; }

}
