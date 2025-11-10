using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_service.
/// </summary>
public class GoogleProjectServiceDataSource : TerraformDataSource
{
    public GoogleProjectServiceDataSource(string name) : base("google_project_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disable_dependent_services");
        SetOutput("disable_on_destroy");
        SetOutput("id");
        SetOutput("project");
        SetOutput("service");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    public TerraformExpression DisableDependentServices => this["disable_dependent_services"];

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    public TerraformExpression DisableOnDestroy => this["disable_on_destroy"];

}
