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
    public TerraformLiteralProperty<string>? ApiTagId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_tag_id");
        set => this.WithProperty("api_tag_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExternalDocumentationDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_documentation_description");
        set => this.WithProperty("external_documentation_description", value);
    }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExternalDocumentationUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_documentation_url");
        set => this.WithProperty("external_documentation_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
