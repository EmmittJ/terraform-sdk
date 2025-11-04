using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_service resource.
/// </summary>
public class GoogleProjectService : TerraformResource
{
    public GoogleProjectService(string name) : base("google_project_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    public bool? DisableDependentServices
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_dependent_services")?.Value;
        set => this.WithProperty("disable_dependent_services", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    public bool? DisableOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_on_destroy")?.Value;
        set => this.WithProperty("disable_on_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
