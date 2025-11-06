using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_backup_dr_service_config resource.
/// </summary>
public class GoogleBackupDrServiceConfig : TerraformResource
{
    public GoogleBackupDrServiceConfig(string name) : base("google_backup_dr_service_config", name)
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
    /// The location in which the Service config is to be initialized.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource type to which the default service config will be applied.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
