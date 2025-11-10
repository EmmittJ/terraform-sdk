using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageCatalogDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azuread_access_package_catalog.
/// </summary>
public class AzureadAccessPackageCatalogDataSource : TerraformDataSource
{
    public AzureadAccessPackageCatalogDataSource(string name) : base("azuread_access_package_catalog", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("externally_visible");
        SetOutput("published");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("object_id");
    }

    /// <summary>
    /// The display name of the access package catalog
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
    /// The ID of this access package catalog
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
    public AzureadAccessPackageCatalogDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The description of the access package catalog
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    public TerraformExpression ExternallyVisible => this["externally_visible"];

    /// <summary>
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    public TerraformExpression Published => this["published"];

}
