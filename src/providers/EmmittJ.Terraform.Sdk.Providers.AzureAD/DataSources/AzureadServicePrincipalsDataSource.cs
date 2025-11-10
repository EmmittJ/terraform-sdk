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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("service_principals");
    }

    /// <summary>
    /// The client IDs of the applications associated with the service principals
    /// </summary>
    public List<TerraformProperty<string>>? ClientIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("client_ids");
        set => this.WithProperty("client_ids", value);
    }

    /// <summary>
    /// The display names of the applications associated with the service principals
    /// </summary>
    public List<TerraformProperty<string>>? DisplayNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("display_names");
        set => this.WithProperty("display_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Ignore missing service principals and return the service principals that were found. The data source will still fail if no service principals are found
    /// </summary>
    public TerraformProperty<bool>? IgnoreMissing
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_missing");
        set => this.WithProperty("ignore_missing", value);
    }

    /// <summary>
    /// The object IDs of the service principals
    /// </summary>
    public List<TerraformProperty<string>>? ObjectIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("object_ids");
        set => this.WithProperty("object_ids", value);
    }

    /// <summary>
    /// Fetch all service principals with no filter and return all that were found. The data source will still fail if no service principals are found.
    /// </summary>
    public TerraformProperty<bool>? ReturnAll
    {
        get => GetProperty<TerraformProperty<bool>>("return_all");
        set => this.WithProperty("return_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadServicePrincipalsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// A list of service_principals
    /// </summary>
    public TerraformExpression ServicePrincipals => this["service_principals"];

}
