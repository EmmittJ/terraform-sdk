using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for restrictions in GoogleApikeysKey.
/// Nesting mode: list
/// </summary>
public class GoogleApikeysKeyRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restrictions";

    /// <summary>
    /// AndroidKeyRestrictions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AndroidKeyRestrictions block(s) allowed")]
    public TerraformList<GoogleApikeysKeyRestrictionsBlockAndroidKeyRestrictionsBlock>? AndroidKeyRestrictions
    {
        get => GetArgument<TerraformList<GoogleApikeysKeyRestrictionsBlockAndroidKeyRestrictionsBlock>>("android_key_restrictions");
        set => SetArgument("android_key_restrictions", value);
    }

    /// <summary>
    /// ApiTargets block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApikeysKeyRestrictionsBlockApiTargetsBlock>? ApiTargets
    {
        get => GetArgument<TerraformList<GoogleApikeysKeyRestrictionsBlockApiTargetsBlock>>("api_targets");
        set => SetArgument("api_targets", value);
    }

    /// <summary>
    /// BrowserKeyRestrictions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrowserKeyRestrictions block(s) allowed")]
    public TerraformList<GoogleApikeysKeyRestrictionsBlockBrowserKeyRestrictionsBlock>? BrowserKeyRestrictions
    {
        get => GetArgument<TerraformList<GoogleApikeysKeyRestrictionsBlockBrowserKeyRestrictionsBlock>>("browser_key_restrictions");
        set => SetArgument("browser_key_restrictions", value);
    }

    /// <summary>
    /// IosKeyRestrictions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IosKeyRestrictions block(s) allowed")]
    public TerraformList<GoogleApikeysKeyRestrictionsBlockIosKeyRestrictionsBlock>? IosKeyRestrictions
    {
        get => GetArgument<TerraformList<GoogleApikeysKeyRestrictionsBlockIosKeyRestrictionsBlock>>("ios_key_restrictions");
        set => SetArgument("ios_key_restrictions", value);
    }

    /// <summary>
    /// ServerKeyRestrictions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerKeyRestrictions block(s) allowed")]
    public TerraformList<GoogleApikeysKeyRestrictionsBlockServerKeyRestrictionsBlock>? ServerKeyRestrictions
    {
        get => GetArgument<TerraformList<GoogleApikeysKeyRestrictionsBlockServerKeyRestrictionsBlock>>("server_key_restrictions");
        set => SetArgument("server_key_restrictions", value);
    }

}

/// <summary>
/// Block type for android_key_restrictions in GoogleApikeysKeyRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApikeysKeyRestrictionsBlockAndroidKeyRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "android_key_restrictions";

    /// <summary>
    /// AllowedApplications block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedApplications is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AllowedApplications block(s) required")]
    public required TerraformList<GoogleApikeysKeyRestrictionsBlockAndroidKeyRestrictionsBlockAllowedApplicationsBlock> AllowedApplications
    {
        get => GetRequiredArgument<TerraformList<GoogleApikeysKeyRestrictionsBlockAndroidKeyRestrictionsBlockAllowedApplicationsBlock>>("allowed_applications");
        set => SetArgument("allowed_applications", value);
    }

}

/// <summary>
/// Block type for allowed_applications in GoogleApikeysKeyRestrictionsBlockAndroidKeyRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApikeysKeyRestrictionsBlockAndroidKeyRestrictionsBlockAllowedApplicationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowed_applications";

    /// <summary>
    /// The package name of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformValue<string> PackageName
    {
        get => new TerraformReference<string>(this, "package_name");
        set => SetArgument("package_name", value);
    }

    /// <summary>
    /// The SHA1 fingerprint of the application. For example, both sha1 formats are acceptable : DA:39:A3:EE:5E:6B:4B:0D:32:55:BF:EF:95:60:18:90:AF:D8:07:09 or DA39A3EE5E6B4B0D3255BFEF95601890AFD80709. Output format is the latter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sha1Fingerprint is required")]
    public required TerraformValue<string> Sha1Fingerprint
    {
        get => new TerraformReference<string>(this, "sha1_fingerprint");
        set => SetArgument("sha1_fingerprint", value);
    }

}

/// <summary>
/// Block type for api_targets in GoogleApikeysKeyRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApikeysKeyRestrictionsBlockApiTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_targets";

    /// <summary>
    /// Optional. List of one or more methods that can be called. If empty, all methods for the service are allowed. A wildcard (*) can be used as the last symbol. Valid examples: `google.cloud.translate.v2.TranslateService.GetSupportedLanguage` `TranslateText` `Get*` `translate.googleapis.com.Get*`
    /// </summary>
    public TerraformList<string>? Methods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "methods").ResolveNodes(ctx));
        set => SetArgument("methods", value);
    }

    /// <summary>
    /// The service for this restriction. It should be the canonical service name, for example: `translate.googleapis.com`. You can use `gcloud services list` to get a list of services that are enabled in the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

}

/// <summary>
/// Block type for browser_key_restrictions in GoogleApikeysKeyRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApikeysKeyRestrictionsBlockBrowserKeyRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "browser_key_restrictions";

    /// <summary>
    /// A list of regular expressions for the referrer URLs that are allowed to make API calls with this key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedReferrers is required")]
    public TerraformList<string>? AllowedReferrers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_referrers").ResolveNodes(ctx));
        set => SetArgument("allowed_referrers", value);
    }

}

/// <summary>
/// Block type for ios_key_restrictions in GoogleApikeysKeyRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApikeysKeyRestrictionsBlockIosKeyRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ios_key_restrictions";

    /// <summary>
    /// A list of bundle IDs that are allowed when making API calls with this key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedBundleIds is required")]
    public TerraformList<string>? AllowedBundleIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_bundle_ids").ResolveNodes(ctx));
        set => SetArgument("allowed_bundle_ids", value);
    }

}

/// <summary>
/// Block type for server_key_restrictions in GoogleApikeysKeyRestrictionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApikeysKeyRestrictionsBlockServerKeyRestrictionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_key_restrictions";

    /// <summary>
    /// A list of the caller IP addresses that are allowed to make API calls with this key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedIps is required")]
    public TerraformList<string>? AllowedIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_ips").ResolveNodes(ctx));
        set => SetArgument("allowed_ips", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApikeysKey.
/// Nesting mode: single
/// </summary>
public class GoogleApikeysKeyTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apikeys_key Terraform resource.
/// Manages a google_apikeys_key resource.
/// </summary>
public partial class GoogleApikeysKey(string name) : TerraformResource("google_apikeys_key", name)
{
    /// <summary>
    /// Human-readable display name of this API key. Modifiable by user.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The resource name of the key. The name must be unique within the project, must conform with RFC-1034, is restricted to lower-cased letters, and has a maximum length of 63 characters. In another word, the name must match the regular expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The email of the service account the key is bound to. If this field is specified, the key is a service account bound key and auth enabled. See [Documentation](https://cloud.devsite.corp.google.com/docs/authentication/api-keys?#api-keys-bound-sa) for more details.
    /// </summary>
    public TerraformValue<string>? ServiceAccountEmail
    {
        get => new TerraformReference<string>(this, "service_account_email");
        set => SetArgument("service_account_email", value);
    }

    /// <summary>
    /// Output only. An encrypted and signed value held by this key. This field can be accessed only through the `GetKeyString` method.
    /// </summary>
    public TerraformValue<string> KeyString
    {
        get => new TerraformReference<string>(this, "key_string");
    }

    /// <summary>
    /// Output only. Unique id in UUID4 format.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Restrictions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Restrictions block(s) allowed")]
    public TerraformList<GoogleApikeysKeyRestrictionsBlock>? Restrictions
    {
        get => GetArgument<TerraformList<GoogleApikeysKeyRestrictionsBlock>>("restrictions");
        set => SetArgument("restrictions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApikeysKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApikeysKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
