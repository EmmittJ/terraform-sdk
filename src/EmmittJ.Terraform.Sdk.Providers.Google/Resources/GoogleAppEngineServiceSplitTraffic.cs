using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_app_engine_service_split_traffic resource.
/// </summary>
public class GoogleAppEngineServiceSplitTraffic : TerraformResource
{
    public GoogleAppEngineServiceSplitTraffic(string name) : base("google_app_engine_service_split_traffic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// If set to true traffic will be migrated to this version.
    /// </summary>
    public TerraformProperty<bool>? MigrateTraffic
    {
        get => GetProperty<TerraformProperty<bool>>("migrate_traffic");
        set => this.WithProperty("migrate_traffic", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the service these settings apply to.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

}
