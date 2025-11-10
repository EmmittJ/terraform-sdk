using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_tiers.
/// </summary>
public class GoogleSqlTiersDataSource : TerraformDataSource
{
    public GoogleSqlTiersDataSource(string name) : base("google_sql_tiers", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("tiers");
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
    /// Project ID of the project for which to list tiers.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The tiers attribute.
    /// </summary>
    public TerraformExpression Tiers => this["tiers"];

}
