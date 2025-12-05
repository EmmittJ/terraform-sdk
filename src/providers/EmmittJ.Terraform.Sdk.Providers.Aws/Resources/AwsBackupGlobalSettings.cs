using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_backup_global_settings Terraform resource.
/// Manages a aws_backup_global_settings resource.
/// </summary>
public partial class AwsBackupGlobalSettings(string name) : TerraformResource("aws_backup_global_settings", name)
{
    /// <summary>
    /// The global_settings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalSettings is required")]
    public required TerraformMap<string> GlobalSettings
    {
        get => GetRequiredArgument<TerraformMap<string>>("global_settings");
        set => SetArgument("global_settings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

}
