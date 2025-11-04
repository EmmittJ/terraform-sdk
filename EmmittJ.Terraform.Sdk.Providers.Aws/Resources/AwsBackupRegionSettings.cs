using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_region_settings resource.
/// </summary>
public class AwsBackupRegionSettings : TerraformResource
{
    public AwsBackupRegionSettings(string name) : base("aws_backup_region_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_type_management_preference attribute.
    /// </summary>
    public Dictionary<string, bool>? ResourceTypeManagementPreference
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, bool>>>("resource_type_management_preference")?.Value;
        set => this.WithProperty("resource_type_management_preference", value == null ? null : new TerraformLiteralProperty<Dictionary<string, bool>>(value));
    }

    /// <summary>
    /// The resource_type_opt_in_preference attribute.
    /// </summary>
    public Dictionary<string, bool>? ResourceTypeOptInPreference
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, bool>>>("resource_type_opt_in_preference")?.Value;
        set => this.WithProperty("resource_type_opt_in_preference", value == null ? null : new TerraformLiteralProperty<Dictionary<string, bool>>(value));
    }

}
