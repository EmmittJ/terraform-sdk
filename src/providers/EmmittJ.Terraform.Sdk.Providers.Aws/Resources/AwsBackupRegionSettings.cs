using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_region_settings resource.
/// </summary>
public partial class AwsBackupRegionSettings : TerraformResource
{
    public AwsBackupRegionSettings(string name) : base("aws_backup_region_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_type_management_preference attribute.
    /// </summary>
    [TerraformProperty("resource_type_management_preference")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<bool> ResourceTypeManagementPreference { get; set; }

    /// <summary>
    /// The resource_type_opt_in_preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeOptInPreference is required")]
    [TerraformProperty("resource_type_opt_in_preference")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<bool> ResourceTypeOptInPreference { get; set; }

}
