using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryCredentialUserManagedIdentityTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_credential_user_managed_identity resource.
/// </summary>
public class AzurermDataFactoryCredentialUserManagedIdentity : TerraformResource
{
    public AzurermDataFactoryCredentialUserManagedIdentity(string name) : base("azurerm_data_factory_credential_user_managed_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("annotations");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("identity_id");
        SetOutput("name");
    }

    /// <summary>
    /// (Optional) List of string annotations.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The resource ID of the parent Data Factory
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// (Optional) Short text description
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
    /// The resource ID of the User Assigned Managed Identity
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityId is required")]
    public required TerraformProperty<string> IdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_id");
        set => SetProperty("identity_id", value);
    }

    /// <summary>
    /// The desired name of the credential resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryCredentialUserManagedIdentityTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
