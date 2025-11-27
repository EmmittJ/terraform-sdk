using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_redaction_configuration in AwsWorkspaceswebDataProtectionSettings.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_redaction_configuration";

    /// <summary>
    /// The global_confidence_level attribute.
    /// </summary>
    public TerraformValue<double>? GlobalConfidenceLevel
    {
        get => new TerraformReference<double>(this, "global_confidence_level");
        set => SetArgument("global_confidence_level", value);
    }

    /// <summary>
    /// The global_enforced_urls attribute.
    /// </summary>
    public TerraformList<string>? GlobalEnforcedUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "global_enforced_urls").ResolveNodes(ctx));
        set => SetArgument("global_enforced_urls", value);
    }

    /// <summary>
    /// The global_exempt_urls attribute.
    /// </summary>
    public TerraformList<string>? GlobalExemptUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "global_exempt_urls").ResolveNodes(ctx));
        set => SetArgument("global_exempt_urls", value);
    }

    /// <summary>
    /// InlineRedactionPattern block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock>? InlineRedactionPattern
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock>>("inline_redaction_pattern");
        set => SetArgument("inline_redaction_pattern", value);
    }

}

/// <summary>
/// Block type for inline_redaction_pattern in AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_redaction_pattern";

    /// <summary>
    /// The built_in_pattern_id attribute.
    /// </summary>
    public TerraformValue<string>? BuiltInPatternId
    {
        get => new TerraformReference<string>(this, "built_in_pattern_id");
        set => SetArgument("built_in_pattern_id", value);
    }

    /// <summary>
    /// The confidence_level attribute.
    /// </summary>
    public TerraformValue<double>? ConfidenceLevel
    {
        get => new TerraformReference<double>(this, "confidence_level");
        set => SetArgument("confidence_level", value);
    }

    /// <summary>
    /// The enforced_urls attribute.
    /// </summary>
    public TerraformList<string>? EnforcedUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "enforced_urls").ResolveNodes(ctx));
        set => SetArgument("enforced_urls", value);
    }

    /// <summary>
    /// The exempt_urls attribute.
    /// </summary>
    public TerraformList<string>? ExemptUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "exempt_urls").ResolveNodes(ctx));
        set => SetArgument("exempt_urls", value);
    }

    /// <summary>
    /// CustomPattern block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockCustomPatternBlock>? CustomPattern
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockCustomPatternBlock>>("custom_pattern");
        set => SetArgument("custom_pattern", value);
    }

    /// <summary>
    /// RedactionPlaceHolder block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockRedactionPlaceHolderBlock>? RedactionPlaceHolder
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockRedactionPlaceHolderBlock>>("redaction_place_holder");
        set => SetArgument("redaction_place_holder", value);
    }

}

/// <summary>
/// Block type for custom_pattern in AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockCustomPatternBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_pattern";

    /// <summary>
    /// The keyword_regex attribute.
    /// </summary>
    public TerraformValue<string>? KeywordRegex
    {
        get => new TerraformReference<string>(this, "keyword_regex");
        set => SetArgument("keyword_regex", value);
    }

    /// <summary>
    /// The pattern_description attribute.
    /// </summary>
    public TerraformValue<string>? PatternDescription
    {
        get => new TerraformReference<string>(this, "pattern_description");
        set => SetArgument("pattern_description", value);
    }

    /// <summary>
    /// The pattern_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternName is required")]
    public required TerraformValue<string> PatternName
    {
        get => new TerraformReference<string>(this, "pattern_name");
        set => SetArgument("pattern_name", value);
    }

    /// <summary>
    /// The pattern_regex attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternRegex is required")]
    public required TerraformValue<string> PatternRegex
    {
        get => new TerraformReference<string>(this, "pattern_regex");
        set => SetArgument("pattern_regex", value);
    }

}

/// <summary>
/// Block type for redaction_place_holder in AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockRedactionPlaceHolderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redaction_place_holder";

    /// <summary>
    /// The redaction_place_holder_text attribute.
    /// </summary>
    public TerraformValue<string>? RedactionPlaceHolderText
    {
        get => new TerraformReference<string>(this, "redaction_place_holder_text");
        set => SetArgument("redaction_place_holder_text", value);
    }

    /// <summary>
    /// The redaction_place_holder_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedactionPlaceHolderType is required")]
    public required TerraformValue<string> RedactionPlaceHolderType
    {
        get => new TerraformReference<string>(this, "redaction_place_holder_type");
        set => SetArgument("redaction_place_holder_type", value);
    }

}


/// <summary>
/// Represents a aws_workspacesweb_data_protection_settings Terraform resource.
/// Manages a aws_workspacesweb_data_protection_settings resource.
/// </summary>
public partial class AwsWorkspaceswebDataProtectionSettings(string name) : TerraformResource("aws_workspacesweb_data_protection_settings", name)
{
    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalEncryptionContext
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_encryption_context").ResolveNodes(ctx));
        set => SetArgument("additional_encryption_context", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => new TerraformReference<string>(this, "customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "associated_portal_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> DataProtectionSettingsArn
    {
        get => new TerraformReference<string>(this, "data_protection_settings_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// InlineRedactionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock>? InlineRedactionConfiguration
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock>>("inline_redaction_configuration");
        set => SetArgument("inline_redaction_configuration", value);
    }

}
