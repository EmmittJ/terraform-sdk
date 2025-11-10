using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementWorkspacePolicyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_workspace_policy resource.
/// </summary>
public class AzurermApiManagementWorkspacePolicy : TerraformResource
{
    public AzurermApiManagementWorkspacePolicy(string name) : base("azurerm_api_management_workspace_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_management_workspace_id");
        SetOutput("id");
        SetOutput("xml_content");
        SetOutput("xml_link");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The xml_content attribute.
    /// </summary>
    public TerraformProperty<string> XmlContent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xml_content");
        set => SetProperty("xml_content", value);
    }

    /// <summary>
    /// The xml_link attribute.
    /// </summary>
    public TerraformProperty<string> XmlLink
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xml_link");
        set => SetProperty("xml_link", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementWorkspacePolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
