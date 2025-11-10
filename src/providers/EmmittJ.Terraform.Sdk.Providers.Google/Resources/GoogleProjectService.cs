using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleProjectServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("disable_dependent_services");
        SetOutput("disable_on_destroy");
        SetOutput("id");
        SetOutput("project");
        SetOutput("service");
    }

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    public TerraformProperty<bool> DisableDependentServices
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_dependent_services");
        set => SetProperty("disable_dependent_services", value);
    }

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> DisableOnDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_on_destroy");
        set => SetProperty("disable_on_destroy", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleProjectServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
