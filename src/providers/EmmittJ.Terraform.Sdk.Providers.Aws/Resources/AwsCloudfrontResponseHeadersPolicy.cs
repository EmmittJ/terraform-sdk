using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_config in AwsCloudfrontResponseHeadersPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_config";

    /// <summary>
    /// The access_control_allow_credentials attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowCredentials is required")]
    public required TerraformValue<bool> AccessControlAllowCredentials
    {
        get => GetRequiredArgument<TerraformValue<bool>>("access_control_allow_credentials");
        set => SetArgument("access_control_allow_credentials", value);
    }

    /// <summary>
    /// The access_control_max_age_sec attribute.
    /// </summary>
    public TerraformValue<double>? AccessControlMaxAgeSec
    {
        get => GetArgument<TerraformValue<double>>("access_control_max_age_sec");
        set => SetArgument("access_control_max_age_sec", value);
    }

    /// <summary>
    /// The origin_override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginOverride is required")]
    public required TerraformValue<bool> OriginOverride
    {
        get => GetRequiredArgument<TerraformValue<bool>>("origin_override");
        set => SetArgument("origin_override", value);
    }

    /// <summary>
    /// AccessControlAllowHeaders block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowHeaders is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessControlAllowHeaders block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlAllowHeaders block(s) allowed")]
    public required TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowHeadersBlock> AccessControlAllowHeaders
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowHeadersBlock>>("access_control_allow_headers");
        set => SetArgument("access_control_allow_headers", value);
    }

    /// <summary>
    /// AccessControlAllowMethods block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowMethods is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessControlAllowMethods block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlAllowMethods block(s) allowed")]
    public required TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowMethodsBlock> AccessControlAllowMethods
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowMethodsBlock>>("access_control_allow_methods");
        set => SetArgument("access_control_allow_methods", value);
    }

    /// <summary>
    /// AccessControlAllowOrigins block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowOrigins is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessControlAllowOrigins block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlAllowOrigins block(s) allowed")]
    public required TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowOriginsBlock> AccessControlAllowOrigins
    {
        get => GetRequiredArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowOriginsBlock>>("access_control_allow_origins");
        set => SetArgument("access_control_allow_origins", value);
    }

    /// <summary>
    /// AccessControlExposeHeaders block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlExposeHeaders block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlExposeHeadersBlock>? AccessControlExposeHeaders
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlExposeHeadersBlock>>("access_control_expose_headers");
        set => SetArgument("access_control_expose_headers", value);
    }

}

/// <summary>
/// Block type for access_control_allow_headers in AwsCloudfrontResponseHeadersPolicyCorsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control_allow_headers";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => GetArgument<TerraformSet<string>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for access_control_allow_methods in AwsCloudfrontResponseHeadersPolicyCorsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowMethodsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control_allow_methods";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => GetArgument<TerraformSet<string>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for access_control_allow_origins in AwsCloudfrontResponseHeadersPolicyCorsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlAllowOriginsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control_allow_origins";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => GetArgument<TerraformSet<string>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for access_control_expose_headers in AwsCloudfrontResponseHeadersPolicyCorsConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlockAccessControlExposeHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control_expose_headers";

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformSet<string>? Items
    {
        get => GetArgument<TerraformSet<string>>("items");
        set => SetArgument("items", value);
    }

}


/// <summary>
/// Block type for custom_headers_config in AwsCloudfrontResponseHeadersPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_headers_config";

    /// <summary>
    /// Items block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformSet<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    public required TerraformValue<string> Header
    {
        get => GetRequiredArgument<TerraformValue<string>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// The override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverrideAttribute is required")]
    public required TerraformValue<bool> OverrideAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for remove_headers_config in AwsCloudfrontResponseHeadersPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remove_headers_config";

    /// <summary>
    /// Items block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformSet<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

}

/// <summary>
/// Block type for items in AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    public required TerraformValue<string> Header
    {
        get => GetRequiredArgument<TerraformValue<string>>("header");
        set => SetArgument("header", value);
    }

}


/// <summary>
/// Block type for security_headers_config in AwsCloudfrontResponseHeadersPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_headers_config";

    /// <summary>
    /// ContentSecurityPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentSecurityPolicy block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockContentSecurityPolicyBlock>? ContentSecurityPolicy
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockContentSecurityPolicyBlock>>("content_security_policy");
        set => SetArgument("content_security_policy", value);
    }

    /// <summary>
    /// ContentTypeOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTypeOptions block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockContentTypeOptionsBlock>? ContentTypeOptions
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockContentTypeOptionsBlock>>("content_type_options");
        set => SetArgument("content_type_options", value);
    }

    /// <summary>
    /// FrameOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrameOptions block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockFrameOptionsBlock>? FrameOptions
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockFrameOptionsBlock>>("frame_options");
        set => SetArgument("frame_options", value);
    }

    /// <summary>
    /// ReferrerPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferrerPolicy block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockReferrerPolicyBlock>? ReferrerPolicy
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockReferrerPolicyBlock>>("referrer_policy");
        set => SetArgument("referrer_policy", value);
    }

    /// <summary>
    /// StrictTransportSecurity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StrictTransportSecurity block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockStrictTransportSecurityBlock>? StrictTransportSecurity
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockStrictTransportSecurityBlock>>("strict_transport_security");
        set => SetArgument("strict_transport_security", value);
    }

    /// <summary>
    /// XssProtection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XssProtection block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockXssProtectionBlock>? XssProtection
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockXssProtectionBlock>>("xss_protection");
        set => SetArgument("xss_protection", value);
    }

}

/// <summary>
/// Block type for content_security_policy in AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockContentSecurityPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_security_policy";

    /// <summary>
    /// The content_security_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentSecurityPolicy is required")]
    public required TerraformValue<string> ContentSecurityPolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("content_security_policy");
        set => SetArgument("content_security_policy", value);
    }

    /// <summary>
    /// The override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverrideAttribute is required")]
    public required TerraformValue<bool> OverrideAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for content_type_options in AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockContentTypeOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content_type_options";

    /// <summary>
    /// The override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverrideAttribute is required")]
    public required TerraformValue<bool> OverrideAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for frame_options in AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockFrameOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frame_options";

    /// <summary>
    /// The frame_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameOption is required")]
    public required TerraformValue<string> FrameOption
    {
        get => GetRequiredArgument<TerraformValue<string>>("frame_option");
        set => SetArgument("frame_option", value);
    }

    /// <summary>
    /// The override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverrideAttribute is required")]
    public required TerraformValue<bool> OverrideAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for referrer_policy in AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockReferrerPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "referrer_policy";

    /// <summary>
    /// The override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverrideAttribute is required")]
    public required TerraformValue<bool> OverrideAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

    /// <summary>
    /// The referrer_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferrerPolicy is required")]
    public required TerraformValue<string> ReferrerPolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("referrer_policy");
        set => SetArgument("referrer_policy", value);
    }

}

/// <summary>
/// Block type for strict_transport_security in AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockStrictTransportSecurityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "strict_transport_security";

    /// <summary>
    /// The access_control_max_age_sec attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlMaxAgeSec is required")]
    public required TerraformValue<double> AccessControlMaxAgeSec
    {
        get => GetRequiredArgument<TerraformValue<double>>("access_control_max_age_sec");
        set => SetArgument("access_control_max_age_sec", value);
    }

    /// <summary>
    /// The include_subdomains attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSubdomains
    {
        get => GetArgument<TerraformValue<bool>>("include_subdomains");
        set => SetArgument("include_subdomains", value);
    }

    /// <summary>
    /// The override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverrideAttribute is required")]
    public required TerraformValue<bool> OverrideAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

    /// <summary>
    /// The preload attribute.
    /// </summary>
    public TerraformValue<bool>? Preload
    {
        get => GetArgument<TerraformValue<bool>>("preload");
        set => SetArgument("preload", value);
    }

}

/// <summary>
/// Block type for xss_protection in AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlockXssProtectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "xss_protection";

    /// <summary>
    /// The mode_block attribute.
    /// </summary>
    public TerraformValue<bool>? ModeBlock
    {
        get => GetArgument<TerraformValue<bool>>("mode_block");
        set => SetArgument("mode_block", value);
    }

    /// <summary>
    /// The override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverrideAttribute is required")]
    public required TerraformValue<bool> OverrideAttribute
    {
        get => GetRequiredArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

    /// <summary>
    /// The protection attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protection is required")]
    public required TerraformValue<bool> Protection
    {
        get => GetRequiredArgument<TerraformValue<bool>>("protection");
        set => SetArgument("protection", value);
    }

    /// <summary>
    /// The report_uri attribute.
    /// </summary>
    public TerraformValue<string>? ReportUri
    {
        get => GetArgument<TerraformValue<string>>("report_uri");
        set => SetArgument("report_uri", value);
    }

}


/// <summary>
/// Block type for server_timing_headers_config in AwsCloudfrontResponseHeadersPolicy.
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_timing_headers_config";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    public required TerraformValue<double> SamplingRate
    {
        get => GetRequiredArgument<TerraformValue<double>>("sampling_rate");
        set => SetArgument("sampling_rate", value);
    }

}


/// <summary>
/// Represents a aws_cloudfront_response_headers_policy Terraform resource.
/// Manages a aws_cloudfront_response_headers_policy resource.
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicy(string name) : TerraformResource("aws_cloudfront_response_headers_policy", name)
{
    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// CorsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock>? CorsConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock>>("cors_config");
        set => SetArgument("cors_config", value);
    }

    /// <summary>
    /// CustomHeadersConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHeadersConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock>? CustomHeadersConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock>>("custom_headers_config");
        set => SetArgument("custom_headers_config", value);
    }

    /// <summary>
    /// RemoveHeadersConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoveHeadersConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock>? RemoveHeadersConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock>>("remove_headers_config");
        set => SetArgument("remove_headers_config", value);
    }

    /// <summary>
    /// SecurityHeadersConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHeadersConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock>? SecurityHeadersConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock>>("security_headers_config");
        set => SetArgument("security_headers_config", value);
    }

    /// <summary>
    /// ServerTimingHeadersConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerTimingHeadersConfig block(s) allowed")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock>? ServerTimingHeadersConfig
    {
        get => GetArgument<TerraformList<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock>>("server_timing_headers_config");
        set => SetArgument("server_timing_headers_config", value);
    }

}
