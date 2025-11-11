using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_global_settings resource.
/// </summary>
public partial class AwsBackupGlobalSettings : TerraformResource
{
    public AwsBackupGlobalSettings(string name) : base("aws_backup_global_settings", name)
    {
    }

    /// <summary>
    /// The global_settings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalSettings is required")]
    [TerraformProperty("global_settings")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> GlobalSettings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

}
