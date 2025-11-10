using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for service_principal_key in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock : TerraformBlock
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => WithProperty("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformProperty<string> SecretName
    {
        get => GetProperty<TerraformProperty<string>>("secret_name");
        set => WithProperty("secret_name", value);
    }

    /// <summary>
    /// The secret_version attribute.
    /// </summary>
    public TerraformProperty<string>? SecretVersion
    {
        get => GetProperty<TerraformProperty<string>>("secret_version");
        set => WithProperty("secret_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_credential_service_principal resource.
/// </summary>
public class AzurermDataFactoryCredentialServicePrincipal : TerraformResource
{
    public AzurermDataFactoryCredentialServicePrincipal(string name) : base("azurerm_data_factory_credential_service_principal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// (Optional) List of string annotations.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The resource ID of the parent Data Factory
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// (Optional) Short text description
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The desired name of the credential resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Client ID of the Service Principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// The Tenant ID of the Service Principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// Block for service_principal_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipalKey block(s) allowed")]
    public List<AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock>? ServicePrincipalKey
    {
        get => GetProperty<List<AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock>>("service_principal_key");
        set => this.WithProperty("service_principal_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
