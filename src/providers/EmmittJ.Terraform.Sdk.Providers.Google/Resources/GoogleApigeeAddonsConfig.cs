using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for addons_config in GoogleApigeeAddonsConfig.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAddonsConfigAddonsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "addons_config";

    /// <summary>
    /// AdvancedApiOpsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedApiOpsConfig block(s) allowed")]
    public TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockAdvancedApiOpsConfigBlock>? AdvancedApiOpsConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockAdvancedApiOpsConfigBlock>>("advanced_api_ops_config");
        set => SetArgument("advanced_api_ops_config", value);
    }

    /// <summary>
    /// ApiSecurityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiSecurityConfig block(s) allowed")]
    public TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockApiSecurityConfigBlock>? ApiSecurityConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockApiSecurityConfigBlock>>("api_security_config");
        set => SetArgument("api_security_config", value);
    }

    /// <summary>
    /// ConnectorsPlatformConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectorsPlatformConfig block(s) allowed")]
    public TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockConnectorsPlatformConfigBlock>? ConnectorsPlatformConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockConnectorsPlatformConfigBlock>>("connectors_platform_config");
        set => SetArgument("connectors_platform_config", value);
    }

    /// <summary>
    /// IntegrationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IntegrationConfig block(s) allowed")]
    public TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockIntegrationConfigBlock>? IntegrationConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockIntegrationConfigBlock>>("integration_config");
        set => SetArgument("integration_config", value);
    }

    /// <summary>
    /// MonetizationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonetizationConfig block(s) allowed")]
    public TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockMonetizationConfigBlock>? MonetizationConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlockMonetizationConfigBlock>>("monetization_config");
        set => SetArgument("monetization_config", value);
    }

}

/// <summary>
/// Block type for advanced_api_ops_config in GoogleApigeeAddonsConfigAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAddonsConfigAddonsConfigBlockAdvancedApiOpsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_api_ops_config";

    /// <summary>
    /// Flag that specifies whether the Advanced API Ops add-on is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for api_security_config in GoogleApigeeAddonsConfigAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAddonsConfigAddonsConfigBlockApiSecurityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_security_config";

    /// <summary>
    /// Flag that specifies whether the API security add-on is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Time at which the API Security add-on expires in in milliseconds since epoch. If unspecified, the add-on will never expire.
    /// </summary>
    public TerraformValue<string> ExpiresAt
        => CreateReference("expires_at");

}

/// <summary>
/// Block type for connectors_platform_config in GoogleApigeeAddonsConfigAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAddonsConfigAddonsConfigBlockConnectorsPlatformConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connectors_platform_config";

    /// <summary>
    /// Flag that specifies whether the Connectors Platform add-on is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Time at which the Connectors Platform add-on expires in milliseconds since epoch. If unspecified, the add-on will never expire.
    /// </summary>
    public TerraformValue<string> ExpiresAt
        => CreateReference("expires_at");

}

/// <summary>
/// Block type for integration_config in GoogleApigeeAddonsConfigAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAddonsConfigAddonsConfigBlockIntegrationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "integration_config";

    /// <summary>
    /// Flag that specifies whether the Integration add-on is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for monetization_config in GoogleApigeeAddonsConfigAddonsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAddonsConfigAddonsConfigBlockMonetizationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monetization_config";

    /// <summary>
    /// Flag that specifies whether the Monetization add-on is enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeAddonsConfig.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeAddonsConfigTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apigee_addons_config Terraform resource.
/// Manages a google_apigee_addons_config resource.
/// </summary>
public partial class GoogleApigeeAddonsConfig(string name) : TerraformResource("google_apigee_addons_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the Apigee organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Org is required")]
    public required TerraformValue<string> Org
    {
        get => GetRequiredArgument<TerraformValue<string>>("org");
        set => SetArgument("org", value);
    }

    /// <summary>
    /// AddonsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AddonsConfig block(s) allowed")]
    public TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlock>? AddonsConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeAddonsConfigAddonsConfigBlock>>("addons_config");
        set => SetArgument("addons_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeAddonsConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeAddonsConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
