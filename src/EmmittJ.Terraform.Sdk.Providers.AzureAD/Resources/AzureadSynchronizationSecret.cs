using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for credential in .
/// Nesting mode: list
/// </summary>
public class AzureadSynchronizationSecretCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Name for this key-value pair.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// Value for this key-value pair.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadSynchronizationSecretTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The object ID of the service principal for which this synchronization secret should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// Block for credential.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadSynchronizationSecretCredentialBlock>? Credential
    {
        get => GetProperty<List<AzureadSynchronizationSecretCredentialBlock>>("credential");
        set => this.WithProperty("credential", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadSynchronizationSecretTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadSynchronizationSecretTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
