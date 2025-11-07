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
    public TerraformLiteralProperty<bool>? DisableDependentServices
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_dependent_services");
        set => this.WithProperty("disable_dependent_services", value);
    }

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableOnDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_on_destroy");
        set => this.WithProperty("disable_on_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

}
