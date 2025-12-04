using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for request in AzurermApiManagementApiOperation.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// QueryParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockQueryParameterBlock>? QueryParameter
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockQueryParameterBlock>>("query_parameter");
        set => SetArgument("query_parameter", value);
    }

    /// <summary>
    /// Representation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlock>? Representation
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlock>>("representation");
        set => SetArgument("representation", value);
    }

}

/// <summary>
/// Block type for header in AzurermApiManagementApiOperationRequestBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => GetRequiredArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockHeaderBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockHeaderBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationRequestBlockHeaderBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockHeaderBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for query_parameter in AzurermApiManagementApiOperationRequestBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockQueryParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_parameter";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => GetRequiredArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockQueryParameterBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockQueryParameterBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationRequestBlockQueryParameterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockQueryParameterBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for representation in AzurermApiManagementApiOperationRequestBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockRepresentationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "representation";

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformValue<string> ContentType
    {
        get => GetRequiredArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

    /// <summary>
    /// FormParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlockFormParameterBlock>? FormParameter
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlockFormParameterBlock>>("form_parameter");
        set => SetArgument("form_parameter", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationRequestBlockRepresentationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockRepresentationBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for form_parameter in AzurermApiManagementApiOperationRequestBlockRepresentationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockRepresentationBlockFormParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "form_parameter";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => GetRequiredArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlockFormParameterBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlockRepresentationBlockFormParameterBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationRequestBlockRepresentationBlockFormParameterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationRequestBlockRepresentationBlockFormParameterBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for response in AzurermApiManagementApiOperation.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "response";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The status_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCode is required")]
    public required TerraformValue<double> StatusCode
    {
        get => GetRequiredArgument<TerraformValue<double>>("status_code");
        set => SetArgument("status_code", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationResponseBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationResponseBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// Representation block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlock>? Representation
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlock>>("representation");
        set => SetArgument("representation", value);
    }

}

/// <summary>
/// Block type for header in AzurermApiManagementApiOperationResponseBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => GetRequiredArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationResponseBlockHeaderBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationResponseBlockHeaderBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationResponseBlockHeaderBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlockHeaderBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for representation in AzurermApiManagementApiOperationResponseBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlockRepresentationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "representation";

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformValue<string> ContentType
    {
        get => GetRequiredArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

    /// <summary>
    /// FormParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlockFormParameterBlock>? FormParameter
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlockFormParameterBlock>>("form_parameter");
        set => SetArgument("form_parameter", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationResponseBlockRepresentationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlockRepresentationBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for form_parameter in AzurermApiManagementApiOperationResponseBlockRepresentationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlockRepresentationBlockFormParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "form_parameter";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => GetRequiredArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlockFormParameterBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationResponseBlockRepresentationBlockFormParameterBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationResponseBlockRepresentationBlockFormParameterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationResponseBlockRepresentationBlockFormParameterBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for template_parameter in AzurermApiManagementApiOperation.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationTemplateParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_parameter";

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required is required")]
    public required TerraformValue<bool> Required
    {
        get => GetRequiredArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The schema_id attribute.
    /// </summary>
    public TerraformValue<string>? SchemaId
    {
        get => GetArgument<TerraformValue<string>>("schema_id");
        set => SetArgument("schema_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

    /// <summary>
    /// Example block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationTemplateParameterBlockExampleBlock>? Example
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationTemplateParameterBlockExampleBlock>>("example");
        set => SetArgument("example", value);
    }

}

/// <summary>
/// Block type for example in AzurermApiManagementApiOperationTemplateParameterBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementApiOperationTemplateParameterBlockExampleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "example";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_value attribute.
    /// </summary>
    public TerraformValue<string>? ExternalValue
    {
        get => GetArgument<TerraformValue<string>>("external_value");
        set => SetArgument("external_value", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    public TerraformValue<string>? Summary
    {
        get => GetArgument<TerraformValue<string>>("summary");
        set => SetArgument("summary", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermApiManagementApiOperation.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiOperationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_api_operation Terraform resource.
/// Manages a azurerm_api_management_api_operation resource.
/// </summary>
public partial class AzurermApiManagementApiOperation(string name) : TerraformResource("azurerm_api_management_api_operation", name)
{
    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The api_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiName is required")]
    public required TerraformValue<string> ApiName
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_name");
        set => SetArgument("api_name", value);
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
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformValue<string> Method
    {
        get => GetRequiredArgument<TerraformValue<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperationId is required")]
    public required TerraformValue<string> OperationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("operation_id");
        set => SetArgument("operation_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The url_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UrlTemplate is required")]
    public required TerraformValue<string> UrlTemplate
    {
        get => GetRequiredArgument<TerraformValue<string>>("url_template");
        set => SetArgument("url_template", value);
    }

    /// <summary>
    /// Request block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    public TerraformList<AzurermApiManagementApiOperationRequestBlock>? Request
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationRequestBlock>>("request");
        set => SetArgument("request", value);
    }

    /// <summary>
    /// Response block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationResponseBlock>? Response
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationResponseBlock>>("response");
        set => SetArgument("response", value);
    }

    /// <summary>
    /// TemplateParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApiManagementApiOperationTemplateParameterBlock>? TemplateParameter
    {
        get => GetArgument<TerraformList<AzurermApiManagementApiOperationTemplateParameterBlock>>("template_parameter");
        set => SetArgument("template_parameter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiOperationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiOperationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
