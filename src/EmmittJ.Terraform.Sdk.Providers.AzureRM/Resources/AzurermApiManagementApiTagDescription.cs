using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_api_tag_description resource.
/// </summary>
public class AzurermApiManagementApiTagDescription : TerraformResource
{
    public AzurermApiManagementApiTagDescription(string name) : base("azurerm_api_management_api_tag_description", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_tag_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiTagId
    {
        get => GetProperty<TerraformProperty<string>>("api_tag_id");
        set => this.WithProperty("api_tag_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalDocumentationDescription
    {
        get => GetProperty<TerraformProperty<string>>("external_documentation_description");
        set => this.WithProperty("external_documentation_description", value);
    }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalDocumentationUrl
    {
        get => GetProperty<TerraformProperty<string>>("external_documentation_url");
        set => this.WithProperty("external_documentation_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
