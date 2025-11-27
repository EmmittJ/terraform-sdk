using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeKeystoresAliasesKeyCertFile.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesKeyCertFileTimeoutsBlock : TerraformBlock
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
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Read operations occur during any refresh or planning operation when refresh is enabled.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a google_apigee_keystores_aliases_key_cert_file Terraform resource.
/// An alias from a key/cert file.
/// </summary>
public partial class GoogleApigeeKeystoresAliasesKeyCertFile(string name) : TerraformResource("google_apigee_keystores_aliases_key_cert_file", name)
{
    /// <summary>
    /// Alias Name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// Cert content.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cert is required")]
    public required TerraformValue<string> Cert
    {
        get => new TerraformReference<string>(this, "cert");
        set => SetArgument("cert", value);
    }

    /// <summary>
    /// Environment associated with the alias.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// Private Key content, omit if uploading to truststore.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Keystore Name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    public required TerraformValue<string> Keystore
    {
        get => new TerraformReference<string>(this, "keystore");
        set => SetArgument("keystore", value);
    }

    /// <summary>
    /// Organization ID associated with the alias.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertsInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certs_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// Project identifier
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Optional. Type of Alias.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeKeystoresAliasesKeyCertFileTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeKeystoresAliasesKeyCertFileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
