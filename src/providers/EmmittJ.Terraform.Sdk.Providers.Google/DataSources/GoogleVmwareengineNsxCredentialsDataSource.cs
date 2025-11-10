using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_nsx_credentials.
/// </summary>
public class GoogleVmwareengineNsxCredentialsDataSource : TerraformDataSource
{
    public GoogleVmwareengineNsxCredentialsDataSource(string name) : base("google_vmwareengine_nsx_credentials", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("password");
        SetOutput("username");
        SetOutput("id");
        SetOutput("parent");
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
    /// The resource name of the private cloud which contains NSX.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Initial password.
    /// </summary>
    public TerraformExpression Password => this["password"];

    /// <summary>
    /// Initial username.
    /// </summary>
    public TerraformExpression Username => this["username"];

}
