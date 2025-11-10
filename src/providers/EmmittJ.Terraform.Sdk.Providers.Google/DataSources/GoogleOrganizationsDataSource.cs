using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organizations.
/// </summary>
public class GoogleOrganizationsDataSource : TerraformDataSource
{
    public GoogleOrganizationsDataSource(string name) : base("google_organizations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("organizations");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The organizations attribute.
    /// </summary>
    public TerraformExpression Organizations => this["organizations"];

}
