using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalsDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azuread_service_principals.
/// </summary>
public class AzureadServicePrincipalsDataSource : TerraformDataSource
{
    public AzureadServicePrincipalsDataSource(string name) : base("azuread_service_principals", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("service_principals");
        SetOutput("client_ids");
        SetOutput("display_names");
        SetOutput("id");
        SetOutput("ignore_missing");
        SetOutput("object_ids");
        SetOutput("return_all");
    }

    /// <summary>
    /// The client IDs of the applications associated with the service principals
    /// </summary>
    public List<TerraformProperty<string>> ClientIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("client_ids");
        set => SetProperty("client_ids", value);
    }

    /// <summary>
    /// The display names of the applications associated with the service principals
    /// </summary>
    public List<TerraformProperty<string>> DisplayNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("display_names");
        set => SetProperty("display_names", value);
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
    /// Ignore missing service principals and return the service principals that were found. The data source will still fail if no service principals are found
    /// </summary>
    public TerraformProperty<bool> IgnoreMissing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_missing");
        set => SetProperty("ignore_missing", value);
    }

    /// <summary>
    /// The object IDs of the service principals
    /// </summary>
    public List<TerraformProperty<string>> ObjectIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("object_ids");
        set => SetProperty("object_ids", value);
    }

    /// <summary>
    /// Fetch all service principals with no filter and return all that were found. The data source will still fail if no service principals are found.
    /// </summary>
    public TerraformProperty<bool> ReturnAll
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("return_all");
        set => SetProperty("return_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A list of service_principals
    /// </summary>
    public TerraformExpression ServicePrincipals => this["service_principals"];

}
