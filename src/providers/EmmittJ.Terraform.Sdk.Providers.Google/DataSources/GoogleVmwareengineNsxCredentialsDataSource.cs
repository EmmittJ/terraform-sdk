using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_vmwareengine_nsx_credentials Terraform data source.
/// Retrieves information about a google_vmwareengine_nsx_credentials.
/// </summary>
public partial class GoogleVmwareengineNsxCredentialsDataSource(string name) : TerraformDataSource("google_vmwareengine_nsx_credentials", name)
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
    /// The resource name of the private cloud which contains NSX.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Initial password.
    /// </summary>
    public TerraformValue<string> Password
        => AsReference("password");

    /// <summary>
    /// Initial username.
    /// </summary>
    public TerraformValue<string> Username
        => AsReference("username");

}
