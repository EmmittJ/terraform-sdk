using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiTagDescriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("api_tag_id");
        SetOutput("description");
        SetOutput("external_documentation_description");
        SetOutput("external_documentation_url");
        SetOutput("id");
    }

    /// <summary>
    /// The api_tag_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiTagId is required")]
    public required TerraformProperty<string> ApiTagId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_tag_id");
        set => SetProperty("api_tag_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    public TerraformProperty<string> ExternalDocumentationDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("external_documentation_description");
        set => SetProperty("external_documentation_description", value);
    }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    public TerraformProperty<string> ExternalDocumentationUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("external_documentation_url");
        set => SetProperty("external_documentation_url", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementApiTagDescriptionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
