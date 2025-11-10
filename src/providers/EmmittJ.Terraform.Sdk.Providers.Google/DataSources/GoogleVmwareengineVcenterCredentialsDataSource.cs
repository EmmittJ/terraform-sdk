using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_vcenter_credentials.
/// </summary>
public class GoogleVmwareengineVcenterCredentialsDataSource : TerraformDataSource
{
    public GoogleVmwareengineVcenterCredentialsDataSource(string name) : base("google_vmwareengine_vcenter_credentials", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("password");
        this.WithOutput("username");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource name of the private cloud which contains vcenter.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
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
