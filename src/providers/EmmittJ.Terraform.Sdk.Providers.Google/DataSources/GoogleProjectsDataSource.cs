using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_projects.
/// </summary>
public class GoogleProjectsDataSource : TerraformDataSource
{
    public GoogleProjectsDataSource(string name) : base("google_projects", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("projects");
        SetOutput("filter");
        SetOutput("id");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
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
    /// The projects attribute.
    /// </summary>
    public TerraformExpression Projects => this["projects"];

}
