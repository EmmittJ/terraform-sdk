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
    public string? ApiTagId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_tag_id")?.Value;
        set => this.WithProperty("api_tag_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    public string? ExternalDocumentationDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_documentation_description")?.Value;
        set => this.WithProperty("external_documentation_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    public string? ExternalDocumentationUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("external_documentation_url")?.Value;
        set => this.WithProperty("external_documentation_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
