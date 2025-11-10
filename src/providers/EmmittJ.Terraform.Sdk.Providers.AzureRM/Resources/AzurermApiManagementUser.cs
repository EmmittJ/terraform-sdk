using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementUserTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_user resource.
/// </summary>
public class AzurermApiManagementUser : TerraformResource
{
    public AzurermApiManagementUser(string name) : base("azurerm_api_management_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_management_name");
        SetOutput("confirmation");
        SetOutput("email");
        SetOutput("first_name");
        SetOutput("id");
        SetOutput("last_name");
        SetOutput("note");
        SetOutput("password");
        SetOutput("resource_group_name");
        SetOutput("state");
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
    /// The confirmation attribute.
    /// </summary>
    public TerraformProperty<string> Confirmation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("confirmation");
        set => SetProperty("confirmation", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    public required TerraformProperty<string> FirstName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("first_name");
        set => SetProperty("first_name", value);
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
    /// The last_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    public required TerraformProperty<string> LastName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("last_name");
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The note attribute.
    /// </summary>
    public TerraformProperty<string> Note
    {
        get => GetRequiredOutput<TerraformProperty<string>>("note");
        set => SetProperty("note", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
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
    public AzurermApiManagementUserTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
