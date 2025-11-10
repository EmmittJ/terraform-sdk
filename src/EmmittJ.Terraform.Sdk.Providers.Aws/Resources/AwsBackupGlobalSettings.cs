using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_global_settings resource.
/// </summary>
public class AwsBackupGlobalSettings : TerraformResource
{
    public AwsBackupGlobalSettings(string name) : base("aws_backup_global_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The global_settings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalSettings is required")]
    public Dictionary<string, TerraformProperty<string>>? GlobalSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("global_settings");
        set => this.WithProperty("global_settings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
