using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_key_handles Terraform data source.
/// Retrieves information about a google_kms_key_handles.
/// </summary>
public partial class GoogleKmsKeyHandlesDataSource(string name) : TerraformDataSource("google_kms_key_handles", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
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
    public required TerraformValue<string> ResourceTypeSelector
    {
        get => GetArgument<TerraformValue<string>>("resource_type_selector");
        set => SetArgument("resource_type_selector", value);
    }

    /// <summary>
    /// A list of all the retrieved key handles
    /// </summary>
    public TerraformList<TerraformMap<object>> KeyHandles
        => AsReference("key_handles");

}
