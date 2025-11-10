using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementWorkspacePolicyFragmentTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_workspace_policy_fragment resource.
/// </summary>
public class AzurermApiManagementWorkspacePolicyFragment : TerraformResource
{
    public AzurermApiManagementWorkspacePolicyFragment(string name) : base("azurerm_api_management_workspace_policy_fragment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_management_workspace_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("xml_content");
        SetOutput("xml_format");
    }

    /// <summary>
    /// The api_management_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementWorkspaceId is required")]
    public required TerraformProperty<string> ApiManagementWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_workspace_id");
        set => SetProperty("api_management_workspace_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The xml_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "XmlContent is required")]
    public required TerraformProperty<string> XmlContent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xml_content");
        set => SetProperty("xml_content", value);
    }

    /// <summary>
    /// The xml_format attribute.
    /// </summary>
    public TerraformProperty<string> XmlFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xml_format");
        set => SetProperty("xml_format", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementWorkspacePolicyFragmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
