using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_access_package resource.
/// </summary>
public class AzureadAccessPackage : TerraformResource
{
    public AzureadAccessPackage(string name) : base("azuread_access_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("catalog_id");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("hidden");
        SetOutput("id");
    }

    /// <summary>
    /// The ID of the Catalog this access package will be created in
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The description of the access package
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display name of the access package
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Whether the access package is hidden from the requestor
    /// </summary>
    public TerraformProperty<bool> Hidden
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hidden");
        set => SetProperty("hidden", value);
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
    public AzureadAccessPackageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
