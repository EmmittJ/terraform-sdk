using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    }

    /// <summary>
    /// The resource ID of the application to which the owner should be added
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// Object ID of the principal that will be granted ownership of the application
    /// </summary>
    public TerraformProperty<string>? OwnerObjectId
    {
        get => GetProperty<TerraformProperty<string>>("owner_object_id");
        set => this.WithProperty("owner_object_id", value);
    }

}
