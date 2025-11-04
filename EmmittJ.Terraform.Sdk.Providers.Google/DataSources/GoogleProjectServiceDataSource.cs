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
        this.DeclareOutput("disable_dependent_services");
        this.DeclareOutput("disable_on_destroy");
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

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    public TerraformExpression DisableDependentServices => this["disable_dependent_services"];

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    public TerraformExpression DisableOnDestroy => this["disable_on_destroy"];

}
