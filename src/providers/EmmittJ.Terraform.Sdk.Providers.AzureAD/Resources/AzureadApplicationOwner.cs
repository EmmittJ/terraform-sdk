using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationOwnerTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azuread_application_owner resource.
/// </summary>
public class AzureadApplicationOwner : TerraformResource
{
    public AzureadApplicationOwner(string name) : base("azuread_application_owner", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_id");
        SetOutput("id");
        SetOutput("owner_object_id");
    }

    /// <summary>
    /// The resource ID of the application to which the owner should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
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
    /// Object ID of the principal that will be granted ownership of the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerObjectId is required")]
    public required TerraformProperty<string> OwnerObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_object_id");
        set => SetProperty("owner_object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationOwnerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
