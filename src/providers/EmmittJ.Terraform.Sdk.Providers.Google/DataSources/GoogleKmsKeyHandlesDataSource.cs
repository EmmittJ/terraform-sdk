using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_key_handles.
/// </summary>
public class GoogleKmsKeyHandlesDataSource : TerraformDataSource
{
    public GoogleKmsKeyHandlesDataSource(string name) : base("google_kms_key_handles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("key_handles");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("resource_type_selector");
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
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// 
    /// 					The resource_type_selector argument is used to add a filter query parameter that limits which key handles are retrieved by the data source: ?filter=resource_type_selector=&amp;quot;{{resource_type_selector}}&amp;quot;.
    /// 					Example values:
    /// 					* resource_type_selector=&amp;quot;{SERVICE}.googleapis.com/{TYPE}&amp;quot;.
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyHandles/list)
    /// 				
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeSelector is required")]
    public required TerraformProperty<string> ResourceTypeSelector
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type_selector");
        set => SetProperty("resource_type_selector", value);
    }

    /// <summary>
    /// A list of all the retrieved key handles
    /// </summary>
    public TerraformExpression KeyHandles => this["key_handles"];

}
