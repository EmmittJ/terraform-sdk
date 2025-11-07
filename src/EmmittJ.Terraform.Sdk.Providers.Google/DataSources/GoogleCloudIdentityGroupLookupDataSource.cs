using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_identity_group_lookup.
/// </summary>
public class GoogleCloudIdentityGroupLookupDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupLookupDataSource(string name) : base("google_cloud_identity_group_lookup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The [resource name](https://cloud.google.com/apis/design/resource_names) of the looked-up Group.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
