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
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Object ID of the principal that will be granted ownership of the application
    /// </summary>
    public string? OwnerObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_object_id")?.Value;
        set => this.WithProperty("owner_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
