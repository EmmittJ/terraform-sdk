using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesKeyCertFileTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Read operations occur during any refresh or planning operation when refresh is enabled.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// An alias from a key/cert file.
/// </summary>
public class GoogleApigeeKeystoresAliasesKeyCertFile : TerraformResource
{
    public GoogleApigeeKeystoresAliasesKeyCertFile(string name) : base("google_apigee_keystores_aliases_key_cert_file", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certs_info");
        SetOutput("id");
        SetOutput("type");
        SetOutput("alias");
        SetOutput("cert");
        SetOutput("environment");
        SetOutput("key");
        SetOutput("keystore");
        SetOutput("org_id");
        SetOutput("password");
    }

    /// <summary>
    /// Alias Name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformProperty<string> Alias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias");
        set => SetProperty("alias", value);
    }

    /// <summary>
    /// Cert content.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cert is required")]
    public required TerraformProperty<string> Cert
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cert");
        set => SetProperty("cert", value);
    }

    /// <summary>
    /// Environment associated with the alias.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// Private Key content, omit if uploading to truststore.
    /// </summary>
    public TerraformProperty<string> Key
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key");
        set => SetProperty("key", value);
    }

    /// <summary>
    /// Keystore Name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    public required TerraformProperty<string> Keystore
    {
        get => GetRequiredOutput<TerraformProperty<string>>("keystore");
        set => SetProperty("keystore", value);
    }

    /// <summary>
    /// Organization ID associated with the alias.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeKeystoresAliasesKeyCertFileTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    public TerraformExpression CertsInfo => this["certs_info"];

    /// <summary>
    /// Project identifier
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// Optional. Type of Alias.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
