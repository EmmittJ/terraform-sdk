using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_synchronization_secret resource.
/// </summary>
public class AzureadSynchronizationSecret : TerraformResource
{
    public AzureadSynchronizationSecret(string name) : base("azuread_synchronization_secret", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The object ID of the service principal for which this synchronization secret should be created
    /// </summary>
    public string? ServicePrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_id")?.Value;
        set => this.WithProperty("service_principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
