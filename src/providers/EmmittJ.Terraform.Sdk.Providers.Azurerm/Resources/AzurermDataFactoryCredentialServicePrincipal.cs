using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for service_principal_key in AzurermDataFactoryCredentialServicePrincipal.
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_principal_key";

    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformValue<string> LinkedServiceName
    {
        get => new TerraformReference<string>(this, "linked_service_name");
        set => SetArgument("linked_service_name", value);
    }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => new TerraformReference<string>(this, "secret_name");
        set => SetArgument("secret_name", value);
    }

    /// <summary>
    /// The secret_version attribute.
    /// </summary>
    public TerraformValue<string>? SecretVersion
    {
        get => new TerraformReference<string>(this, "secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactoryCredentialServicePrincipal.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory_credential_service_principal Terraform resource.
/// Manages a azurerm_data_factory_credential_service_principal resource.
/// </summary>
public partial class AzurermDataFactoryCredentialServicePrincipal(string name) : TerraformResource("azurerm_data_factory_credential_service_principal", name)
{
    /// <summary>
    /// (Optional) List of string annotations.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The resource ID of the parent Data Factory
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => new TerraformReference<string>(this, "data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// (Optional) Short text description
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The desired name of the credential resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Client ID of the Service Principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformValue<string> ServicePrincipalId
    {
        get => new TerraformReference<string>(this, "service_principal_id");
        set => SetArgument("service_principal_id", value);
    }

    /// <summary>
    /// The Tenant ID of the Service Principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// ServicePrincipalKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipalKey block(s) allowed")]
    public TerraformList<AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock>? ServicePrincipalKey
    {
        get => GetArgument<TerraformList<AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock>>("service_principal_key");
        set => SetArgument("service_principal_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
