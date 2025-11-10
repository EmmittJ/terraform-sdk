using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_images.
/// </summary>
public class GoogleComputeImagesDataSource : TerraformDataSource
{
    public GoogleComputeImagesDataSource(string name) : base("google_compute_images", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("images");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformProperty<string> Filter
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The images attribute.
    /// </summary>
    public TerraformExpression Images => this["images"];

}
