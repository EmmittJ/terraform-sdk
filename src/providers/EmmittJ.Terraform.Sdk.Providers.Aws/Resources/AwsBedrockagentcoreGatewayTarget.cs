using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credential_provider_configuration in AwsBedrockagentcoreGatewayTarget.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credential_provider_configuration";

    /// <summary>
    /// ApiKey block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockApiKeyBlock>? ApiKey
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockApiKeyBlock>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// GatewayIamRole block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockGatewayIamRoleBlock>? GatewayIamRole
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockGatewayIamRoleBlock>>("gateway_iam_role");
        set => SetArgument("gateway_iam_role", value);
    }

    /// <summary>
    /// Oauth block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockOauthBlock>? Oauth
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockOauthBlock>>("oauth");
        set => SetArgument("oauth", value);
    }

}

/// <summary>
/// Block type for api_key in AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockApiKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key";

    /// <summary>
    /// The credential_location attribute.
    /// </summary>
    public TerraformValue<string>? CredentialLocation
    {
        get => new TerraformReference<string>(this, "credential_location");
        set => SetArgument("credential_location", value);
    }

    /// <summary>
    /// The credential_parameter_name attribute.
    /// </summary>
    public TerraformValue<string>? CredentialParameterName
    {
        get => new TerraformReference<string>(this, "credential_parameter_name");
        set => SetArgument("credential_parameter_name", value);
    }

    /// <summary>
    /// The credential_prefix attribute.
    /// </summary>
    public TerraformValue<string>? CredentialPrefix
    {
        get => new TerraformReference<string>(this, "credential_prefix");
        set => SetArgument("credential_prefix", value);
    }

    /// <summary>
    /// The provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderArn is required")]
    public required TerraformValue<string> ProviderArn
    {
        get => new TerraformReference<string>(this, "provider_arn");
        set => SetArgument("provider_arn", value);
    }

}

/// <summary>
/// Block type for gateway_iam_role in AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockGatewayIamRoleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gateway_iam_role";

}

/// <summary>
/// Block type for oauth in AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlockOauthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth";

    /// <summary>
    /// The custom_parameters attribute.
    /// </summary>
    public TerraformMap<string>? CustomParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "custom_parameters").ResolveNodes(ctx));
        set => SetArgument("custom_parameters", value);
    }

    /// <summary>
    /// The provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderArn is required")]
    public required TerraformValue<string> ProviderArn
    {
        get => new TerraformReference<string>(this, "provider_arn");
        set => SetArgument("provider_arn", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

}


/// <summary>
/// Block type for target_configuration in AwsBedrockagentcoreGatewayTarget.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_configuration";

    /// <summary>
    /// Mcp block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlock>? Mcp
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlock>>("mcp");
        set => SetArgument("mcp", value);
    }

}

/// <summary>
/// Block type for mcp in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mcp";

    /// <summary>
    /// Lambda block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlock>? Lambda
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlock>>("lambda");
        set => SetArgument("lambda", value);
    }

    /// <summary>
    /// OpenApiSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlock>? OpenApiSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlock>>("open_api_schema");
        set => SetArgument("open_api_schema", value);
    }

    /// <summary>
    /// SmithyModel block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlock>? SmithyModel
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlock>>("smithy_model");
        set => SetArgument("smithy_model", value);
    }

}

/// <summary>
/// Block type for lambda in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => new TerraformReference<string>(this, "lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

    /// <summary>
    /// ToolSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlock>? ToolSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlock>>("tool_schema");
        set => SetArgument("tool_schema", value);
    }

}

/// <summary>
/// Block type for tool_schema in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tool_schema";

    /// <summary>
    /// InlinePayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlock>? InlinePayload
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlock>>("inline_payload");
        set => SetArgument("inline_payload", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for inline_payload in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_payload";

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// InputSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlock>? InputSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlock>>("input_schema");
        set => SetArgument("input_schema", value);
    }

    /// <summary>
    /// OutputSchema block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlock>? OutputSchema
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlock>>("output_schema");
        set => SetArgument("output_schema", value);
    }

}

/// <summary>
/// Block type for input_schema in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_schema";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockItemsBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockItemsBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockInputSchemaBlockPropertyBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for output_schema in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_schema";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockItemsBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Items block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Property block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformSet<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for items in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockItemsBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for property in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlock.
/// Nesting mode: set
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockInlinePayloadBlockOutputSchemaBlockPropertyBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The items_json attribute.
    /// </summary>
    public TerraformValue<string>? ItemsJson
    {
        get => new TerraformReference<string>(this, "items_json");
        set => SetArgument("items_json", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties_json attribute.
    /// </summary>
    public TerraformValue<string>? PropertiesJson
    {
        get => new TerraformReference<string>(this, "properties_json");
        set => SetArgument("properties_json", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool> Required
    {
        get => new TerraformReference<bool>(this, "required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for s3 in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockLambdaBlockToolSchemaBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwnerAccountId
    {
        get => new TerraformReference<string>(this, "bucket_owner_account_id");
        set => SetArgument("bucket_owner_account_id", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for open_api_schema in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_api_schema";

    /// <summary>
    /// InlinePayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlockInlinePayloadBlock>? InlinePayload
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlockInlinePayloadBlock>>("inline_payload");
        set => SetArgument("inline_payload", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for inline_payload in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlockInlinePayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_payload";

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformValue<string> Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

}

/// <summary>
/// Block type for s3 in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockOpenApiSchemaBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwnerAccountId
    {
        get => new TerraformReference<string>(this, "bucket_owner_account_id");
        set => SetArgument("bucket_owner_account_id", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for smithy_model in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "smithy_model";

    /// <summary>
    /// InlinePayload block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlockInlinePayloadBlock>? InlinePayload
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlockInlinePayloadBlock>>("inline_payload");
        set => SetArgument("inline_payload", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for inline_payload in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlockInlinePayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_payload";

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformValue<string> Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

}

/// <summary>
/// Block type for s3 in AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTargetConfigurationBlockMcpBlockSmithyModelBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwnerAccountId
    {
        get => new TerraformReference<string>(this, "bucket_owner_account_id");
        set => SetArgument("bucket_owner_account_id", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentcoreGatewayTarget.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentcoreGatewayTargetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagentcore_gateway_target Terraform resource.
/// Manages a aws_bedrockagentcore_gateway_target resource.
/// </summary>
public partial class AwsBedrockagentcoreGatewayTarget(string name) : TerraformResource("aws_bedrockagentcore_gateway_target", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The gateway_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GatewayIdentifier is required")]
    public required TerraformValue<string> GatewayIdentifier
    {
        get => new TerraformReference<string>(this, "gateway_identifier");
        set => SetArgument("gateway_identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformValue<string> TargetId
    {
        get => new TerraformReference<string>(this, "target_id");
    }

    /// <summary>
    /// CredentialProviderConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlock>? CredentialProviderConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetCredentialProviderConfigurationBlock>>("credential_provider_configuration");
        set => SetArgument("credential_provider_configuration", value);
    }

    /// <summary>
    /// TargetConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlock>? TargetConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreGatewayTargetTargetConfigurationBlock>>("target_configuration");
        set => SetArgument("target_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentcoreGatewayTargetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentcoreGatewayTargetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
