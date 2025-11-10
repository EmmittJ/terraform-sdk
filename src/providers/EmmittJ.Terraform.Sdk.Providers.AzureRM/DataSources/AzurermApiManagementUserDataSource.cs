using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementUserDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_user.
/// </summary>
public class AzurermApiManagementUserDataSource : TerraformDataSource
{
    public AzurermApiManagementUserDataSource(string name) : base("azurerm_api_management_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("email");
        SetOutput("first_name");
        SetOutput("last_name");
        SetOutput("note");
        SetOutput("state");
        SetOutput("api_management_name");
        SetOutput("id");
        SetOutput("resource_group_name");
        SetOutput("user_id");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_name");
        set => SetProperty("api_management_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformProperty<string> UserId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_id");
        set => SetProperty("user_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementUserDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformExpression FirstName => this["first_name"];

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformExpression LastName => this["last_name"];

    /// <summary>
    /// The note attribute.
    /// </summary>
    public TerraformExpression Note => this["note"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
