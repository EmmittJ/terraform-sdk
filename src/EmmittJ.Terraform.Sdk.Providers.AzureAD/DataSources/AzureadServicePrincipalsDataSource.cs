using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public List<string>? ClientIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("client_ids")?.Value;
        set => this.WithProperty("client_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The display names of the applications associated with the service principals
    /// </summary>
    public List<string>? DisplayNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("display_names")?.Value;
        set => this.WithProperty("display_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Ignore missing service principals and return the service principals that were found. The data source will still fail if no service principals are found
    /// </summary>
    public bool? IgnoreMissing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_missing")?.Value;
        set => this.WithProperty("ignore_missing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The object IDs of the service principals
    /// </summary>
    public List<string>? ObjectIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("object_ids")?.Value;
        set => this.WithProperty("object_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Fetch all service principals with no filter and return all that were found. The data source will still fail if no service principals are found.
    /// </summary>
    public bool? ReturnAll
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("return_all")?.Value;
        set => this.WithProperty("return_all", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A list of service_principals
    /// </summary>
    public TerraformExpression ServicePrincipals => this["service_principals"];

}
