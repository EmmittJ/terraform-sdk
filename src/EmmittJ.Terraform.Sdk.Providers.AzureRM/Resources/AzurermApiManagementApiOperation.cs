using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for request in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

}

/// <summary>
/// Block type for response in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformProperty<double> StatusCode
    {
        get => GetProperty<TerraformProperty<double>>("status_code");
        set => WithProperty("status_code", value);
    }

}

/// <summary>
/// Block type for template_parameter in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationTemplateParameterBlock : TerraformBlock
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultValue
    {
        get => GetProperty<TerraformProperty<string>>("default_value");
        set => WithProperty("default_value", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformProperty<bool> Required
    {
        get => GetProperty<TerraformProperty<bool>>("required");
        set => WithProperty("required", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformProperty<string>? SchemaId
    {
        get => GetProperty<TerraformProperty<string>>("schema_id");
        set => WithProperty("schema_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformProperty<string>? TypeName
    {
        get => GetProperty<TerraformProperty<string>>("type_name");
        set => WithProperty("type_name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiOperationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_api_operation resource.
/// </summary>
public class AzurermApiManagementApiOperation : TerraformResource
{
    public AzurermApiManagementApiOperation(string name) : base("azurerm_api_management_api_operation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformProperty<string> ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The api_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiName is required")]
    public required TerraformProperty<string> ApiName
    {
        get => GetProperty<TerraformProperty<string>>("api_name");
        set => this.WithProperty("api_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformProperty<string> Method
    {
        get => GetProperty<TerraformProperty<string>>("method");
        set => this.WithProperty("method", value);
    }

    /// <summary>
    /// The operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperationId is required")]
    public required TerraformProperty<string> OperationId
    {
        get => GetProperty<TerraformProperty<string>>("operation_id");
        set => this.WithProperty("operation_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    public required TerraformProperty<string> UrlTemplate
    {
        get => GetProperty<TerraformProperty<string>>("url_template");
        set => this.WithProperty("url_template", value);
    }

    /// <summary>
    /// Block for request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    public List<AzurermApiManagementApiOperationRequestBlock>? Request
    {
        get => GetProperty<List<AzurermApiManagementApiOperationRequestBlock>>("request");
        set => this.WithProperty("request", value);
    }

    /// <summary>
    /// Block for response.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementApiOperationResponseBlock>? Response
    {
        get => GetProperty<List<AzurermApiManagementApiOperationResponseBlock>>("response");
        set => this.WithProperty("response", value);
    }

    /// <summary>
    /// Block for template_parameter.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermApiManagementApiOperationTemplateParameterBlock>? TemplateParameter
    {
        get => GetProperty<List<AzurermApiManagementApiOperationTemplateParameterBlock>>("template_parameter");
        set => this.WithProperty("template_parameter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementApiOperationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApiManagementApiOperationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
