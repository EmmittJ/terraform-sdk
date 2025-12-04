using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataFactoryLinkedServiceKusto.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceKustoTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory_linked_service_kusto Terraform resource.
/// Manages a azurerm_data_factory_linked_service_kusto resource.
/// </summary>
public partial class AzurermDataFactoryLinkedServiceKusto(string name) : TerraformResource("azurerm_data_factory_linked_service_kusto", name)
{
    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalProperties
    {
        get => GetArgument<TerraformMap<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformList<string>? Annotations
    {
        get => GetArgument<TerraformList<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationRuntimeName
    {
        get => GetArgument<TerraformValue<string>>("integration_runtime_name");
        set => SetArgument("integration_runtime_name", value);
    }

    /// <summary>
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    public required TerraformValue<string> KustoDatabaseName
    {
        get => GetArgument<TerraformValue<string>>("kusto_database_name");
        set => SetArgument("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoEndpoint is required")]
    public required TerraformValue<string> KustoEndpoint
    {
        get => GetArgument<TerraformValue<string>>("kusto_endpoint");
        set => SetArgument("kusto_endpoint", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    public TerraformValue<string>? ServicePrincipalId
    {
        get => GetArgument<TerraformValue<string>>("service_principal_id");
        set => SetArgument("service_principal_id", value);
    }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    public TerraformValue<string>? ServicePrincipalKey
    {
        get => GetArgument<TerraformValue<string>>("service_principal_key");
        set => SetArgument("service_principal_key", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public TerraformValue<string>? Tenant
    {
        get => GetArgument<TerraformValue<string>>("tenant");
        set => SetArgument("tenant", value);
    }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    public TerraformValue<bool>? UseManagedIdentity
    {
        get => GetArgument<TerraformValue<bool>>("use_managed_identity");
        set => SetArgument("use_managed_identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryLinkedServiceKustoTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryLinkedServiceKustoTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
