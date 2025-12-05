using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_project_service Terraform data source.
/// Retrieves information about a google_project_service.
/// </summary>
public partial class GoogleProjectServiceDataSource(string name) : TerraformDataSource("google_project_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    public TerraformValue<bool> DisableDependentServices
        => CreateReference("disable_dependent_services");

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    public TerraformValue<bool> DisableOnDestroy
        => CreateReference("disable_on_destroy");

}
