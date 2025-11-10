using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azuread_access_package.
/// </summary>
public class AzureadAccessPackageDataSource : TerraformDataSource
{
    public AzureadAccessPackageDataSource(string name) : base("azuread_access_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("hidden");
        SetOutput("catalog_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("object_id");
    }

    /// <summary>
    /// The ID of the Catalog this access package is in
    /// </summary>
    public TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The display name of the access package
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The ID of this access package
    /// </summary>
    public TerraformProperty<string> ObjectId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_id");
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAccessPackageDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The description of the access package
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Whether the access package is hidden from the requestor
    /// </summary>
    public TerraformExpression Hidden => this["hidden"];

}
