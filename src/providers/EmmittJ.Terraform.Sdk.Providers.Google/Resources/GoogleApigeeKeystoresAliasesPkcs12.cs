using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_apigee_keystores_aliases_pkcs12 resource.
/// </summary>
public class GoogleApigeeKeystoresAliasesPkcs12 : TerraformResource
{
    public GoogleApigeeKeystoresAliasesPkcs12(string name) : base("google_apigee_keystores_aliases_pkcs12", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certs_info");
        SetOutput("type");
        SetOutput("alias");
        SetOutput("environment");
        SetOutput("file");
        SetOutput("filehash");
        SetOutput("id");
        SetOutput("keystore");
        SetOutput("org_id");
        SetOutput("password");
    }

    /// <summary>
    /// Alias Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformProperty<string> Alias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias");
        set => SetProperty("alias", value);
    }

    /// <summary>
    /// Environment associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// Cert content
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "File is required")]
    public required TerraformProperty<string> File
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file");
        set => SetProperty("file", value);
    }

    /// <summary>
    /// Hash of the pkcs file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filehash is required")]
    public required TerraformProperty<string> Filehash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filehash");
        set => SetProperty("filehash", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Keystore Name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    public required TerraformProperty<string> Keystore
    {
        get => GetRequiredOutput<TerraformProperty<string>>("keystore");
        set => SetProperty("keystore", value);
    }

    /// <summary>
    /// Organization ID associated with the alias
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted
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
    public GoogleApigeeKeystoresAliasesPkcs12TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    public TerraformExpression CertsInfo => this["certs_info"];

    /// <summary>
    /// Optional.Type of Alias
    /// </summary>
    public TerraformExpression Type => this["type"];

}
